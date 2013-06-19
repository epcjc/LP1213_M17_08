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
    public partial class inserir_equi : Form
    {
        public inserir_equi()
        {
            InitializeComponent();
        }

        private void equipamentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipamentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void inserir_equi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Equipamentos' table. You can move, or remove it, as needed.
            this.equipamentosTableAdapter.Fill(this.database1DataSet.Equipamentos);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
