using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Invenetory_Management
{
    public partial class Suppliers : Form
    {
        string defaultQuery = "select * from suppliers";
        public Suppliers()
        {
            InitializeComponent();
            showData(defaultQuery);
        }

        public void showData(string query)
        {
            using(SqlConnection connection = new SqlConnection(ConnectionQuery.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable= new DataTable();
                adapter.Fill(dataTable);
                supplierDataGrid.DataSource = dataTable;
            }
        }
    }
}
