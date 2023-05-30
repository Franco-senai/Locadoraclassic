using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraClassic.VO;
using MySql.Data.MySqlClient;

namespace LocadoraClassic.DAL
{
    public class ClienteDAL

    {

        public void InserirCliente(Cliente cliente)

        {
            //abrir a Conexão
            Conexao.Instance.Open();

            //MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            // DML - INSERT - DELETE - UPDATE - SELECT
            // STORED PROCEDURES
            // ADO.NET - bibliotecas de bando de dados do .NET
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO cliente(nome,endereço,Telefone,CPF,RG)values(@nome,@endereço,@telefone,@cpf,@rg)";
            
            comando.Parameters.Add(new MySqlParameter("@id", cliente.ID));
            comando.Parameters.Add(new MySqlParameter("@nome",cliente.NomeCliente));
            comando.Parameters.Add(new MySqlParameter("@endereço",cliente.Endereco));
            comando.Parameters.Add(new MySqlParameter("@Telefone",cliente.Telefone));
            comando.Parameters.Add(new MySqlParameter("@CPF",cliente.CPF));
            comando.Parameters.Add(new MySqlParameter("@RG",cliente.RG));

            comando.ExecuteNonQuery();
            Conexao.Instance.Close();


        }

        public List<Cliente> ObterCliente()

        {

            //Abrir a Conexão
            Conexao.Instance.Open();
            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM cliente";
            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();

            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.ID = Convert.ToInt32(reader["id"]);
                cliente.NomeCliente = reader["nome"].ToString();
                cliente.Endereco = (reader["Endereço"].ToString());
                cliente.Telefone = long.Parse(reader["Telefone"].ToString());
                cliente.CPF = (reader["CPF"].ToString());
                cliente.RG = Convert.ToInt32(reader["RG"]);
                clientes.Add(cliente);

            }
            // Fechar a conexão e retornar os gêneros obtidos
            reader.Close();
            Conexao.Instance.Close();
            return clientes;


        }


        public void ExcluirCliente(int id)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM cliente WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            // Fechar a conexão
            Conexao.Instance.Close();
        }

        public void AtualizarCliente(Cliente cliente)

        {

            Conexao.Instance.Open();
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "UPDATE cliente SET nome=@nome, endereço=@endereço, Telefone =@Telefone,CPF =@CPF, RG =@RG WHERE id=@id"; 
                                  
            comando.Parameters.AddWithValue("@id",cliente.ID);
            comando.Parameters.AddWithValue("@nome",cliente.NomeCliente);
            comando.Parameters.AddWithValue("@endereço",cliente.Endereco);
            comando.Parameters.AddWithValue("@Telefone",cliente.Telefone);
            comando.Parameters.AddWithValue("@CPF",cliente.CPF);
            comando.Parameters.AddWithValue("@RG",cliente.RG);
            comando.ExecuteNonQuery();

            Conexao.Instance.Close();
        }
    }

}