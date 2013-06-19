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
    public partial class Le_1 : Form
    {
        public Le_1()
        {
            InitializeComponent();
        }

        private void Le_1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Equipamentos' table. You can move, or remove it, as needed.
            this.EquipamentosTableAdapter.Fill(this.database1DataSet.Equipamentos);

            this.reportViewer1.RefreshReport();
        }
    }
}
