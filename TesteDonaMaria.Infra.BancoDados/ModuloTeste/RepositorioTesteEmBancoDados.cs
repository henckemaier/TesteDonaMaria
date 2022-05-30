using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDonaMaria.Dominio.ModuloMateria;
using TesteDonaMaria.Dominio.ModuloTeste;

namespace TesteDonaMaria.Infra.BancoDados.ModuloTeste
{
    public class RepositorioTesteEmBancoDados : IRepositorioTeste
    {
        private const string enderecoBanco =
                "Data Source=(LocalDB)\\MSSqlLocalDB;" +
                "Initial Catalog=TesteDonaMariaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";

        private const string sqlInserir =
            @"INSERT INTO[TBTESTE]
            (
                [NUMQUESTOES],   
                [DATACRIACAO],   
                [MATERIA_NUMERO]

	        )
	        VALUES
            (
                @NUMQUESTOES,
                @DATACRIACAO,
                @MATERIA_NUMERO
            );SELECT SCOPE_IDENTITY();";

        private const string sqlEditar =
            @"UPDATE [TBTESTE]
            SET
                [NUMQUESTOES] = @NUMQUESTOES, 
		        [DATACRIACAO] = @DATACRIACAO,
		        [MATERIA_NUMERO] = @MATERIA_NUMERO
	        WHERE
                [NUMERO] = @NUMERO";

        private const string sqlExcluir =
            @"DELETE FROM [TBTESTE]
		    WHERE
			    [NUMERO] = @NUMERO";

        private const string sqlInserirQuestoesTeste =
            @"INSERT INTO [DBO].[TBTESTEQUESTOES]
                (
		            [LETRA],
		            [PERGUNTA],
		            [GABARITO],
                    [BIMESTRE],
                    [TESTE_NUMERO]
	            )
                 VALUES
                (
		            @LETRA,
		            @PERGUNTA,
		            @GABARITO,
                    @BIMESTRE,
                    @TESTE_NUMERO
	            );SELECT SCOPE_IDENTITY();";

        private const string sqlSelecionarQuestoesTeste =
            @"SELECT
                    [NUMERO],
		            [LETRA],
		            [PERGUNTA],
		            [GABARITO],
                    [BIMESTRE],
                    [TESTE_NUMERO]
                FROM 
                    [TBTESTEQUESTOES]
                WHERE
                    [TESTE_NUMERO] = @TESTE_NUMERO";


        private const string sqlSelecionarTodos =
            @"SELECT
                CP.[NUMERO],
                CP.[NUMQUESTOES],   
                CP.[DATACRIACAO],  
                CP.[MATERIA_NUMERO],
                CT.[NOMEMATERIA], 
		        CT.[DISCIPLINA],
		        CT.[SERIE]
            FROM
                [TBTESTE] AS CP INNER JOIN 
                [TBMATERIA] AS CT
            ON
                CT.NUMERO = CP.MATERIA_NUMERO";

        private const string sqlSelecionarPorNumero =
            @"SELECT
                CP.[NUMERO],
                CP.[NUMQUESTOES],   
                CP.[DATACRIACAO],  
                CP.[MATERIA_NUMERO],
                CT.[NOMEMATERIA], 
		        CT.[DISCIPLINA],
		        CT.[SERIE]
            FROM
                [TBTESTE] AS CP INNER JOIN 
                [TBMATERIA] AS CT
            ON
                CT.NUMERO = CP.MATERIA_NUMERO
            WHERE
                CP.[NUMERO] = @NUMERO";


        public ValidationResult Inserir(Teste novoRegistro)
        {
            var validador = new ValidadorTeste();

            var resultadoValidacao = validador.Validate(novoRegistro);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfigurarParametrosTeste(novoRegistro, comandoInsercao);

            conexaoComBanco.Open();
            var id = comandoInsercao.ExecuteScalar();
            novoRegistro.Numero = Convert.ToInt32(id);

            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public ValidationResult Editar(Teste registro)
        {
            var validador = new ValidadorTeste();

            var resultadoValidacao = validador.Validate(registro);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            ConfigurarParametrosTeste(registro, comandoEdicao);

            conexaoComBanco.Open();
            comandoEdicao.ExecuteNonQuery();
            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public ValidationResult Excluir(Teste registro)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("NUMERO", registro.Numero);

            conexaoComBanco.Open();
            int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

            var resultadoValidacao = new ValidationResult();

            if (numeroRegistrosExcluidos == 0)
                resultadoValidacao.Errors.Add(new ValidationFailure("", "Não foi possível remover o registro"));

            conexaoComBanco.Close();
            return resultadoValidacao;
        }

        public void AdicionarQuestoes(Teste testeSelecionado, List<TesteQuestoes> itens)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            foreach (var item in itens)
            {
                testeSelecionado.AdicionarQuestao(item);

                SqlCommand comandoInsercao = new SqlCommand(sqlInserirQuestoesTeste, conexaoComBanco);

                comandoInsercao.Parameters.AddWithValue("TESTE_NUMERO", testeSelecionado.Numero);

                ConfigurarParametrosTesteQuestao(item, comandoInsercao);
                var id = comandoInsercao.ExecuteScalar();
                item.Numero = Convert.ToInt32(id);
            }
            conexaoComBanco.Close();


            Editar(testeSelecionado);
        }

        private void CarregarQuestoes(Teste registro)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarQuestoesTeste, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("TESTE_NUMERO", registro.Numero);

            conexaoComBanco.Open();
            SqlDataReader leitorQuestoesTeste = comandoSelecao.ExecuteReader();

            //List<TesteQuestoes> testeQuestoes = new List<TesteQuestoes>();

            while (leitorQuestoesTeste.Read())
            {
                TesteQuestoes testeQuestao = ConverterParaTesteQuestao(leitorQuestoesTeste);

                registro.AdicionarQuestao(testeQuestao);
            }

            conexaoComBanco.Close();
        }

        private TesteQuestoes ConverterParaTesteQuestao(SqlDataReader leitorQuestoesTeste)
        {
            var numero = Convert.ToInt32(leitorQuestoesTeste["NUMERO"]);
            var letra = Convert.ToString(leitorQuestoesTeste["LETRA"]);
            var pergunta = Convert.ToString(leitorQuestoesTeste["PERGUNTA"]);
            var gabarito = Convert.ToString(leitorQuestoesTeste["GABARITO"]);
            var bimestre = Convert.ToInt32(leitorQuestoesTeste["BIMESTRE"]);
            var testeNumero = Convert.ToInt32(leitorQuestoesTeste["TESTE_NUMERO"]);

            var testeQuestoes = new TesteQuestoes
            {
                Numero = numero,
                Letra = letra,
                Pergunta = pergunta,
                Gabarito = gabarito,
                Bimestre = (BimestreTesteEnum)bimestre,
                Teste = new Teste
                {
                    Numero = testeNumero
                }
            };
            return testeQuestoes;
        }

        public Teste SelecionarPorNumero(int numero)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorNumero, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("NUMERO", numero);

            conexaoComBanco.Open();
            SqlDataReader leitorTeste = comandoSelecao.ExecuteReader();

            Teste teste = null;
            if (leitorTeste.Read())
            {
                teste = ConverterParaTeste(leitorTeste);
            }

            conexaoComBanco.Close();

            CarregarQuestoes(teste);

            return teste;
        }

        public List<Teste> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open();
            SqlDataReader leitorTeste = comandoSelecao.ExecuteReader();

            List<Teste> testes = new List<Teste>();

            while (leitorTeste.Read())
            {
                Teste teste = ConverterParaTeste(leitorTeste);

                testes.Add(teste);
            }

            //fechar a conexão
            conexaoComBanco.Close();

            return testes;
        }

        private static Teste ConverterParaTeste(SqlDataReader leitorTeste)
        {
            int numero = Convert.ToInt32(leitorTeste["NUMERO"]);
            int numQuestoes = Convert.ToInt32(leitorTeste["NUMQUESTOES"]);
            DateTime dataCriacao = Convert.ToDateTime(leitorTeste["DATACRIACAO"]);
            int materiaNumero = Convert.ToInt32(leitorTeste["MATERIA_NUMERO"]);
            string nomeMateria = Convert.ToString(leitorTeste["NOMEMATERIA"]);

            var teste = new Teste
            {
                Numero = numero,
                NumQuestoes = numQuestoes,
                DataCriacao = dataCriacao,
                Materia = new Materia
                {
                    Numero = materiaNumero,
                    NomeMateria = nomeMateria
                }
            };
            return teste;
        }

        private static void ConfigurarParametrosTesteQuestao(TesteQuestoes item, SqlCommand comandoInsercao)
        {
            comandoInsercao.Parameters.AddWithValue("NUMERO", item.Numero);
            comandoInsercao.Parameters.AddWithValue("LETRA", item.Letra);
            comandoInsercao.Parameters.AddWithValue("PERGUNTA", item.Pergunta);
            comandoInsercao.Parameters.AddWithValue("GABARITO", item.Gabarito);
            comandoInsercao.Parameters.AddWithValue("BIMESTRE", item.Bimestre);
            //comandoInsercao.Parameters.AddWithValue("TESTE_NUMERO", item.Teste.Numero);
        }
        private static void ConfigurarParametrosTeste(Teste novoResgistro, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("NUMERO", novoResgistro.Numero);
            comando.Parameters.AddWithValue("NUMQUESTOES", novoResgistro.NumQuestoes);
            comando.Parameters.AddWithValue("DATACRIACAO", novoResgistro.DataCriacao);
            comando.Parameters.AddWithValue("MATERIA_NUMERO", novoResgistro.Materia.Numero);
            comando.Parameters.AddWithValue("NOMEMATERIA", novoResgistro.Materia.NomeMateria);
        }
    }
}
