using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TesteDonaMaria.Dominio.ModuloMateria;

namespace TesteDonaMaria.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Materia> materias = SelecionarTodasMaterias();

            foreach (var item in materias)
            {
                Console.WriteLine(item);
            }

            int numero = materias[0].Numero;

            Materia materiaEncontrada = SelecionarMateriaPorNumero(numero);

            var materia = ObterMateria("Alguma matéria ai");

            InserirMateria(materia);

            materia.NomeMateria = "Materia de alguma coisa novamente";

            EditarMateria(materia);

            ExcluirMateria(materia.Numero);
        }

        private static List<Materia> SelecionarTodasMaterias()
        {
            #region abrir a conexão com o banco de dados
            string enderecoBanco =
                "Data Source=(LocalDB)\\MSSqlLocalDB;" +
                "Initial Catalog=eAgendaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoBanco;
            conexaoComBanco.Open();
            #endregion

            #region  criar um comando 
            SqlCommand comandoSelecao = new SqlCommand();
            comandoSelecao.Connection = conexaoComBanco;
            string sql = @"INSERT INTO[TBMATERIA]
                            (
                                [NOMEMATERIA], 
		                        [DISCIPLINA],
		                        [SERIE]
	                        )
	                        VALUES
                            (
                                @n,
                                @d,
                                @s
                            )";

            comandoSelecao.CommandText = sql;

            #endregion

            //executar o comando
            SqlDataReader leitorMateria = comandoSelecao.ExecuteReader();

            List<Materia> materias = new List<Materia>();

            while (leitorMateria.Read())
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

                materias.Add(materia);
            }

            //fechar a conexão
            conexaoComBanco.Close();

            return materias;
        }

        private static Materia SelecionarMateriaPorNumero(int numeroPesquisado)
        {
            #region abrir a conexão com o banco de dados
            string enderecoBanco =
                "Data Source=(LocalDB)\\MSSqlLocalDB;" +
                "Initial Catalog=eAgendaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoBanco;
            conexaoComBanco.Open();
            #endregion

            #region  criar um comando 
            SqlCommand comandoSelecao = new SqlCommand();
            comandoSelecao.Connection = conexaoComBanco;
            string sql = @"INSERT INTO[TBMATERIA]
                            (
                                [NOMEMATERIA], 
		                        [DISCIPLINA],
		                        [SERIE]
	                        )
	                        VALUES
                            (
                                @n,
                                @d,
                                @s
                            )";

            comandoSelecao.CommandText = sql;

            #endregion

            comandoSelecao.Parameters.AddWithValue("NUMERO", numeroPesquisado);

            //executar o comando
            SqlDataReader leitorMateria = comandoSelecao.ExecuteReader();

            Materia materia = null;
            if (leitorMateria.Read())
            {
                int numero = Convert.ToInt32(leitorMateria["NUMERO"]);
                string nomeMateria = Convert.ToString(leitorMateria["NOMEMATERIA"]);
                int disciplina = Convert.ToInt32(leitorMateria["DISCIPLINA"]);
                int serie = Convert.ToInt32(leitorMateria["SERIE"]);


                materia = new Materia
                {
                    Numero = numero,
                    NomeMateria = nomeMateria,
                    Disciplina = (MateriaDisciplinaEnum)disciplina,
                    Serie = (SerieMateriaEnum)serie
                };
            }

            //fechar a conexão
            conexaoComBanco.Close();

            return materia;
        }

        private static void InserirMateria(Materia novaMateria)
        {
            #region abrir a conexão com o banco de dados
            string enderecoBanco =
                "Data Source=(LocalDB)\\MSSqlLocalDB;" +
                "Initial Catalog=eAgendaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoBanco;
            conexaoComBanco.Open();
            #endregion

            #region  criar um comando de inserção
            SqlCommand comandoInsercao = new SqlCommand();
            comandoInsercao.Connection = conexaoComBanco;
            string sql = @"INSERT INTO[TBMATERIA]
                            (
                                [NOMEMATERIA], 
		                        [DISCIPLINA],
		                        [SERIE]
	                        )
	                        VALUES
                            (
                                @n,
                                @d,
                                @s
                            )";

            sql += "SELECT SCOPE_IDENTITY();";

            comandoInsercao.CommandText = sql;

            #endregion

            #region passar os parâmetros para o comando de inserção
            comandoInsercao.Parameters.AddWithValue("n", novaMateria.NomeMateria);
            comandoInsercao.Parameters.AddWithValue("d", novaMateria.Disciplina);
            comandoInsercao.Parameters.AddWithValue("s", novaMateria.Serie);
            #endregion

            //executar o comando
            var id = comandoInsercao.ExecuteScalar();

            novaMateria.Numero = Convert.ToInt32(id);

            //fechar a conexão
            conexaoComBanco.Close();
        }

        private static void EditarMateria(Materia materia)
        {
            #region abrir a conexão com o banco de dados
            string enderecoBanco =
                "Data Source=(LocalDB)\\MSSqlLocalDB;" +
                "Initial Catalog=eAgendaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoBanco;
            conexaoComBanco.Open();
            #endregion

            #region  criar um comando de edição
            SqlCommand comandoEdicao = new SqlCommand();
            comandoEdicao.Connection = conexaoComBanco;
            string sql = @"INSERT INTO[TBMATERIA]
                            (
                                [NOMEMATERIA], 
		                        [DISCIPLINA],
		                        [SERIE]
	                        )
	                        VALUES
                            (
                                @n,
                                @d,
                                @s
                            )";

            comandoEdicao.CommandText = sql;

            #endregion

            #region passar os parâmetros para o comando de inserção
            comandoEdicao.Parameters.AddWithValue("n", materia.NomeMateria);
            comandoEdicao.Parameters.AddWithValue("d", materia.Disciplina);
            comandoEdicao.Parameters.AddWithValue("s", materia.Serie);
            #endregion

            //executar o comando
            comandoEdicao.ExecuteNonQuery();

            //fechar a conexão
            conexaoComBanco.Close();
        }

        private static void ExcluirMateria(int numero)
        {
            #region abrir a conexão com o banco de dados
            string enderecoBanco =
                "Data Source=(LocalDB)\\MSSqlLocalDB;" +
                "Initial Catalog=eAgendaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoBanco;
            conexaoComBanco.Open();
            #endregion

            #region  criar um comando de edição
            SqlCommand comandoExclusao = new SqlCommand();
            comandoExclusao.Connection = conexaoComBanco;
            string sql = @"	DELETE FROM [TBMATERIA]
		                        WHERE
			                        [NUMERO] = @NUMERO";

            comandoExclusao.CommandText = sql;

            #endregion

            #region passar os parâmetros para o comando de inserção
            comandoExclusao.Parameters.AddWithValue("NUMERO", numero);
            #endregion

            //executar o comando
            comandoExclusao.ExecuteNonQuery();

            //fechar a conexão
            conexaoComBanco.Close();
        }

        private static Materia ObterMateria(string nomeMateria)
        {
            return new Materia
            {
                NomeMateria = nomeMateria,
                Disciplina = (MateriaDisciplinaEnum)0,
                Serie = (SerieMateriaEnum)1
            };
        }
    }
}
