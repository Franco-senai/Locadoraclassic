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

namespace LocadoraClassic.View
{
    public partial class FrnTelaGenero : Form
    {

        Genero genero = new Genero();
        int id = 0;
        GeneroDAL generoDAL = new GeneroDAL();
        public FrnTelaGenero()
        {
            InitializeComponent();
            CarregarGrid();
            dgvGeneros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGeneros.CellDoubleClick += dgvGeneros_CellDoubleClick;
        }

        private void FrmTelaGenero_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //objeto VO
            Genero genero = new Genero();
            //objeto DAL
            GeneroDAL generodal = new GeneroDAL();
            //Pegar o valor da caixinha e colocar na propriedade
            genero.Nome = textgenero.Text;


            //Inserir no bando de dados
            generodal.InserirGenero(genero);

            //LImpar caixa
            textgenero.Text = "";
            CarregarGrid();
           
            MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void FrnTelaGenero_Load(object sender, EventArgs e)
        {

            CarregarGrid();

        }

        private void textgenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void CarregarGrid()
        {

            dgvGeneros.DataSource = new GeneroDAL().ObterGeneros().ToList();

        }

        private void botaoexcluir_Click(object sender, EventArgs e)
        {
            //ETAPA 1 - SELECIONAR O ID DA TABELA
            int id = 0;
            // Verifica se há alguma linha selecionada no DataGridView
            if (dgvGeneros.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dgvGeneros.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                MessageBox.Show("O valor do campo 'id' é: " + id.ToString());
            }

            //ETAPA 2 - ENVIAR O ID PARA DELETE

            GeneroDAL generodal = new GeneroDAL();
            generodal.ExcluirGenero(id);
            CarregarGrid();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            genero.Nome = textgenero.Text;
            genero.ID = id;
            generoDAL.AtualizarGenero(genero);
            textgenero.Text = "";
            CarregarGrid();



        }

        private void dgvGeneros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém a linha em que ocorreu o duplo clique
                DataGridViewRow row = dgvGeneros.Rows[e.RowIndex];

                // Seleciona a linha inteira
                row.Selected = true;
            }

            //ETAPA 1 - SELECIONAR O ID DA TABELA

            // Verifica se há alguma linha selecionada no DataGridView
            if (dgvGeneros.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dgvGeneros.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                textgenero.Text = nome;
                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo



            }

        }
    }
}
