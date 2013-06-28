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
    public partial class pesquisar_placa : Form
    {
        public pesquisar_placa()
        {
            InitializeComponent();
        }

        private void fillpesqEndereçoIPToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.FillpesqEndereçoIP(this.database1DataSet.DataTable1, endereço_IPToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

        
    }
}
