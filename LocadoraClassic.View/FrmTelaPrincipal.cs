﻿using System;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void faturamentoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void faturamenteDoMêsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void genêroToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            // chamndo a tela Genero na tela Principal
            FrnTelaGenero frnTelaGenero = new FrnTelaGenero();
            //frnTelaGenero.MdiParent = this;
            frnTelaGenero.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FrnTelaCliente frnTelaCliente = new FrnTelaCliente();
            //frnTelaCliente.MdiParent = this;
            frnTelaCliente.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrnCategoria frnCategoria = new FrnCategoria();
            //frnCategoria.MdiParent = this;
            frnCategoria.Show();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrnTelaFilme frnTelaFilme = new FrnTelaFilme();
            //frnTelaFilme.MdiParent = this;
            frnTelaFilme.Show();
        }

        private void realizarLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrnLocacao().Show();
            
        }
    }
}
