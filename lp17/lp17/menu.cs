﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace lp17
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            equipamentos novaform = new equipamentos();
            novaform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            placas novaform = new placas();
            novaform.Show();
        }

        private void menu_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "ajuda.chm");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            REPORTS novaform = new REPORTS();
            novaform.Show();
        }
    }
}
