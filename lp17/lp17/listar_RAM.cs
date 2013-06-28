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
    public partial class listar_RAM : Form
    {
        public listar_RAM()
        {
            InitializeComponent();
        }

        private void listar_RAM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Equipamentos1' table. You can move, or remove it, as needed.
            this.equipamentos1TableAdapter.Fill(this.database1DataSet.Equipamentos1);

        }
    }
}
