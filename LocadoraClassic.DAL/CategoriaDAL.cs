using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraClassic.VO;
using MySql.Data.MySqlClient;

namespace LocadoraClassic.DAL
{
    public class CategoriaDAL
    {

       
        public void InserirCategoria(Categoria categoria)
        {
            //abrir a Conexão
            Conexao.Instance.Open();

            //MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            // DML - INSERT - DELETE - UPDATE - SELECT
            // STORED PROCEDURES
            // ADO.NET - bibliotecas de bando de dados do .NET
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO categoria(nome,Diaria)values(@nome,@Diaria)";
            

            comando.Parameters.Add(new MySqlParameter("@nome", categoria.Nome));
            comando.Parameters.Add(new MySqlParameter("@Diaria", categoria.Diaria));
            comando.ExecuteNonQuery();
            Conexao.Instance.Close();
        }

        public List<Categoria> ObterCategorias()
        {
            //Abrir a Conexão
            Conexao.Instance.Open();
            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM categoria";
            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();
            List<Categoria> categorias = new List<Categoria>();

            while (reader.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Id = Convert.ToInt32(reader["id"]);
                categoria.Nome = reader["nome"].ToString();
                categoria.Diaria = Convert.ToInt64(reader["diaria"]);
                categorias.Add(categoria);
            }
            // Fechar a conexão e retornar os gêneros obtidos
            reader.Close();
            Conexao.Instance.Close();
            return categorias;
        }

        public void ExcluirCategoria(int id)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM categoria WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            // Fechar a conexão
            Conexao.Instance.Close();
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "UPDATE categoria SET nome = @nome,Diaria = @Diaria WHERE id = @id";
            
            
            comando.Parameters.AddWithValue("@nome", categoria.Nome);
            comando.Parameters.AddWithValue("@id", categoria.Id);
            comando.Parameters.AddWithValue("@Diaria", categoria.Diaria);
            comando.ExecuteNonQuery();

            // Fechar a conexão
            Conexao.Instance.Close();
        }




    }
}
