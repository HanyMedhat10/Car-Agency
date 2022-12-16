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
    public partial class peugeot2008 : Form
    {
        public peugeot2008()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CallUs callUs = new CallUs();
            callUs.Show();
        }
    }
}
