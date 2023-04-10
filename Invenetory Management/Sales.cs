using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invenetory_Management
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(ConnectionQuery.connectionString)) {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from sales", connection);
                DataTable dataTable= new DataTable();
                adapter.Fill(dataTable);
                salesDataGrid.DataSource = dataTable;    
                salesDataGrid.AllowUserToAddRows= false;
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }
    }
}
