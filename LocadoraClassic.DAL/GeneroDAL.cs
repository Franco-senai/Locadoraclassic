using LocadoraClassic.VO;
using MySql.Data.MySqlClient;

namespace LocadoraClassic.DAL
{
    public class GeneroDAL

    { 
        public void InserirGenero(Genero genero) 
        {
            //abrir a Conexão
            Conexao.Instance.Open();

            //MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            // DML - INSERT - DELETE - UPDATE - SELECT
            // STORED PROCEDURES
            // ADO.NET - bibliotecas de bando de dados do .NET
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO genero(nome)values(@nome)";
            comando.Parameters.Add(new MySqlParameter("@nome", genero.Nome));        
            comando.ExecuteNonQuery();
            Conexao.Instance.Close();
        }

    }

    // faz um CRUD ai

    //INSERT
    //DELETE
    //UPDATE
    //SELECT
}
