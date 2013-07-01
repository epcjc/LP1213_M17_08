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
    public partial class report1 : Form
    {
        public report1()
        {
            InitializeComponent();
        }

        private void report1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Placa_de_rede' table. You can move, or remove it, as needed.
            this.Placa_de_redeTableAdapter.Fill(this.Database1DataSet.Placa_de_rede);

            this.reportViewer1.RefreshReport();
        }
    }
}
