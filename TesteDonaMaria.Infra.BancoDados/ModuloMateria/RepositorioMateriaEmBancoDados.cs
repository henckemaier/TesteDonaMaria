using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDonaMaria.Dominio.ModuloMateria;

namespace TesteDonaMaria.Infra.BancoDados.ModuloMateria
{
    public class RepositorioMateriaEmBancoDados : IRepositorioMateria
    {
        private const string enderecoBanco =
                "Data Source=(LocalDB)\\MSSqlLocalDB;" +
                "Initial Catalog=TesteDonaMariaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";

        #region Sql Queries
        private const string sqlInserir =
            @"INSERT INTO[TBMATERIA]
            (
                [NOMEMATERIA], 
		        [DISCIPLINA],
		        [SERIE]
	        )
	        VALUES
            (
                @NOMEMATERIA,
                @DISCIPLIA,
                @SERIE
            );SELECT SCOPE_IDENTITY();";

        private const string sqlEditar = 
            @"UPDATE [TBMATERIA]
            SET
                [NOMEMATERIA] = @NOMEMATERIA, 
		        [DISCIPLINA] = @DISCIPLINA,
		        [SERIE] = @SERIE
	        WHERE
                [NUMERO] = @NUMERO";

        private const string sqlExcluir =
            @"DELETE FROM [TBMATERIA]
		    WHERE
			    [NUMERO] = @NUMERO";

        private const string sqlSelecionarTodos =
            @"SELECT
                [NUMERO],
                [NOMEMATERIA], 
		        [DISCIPLINA],
		        [SERIE]
            FROM
                [TBMATERIA]";

        private const string sqlSelecionarPorNumero =
            @"SELECT
                [NUMERO],
                [NOMEMATERIA], 
		        [DISCIPLINA],
		        [SERIE]
            FROM
                [TBMATERIA]
            WHERE
                [NUMERO] = @NUMERO";
        #endregion

        public ValidationResult Inserir(Materia novaMateria)
        {
            var validador = new ValidadorMateria();

            var resultadoValidacao = validador.Validate(novaMateria);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            
            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfigurarParametrosMateria(novaMateria, comandoInsercao);

            conexaoComBanco.Open();
            var id = comandoInsercao.ExecuteScalar();
            novaMateria.Numero = Convert.ToInt32(id);

            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public ValidationResult Editar(Materia materia)
        {
            var validador = new ValidadorMateria();

            var resultadoValidacao = validador.Validate(materia);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            ConfigurarParametrosMateria(materia, comandoEdicao);

            conexaoComBanco.Open();
            comandoEdicao.ExecuteNonQuery();
            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public ValidationResult Excluir(Materia materia)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("NUMERO", materia.Numero);

            conexaoComBanco.Open();
            int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

            var resultadoValidacao = new ValidationResult();

            if (numeroRegistrosExcluidos == 0)
                resultadoValidacao.Errors.Add(new ValidationFailure("", "Não foi possível remover o registro"));

            conexaoComBanco.Close();
            return resultadoValidacao;
        }

        public List<Materia> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open();
            SqlDataReader leitorMateria = comandoSelecao.ExecuteReader();

            List<Materia> materias = new List<Materia>();

            while (leitorMateria.Read())
            {
                Materia materia = ConverterParaMateria(leitorMateria);

                materias.Add(materia);
            }

            //fechar a conexão
            conexaoComBanco.Close();

            return materias;
        }

        public Materia SelecionarPorNumero(int numero)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorNumero, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("NUMERO", numero);

            conexaoComBanco.Open();
            SqlDataReader leitorMateria = comandoSelecao.ExecuteReader();

            Materia materia = null;
            if (leitorMateria.Read())
            {
                materia = ConverterParaMateria(leitorMateria);
            }

            conexaoComBanco.Close();

            return materia;
        }

        private static Materia ConverterParaMateria(SqlDataReader leitorMateria)
        {
            int numero = Convert.ToInt32(leitorMateria["NUMERO"]);
            string nomeMateria = Convert.ToString(leitorMateria["NOMEMATERIA"]);
            int disciplina = Convert.ToInt32(leitorMateria["DISCIPLINA"]);
            int serie = Convert.ToInt32(leitorMateria["SERIE"]);

            var materia = new Materia
            {
                Numero = numero,
                NomeMateria = nomeMateria,
                Disciplina = (MateriaDisciplinaEnum)disciplina,
                Serie = (SerieMateriaEnum)serie
            };
            return materia;
        }

        private static void ConfigurarParametrosMateria(Materia novaMateria, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("NUMERO", novaMateria.Numero);
            comando.Parameters.AddWithValue("NOMEMATERIA", novaMateria.NomeMateria);
            comando.Parameters.AddWithValue("DISCIPLIA", novaMateria.Disciplina);
            comando.Parameters.AddWithValue("SERIE", novaMateria.Serie);
        }
    }
}
