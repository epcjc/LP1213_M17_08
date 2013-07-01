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
    public partial class REPORTS : Form
    {
        public REPORTS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            report1 novaform = new report1();
            novaform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            report2 novaform = new report2();
            novaform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report3 novaform = new report3();
            novaform.Show();
        }
    }
}
