using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Agency
{
    public partial class CallUs : Form
    {
     SqlConnection  con = new SqlConnection("Data Source=DESKTOP-7PO0HDQ;Initial Catalog=Cars_Agency;Integrated Security=True");
     SqlDataAdapter dataAdapter;
     DataTable DataTabledt = new DataTable();
        public CallUs()
        {
            InitializeComponent();
            dataAdapter = new SqlDataAdapter("Select Name , phone from Employee", con);
            dataAdapter.Fill(DataTabledt);
            dataGridView1.DataSource = DataTabledt;
        }
    }
}
