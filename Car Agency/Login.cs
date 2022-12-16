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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7PO0HDQ;Initial Catalog=Cars_Agency;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        DataTable DataTabledt = new DataTable();
        



        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            if (username == "admin" && pass == "admin")
            {
                Main main = new Main();
                main.Show();
            }
            else if (username == "" || pass == "")
            {
                MessageBox.Show("Please Enter User Name and Password ");
            }
            else
            {
                try
                {
                    string Query = "select * from Customer\r\nwhere Password = '"+pass+"'and Name= '"+username+"';";
                    dataAdapter = new SqlDataAdapter(Query,con);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    if (dt.Rows.Count >0)
                    {
                        Brand brand = new Brand();
                        brand.Show();
                        
                        

                    }
                    else { MessageBox.Show("Invalid Login"); }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Login","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }
        }
    }
}