using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invenetory_Management
{
    public partial class DeleteProduct : Form
    {
        SqlConnection connection = new SqlConnection(ConnectionQuery.connectionString);
        SqlCommand command;
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {

        }

        private void d_deleteButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM products WHERE product_Id='{d_productIdTB.Text}';", connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
    }
}
