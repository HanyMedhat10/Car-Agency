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
    public partial class BMW : Form
    {
        public BMW()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            BMWX6 bMWX6 = new BMWX6();
            bMWX6.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            BMWX7 bMWX7 = new BMWX7();  
            bMWX7.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            BMW_M3 bMW_M3 = new BMW_M3();
            bMW_M3.Show();
        }
    }
}
