using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lp17
{
    public partial class equipamentos : Form
    {
        public equipamentos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inserir_equi novaform = new inserir_equi();
            novaform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listar_equi novaform = new listar_equi();
            novaform.Show();

        }
    }
}
