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
        public FrnCategoria()
        {
            InitializeComponent();
        }

        private void FrnCategoria_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrnTelaFilme frnTelaFilme = new FrnTelaFilme();
            frnTelaFilme.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
