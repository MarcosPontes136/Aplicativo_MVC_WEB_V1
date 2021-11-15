using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aplicativoMVC.controle;

namespace aplicativoMVC.modelo.dal
{
    public class SqlServerDao : PessoaDao
    {
        private static SqlConnection con;

        // Construtor
        public SqlServerDao()
        {
            // Se não existe uma conexão aberta, cria uma.
            if (con == null)
            {
                try
                {
                    // Objeto que auxilia a configurar uma conexão com BD.
                    SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
                    cs.DataSource = "Localhost";
                    cs.InitialCatalog = "Agenda";
                    cs.Authentication = SqlAuthenticationMethod.ActiveDirectoryIntegrated;
                    cs.TrustServerCertificate = true;

                    // Instancia e abre a conexão.
                    con = new SqlConnection(cs.ConnectionString);
                    con.Open();
                }
                catch (SqlException e)
                {
                    Console.Error.WriteLine("Ocorreu uma exceção de BD: " + e.Message);
                    throw new ApplicationException("Ocorreu uma exceção de BD: " + e.Message);
                }
            }


        }
        void PessoaDao.Altere(Pessoa p)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Agenda SET Nome = " + p.nome + "WHERE CPF = '"
                + p.CPF + "';";
        }
        List<Pessoa> PessoaDao.Consulte()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT CPF, Nome FROM Agenda;";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.CPF = reader.GetInt64(0);
                pessoa.nome = reader.GetString(1);
                pessoas.Add(pessoa);
            }
            reader.Close();

            return pessoas;

        }
        List<Pessoa> PessoaDao.Consulte(long CPF)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT CPF, Nome FROM Agenda WHERE CPF = '"
                + CPF + "';";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.CPF = reader.GetInt64(0);
                pessoa.nome = reader.GetString(1);
                pessoas.Add(pessoa);
            }
            reader.Close();

            return pessoas;
        }
        void PessoaDao.Exclua(Pessoa p)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM Agenda WHERE Nome = '" + p.nome
                + "' AND CPF = " + p.CPF + ";";
            cmd.ExecuteNonQuery();
        }
        void PessoaDao.Insira(Pessoa p)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Agenda (Nome, CPF)" +
                " VALUES ('" + p.nome + "', " + p.CPF + ");";
            cmd.ExecuteNonQuery();
        }
    }
}
