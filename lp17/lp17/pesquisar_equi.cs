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
    public partial class pesquisar_equi : Form
    {
        public pesquisar_equi()
        {
            InitializeComponent();
        }

        private void equipamentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipamentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void pesquisar_equi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Equipamentos' table. You can move, or remove it, as needed.
            this.equipamentosTableAdapter.Fill(this.database1DataSet.Equipamentos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.equipamentosTableAdapter.FillBypesqSistema(this.database1DataSet.Equipamentos, textBox1.Text);
        }
    }
}
