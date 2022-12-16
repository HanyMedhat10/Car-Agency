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
    public partial class Mini : Form
    {
        public Mini()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MiniHatch miniHatch = new MiniHatch();
            miniHatch.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ClubMan clubMan = new ClubMan();
            clubMan.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Countryman countryman = new Countryman();
            countryman.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
