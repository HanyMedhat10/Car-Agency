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
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            BMW bMW = new BMW();
            bMW.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Mini mini = new Mini();
            mini.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Peugeo peugeo = new Peugeo();
            peugeo.Show(); 
        }
    }
}
