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
        public FrnTelaGenero()
        {
            InitializeComponent();
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
            MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void FrnTelaGenero_Load(object sender, EventArgs e)
        {
            
            

        }

        private void textgenero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
