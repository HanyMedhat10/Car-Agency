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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarTable carTable = new CarTable();
            carTable.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeTable employeeTable = new EmployeeTable();
            employeeTable.Show();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandTable brandTable = new BrandTable();
            brandTable.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerTable customerTable = new CustomerTable();
            customerTable.Show();
        }

        private void theBestSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            The_Seller the_Seller = new The_Seller();
            the_Seller.Show();
        }
    }
}
