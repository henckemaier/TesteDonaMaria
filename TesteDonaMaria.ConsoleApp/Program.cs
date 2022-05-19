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
            Materia novaMateria = ObterMateria();

            //abrir conexao com o banco de dados
            string enderecoBanco = 
                "Data Source=(LocalDB)\\MSSqlLocalDB;"+
                "Initial Catalog=TesteDonaMariaDb;"+
                "Integrated Security=True;"+
                "Pooling=False";
            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoBanco;
            conexaoComBanco.Open();


            //criar comando de inserção
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

            comandoInsercao.CommandText = sql;

            //passar parametros para o comando inserção
            comandoInsercao.Parameters.AddWithValue("n", novaMateria.NomeMateria);
            comandoInsercao.Parameters.AddWithValue("d", novaMateria.Disciplina);
            comandoInsercao.Parameters.AddWithValue("s", novaMateria.Serie);


            //executar o comando
            comandoInsercao.ExecuteNonQuery();

            //fechar conexão
            conexaoComBanco.Close();
        }

        private static Materia ObterMateria()
        {
            return new Materia
            {
                NomeMateria = "Algebra",
                Disciplina = (MateriaDisciplinaEnum)0,
                Serie = (SerieMateriaEnum)1
            };
        }
    }
}
