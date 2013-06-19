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
    public partial class inserir_placa : Form
    {
        public inserir_placa()
        {
            InitializeComponent();
        }

        private void placa_de_redeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.placa_de_redeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void inserir_placa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Placa_de_rede' table. You can move, or remove it, as needed.
            this.placa_de_redeTableAdapter.Fill(this.database1DataSet.Placa_de_rede);

        }
    }
}
