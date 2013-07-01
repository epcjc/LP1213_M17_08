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
    public partial class listar_garantia : Form
    {
        public listar_garantia()
        {
            InitializeComponent();
        }

        private void equipamentos2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipamentos2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void listar_garantia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Equipamentos2' table. You can move, or remove it, as needed.
            this.equipamentos2TableAdapter.Fill(this.database1DataSet.Equipamentos2);

        }
    }
}
