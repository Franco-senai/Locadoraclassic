using LocadoraClassic.VO;
using LocadoraClassic.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraClassic.View
{
    public partial class FrnCategoria : Form
    {   
        
        CategoriaDAL categoriaDAL1 = new CategoriaDAL();
        int id = 0;
        double valordiaria = 0;
        double Diaria;
        string nome;

        Categoria categoria = new Categoria();
        public FrnCategoria()
        {
            InitializeComponent();
            CarregarGrid();

            dvgCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgCategoria.CellDoubleClick += dvgCategoria_CellDoubleClick;
        }

        private void FrnCategoria_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           Categoria categoria = new Categoria();
           CategoriaDAL categoriaDAL = new CategoriaDAL();



            Diaria = double.Parse(textDiaria.Text);
            categoria.Nome = textcategoria.Text;
            categoria.Diaria = Diaria;
            categoriaDAL.InserirCategoria(categoria);
            
            textcategoria.Text = "";
            textDiaria.Text = "";
            CarregarGrid();

            MessageBox.Show("Dados inseridos com sucesso!");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void CarregarGrid()
        {

            dvgCategoria.DataSource = categoriaDAL1.ObterCategorias().ToList();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = 0;
            // Verifica se há alguma linha selecionada no DataGridView
            if (dvgCategoria.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dvgCategoria.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                MessageBox.Show("O valor do campo 'id' é: " + id.ToString());
            }

            //ETAPA 2 - ENVIAR O ID PARA DELETE

            CategoriaDAL categoriaDal = new CategoriaDAL();
            categoriaDal.ExcluirCategoria(id);
            CarregarGrid();
        }

        private void dvgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém a linha em que ocorreu o duplo clique
                DataGridViewRow row = dvgCategoria.Rows[e.RowIndex];

                // Seleciona a linha inteira
                row.Selected = true;
            }

            if (dvgCategoria.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dvgCategoria.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                textcategoria.Text = nome;
     
                string diaria = selectedRow.Cells["Diaria"].Value.ToString();
                double diaria2 = 0;
                diaria2 = Convert.ToDouble(diaria);

                textDiaria.Text = diaria;

                Categoria categoria = new Categoria();
                categoria.Id = id;
                categoria.Diaria =diaria2;
                categoria.Nome  = nome;
                //categoriaDAL1 = new CategoriaDAL();
               // categoriaDAL1.AtualizarCategoria(categoria);
                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Categoria categoria = new Categoria();
            categoria.Id = id;
            categoria.Nome = textcategoria.Text;
            
            categoria.Diaria = Convert.ToDouble(textDiaria.Text);

            CategoriaDAL categoriaDAL = new CategoriaDAL();
            categoriaDAL.AtualizarCategoria(categoria);
            textcategoria.Text = "";
            textDiaria.Text = "";
            CarregarGrid(); 
        }
    }
}
