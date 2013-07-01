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
    public partial class report2 : Form
    {
        public report2()
        {
            InitializeComponent();
        }

        private void report2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Equipamentos1' table. You can move, or remove it, as needed.
            this.Equipamentos1TableAdapter.Fill(this.Database1DataSet.Equipamentos1);

            this.reportViewer1.RefreshReport();
        }
    }
}
