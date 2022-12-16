using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Agency
{
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7PO0HDQ;Initial Catalog=Cars_Agency;Integrated Security=True");
        SqlCommand cmd;
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            string address = this.textBox3.Text;
            string phone = this.textBox4.Text;
            if (username=="" || password == "" || address=="" || phone=="")
            {
                MessageBox.Show("Please Enter User Name , Password , Address and Phone ");
            }
            else
            {
                cmd= new SqlCommand("insert into Customer (Name,Password,address,Phone)values ('"+username+"','"+password+"','"+address+"','"+phone+"');",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Passed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
        }
    }
}
