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
    public partial class report3 : Form
    {
        public report3()
        {
            InitializeComponent();
        }

        private void report3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Equipamentos' table. You can move, or remove it, as needed.
            this.EquipamentosTableAdapter.Fill(this.Database1DataSet.Equipamentos);

            this.reportViewer1.RefreshReport();
        }
    }
}
