using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraClassic.VO;
using LocadoraClassic.DAL;
using static System.Net.Mime.MediaTypeNames;

namespace LocadoraClassic.View
{
    public partial class FrnTelaCliente : Form
    {   
        ClienteDAL clienteDAl1 = new ClienteDAL();
        public FrnTelaCliente()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDAL clienteDAL = new ClienteDAL();

            int RG = 0;
            long Telefone;
            RG = Convert.ToInt32(textRG.Text);
            string tele = maskedTextTelefone.Text;
            string teletratado = tele.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            Telefone = long.Parse(teletratado);
            cliente.Telefone = Telefone;
            cliente.NomeCliente = textNome.Text;
            cliente.Endereco = textEndereco.Text;
            cliente.CPF = maskedTextCPF.Text;
            cliente.RG= RG;
            clienteDAL.InserirCliente(cliente);

            textNome.Text = "";
            textEndereco.Text = "";
            maskedTextTelefone.Text = "";
            maskedTextCPF.Text = "";
            textRG.Text = "";

            CarregarGrid();

            MessageBox.Show("Dados do Cliente inseridos com sucesso!");
        }

        public void CarregarGrid()
        {

            gridCliente.DataSource = clienteDAl1.ObterCliente().ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ETAPA 1 - SELECIONAR O ID DA TABELA
            int id =  0;


            // Verifica se há alguma linha selecionada no DataGridView
            if (gridCliente.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = gridCliente.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                textNome.Text = nome;
                string endereço = selectedRow.Cells["Endereço"].Value.ToString();
                textEndereco.Text = endereço;
                string Telefone = selectedRow.Cells["Telefone"].Value.ToString();
                //long.Parse(Telefone);
                maskedTextTelefone.Text = Telefone;
                string CPF = selectedRow.Cells["CPF"].Value.ToString();
                maskedTextCPF.Text = CPF;
                string RG = selectedRow.Cells["RG"].Value.ToString();
                textRG.Text = RG;



                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo

            }

            //ETAPA 2 - ENVIAR O ID PARA DELETE

            ClienteDAL clienteDAL = new ClienteDAL();
            clienteDAL.ExcluirCliente(id);
            CarregarGrid();
        }
        private void gridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtém a linha em que ocorreu o duplo clique
                DataGridViewRow row = gridCliente.Rows[e.RowIndex];

                // Seleciona a linha inteira
                row.Selected = true;
            }

            if (gridCliente.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = gridCliente.SelectedRows[0];
                int id = 0;
                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nome = selectedRow.Cells["NomeCliente"].Value.ToString();
                textNome.Text = nome;
                string endereço = selectedRow.Cells["Endereco"].Value.ToString();
                textEndereco.Text = endereço;
                string Telefone = selectedRow.Cells["Telefone"].Value.ToString();
                //long.Parse(Telefone);
                maskedTextTelefone.Text = Telefone;
                string CPF = selectedRow.Cells["CPF"].Value.ToString();
                maskedTextCPF.Text = CPF;
                string RG = selectedRow.Cells["RG"].Value.ToString();
                textRG.Text = RG;



                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo

            }
        }
        private void FrnTelaCliente_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDAL clienteDAL = new ClienteDAL();

            int RG = 0;
            long Telefone;
            RG = Convert.ToInt32(textRG.Text);
            string tele = maskedTextTelefone.Text;
            string teletratado = tele.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            Telefone = long.Parse(teletratado);
            cliente.Telefone = Telefone;
            cliente.NomeCliente = textNome.Text;
            cliente.Endereco = textEndereco.Text;
            
            string CPFRecebido = maskedTextCPF.Text;
            string CPFTRATADO = CPFRecebido.Replace("_", "").Replace(".", "").Replace("-", "").Replace(",", ""); ;
            cliente.CPF = CPFTRATADO;
            cliente.RG = RG;
            clienteDAL.AtualizarCliente(cliente);

            textNome.Text = "";
            textEndereco.Text = "";
            maskedTextTelefone.Text = "";
            maskedTextCPF.Text = "";
            textRG.Text = "";

            CarregarGrid();
        }

        
    }
}
