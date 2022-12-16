using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Agency
{
    public partial class Peugeo : Form
    {
        public Peugeo()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            peugeot3008 peugeot3008 = new peugeot3008();
            peugeot3008.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            peugeot508 peugeot508 = new peugeot508();
            peugeot508.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            peugeot2008 peugeot2008 = new peugeot2008();
            peugeot2008.ShowDialog();
        }
    }
}
