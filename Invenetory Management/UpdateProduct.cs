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
    public partial class UpdateProduct : Form
    {
        SqlConnection connection = new SqlConnection(ConnectionQuery.connectionString);
        SqlCommand command;
        SqlDataReader reader;
        string searchQuery;
        string updateQuery;

        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void u_productIdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void u_searchButton_Click(object sender, EventArgs e)
        {
            searchQuery = $"select * from products where product_id={u_productIdTB.Text}";
            connection.Open();
            command= new SqlCommand(searchQuery, connection);
            reader = command.ExecuteReader();
            if (reader.Read() ) { 
                u_productNameTB.Text = reader["product_name"].ToString();
                u_categoryTB.Text = reader["category"].ToString();
                u_brandTB.Text = reader["brand"].ToString();
                u_unitpriceTB.Text = reader["unit_price"].ToString();
                u_stockQuantityTB.Text= reader["stock_quantity"].ToString();
                u_reorderLevelTB.Text = reader["reorder_Level"].ToString();
            }
            else {
                MessageBox.Show("Product Not found With This ID: " + u_productIdTB.Text);
            }
            connection.Close();
        }

        private void u_updateButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            updateQuery = $"update products set product_name ='{u_productNameTB.Text}', category ='{u_categoryTB.Text}',brand ='{u_brandTB.Text}', unit_price={u_unitpriceTB.Text}, stock_quantity={u_stockQuantityTB.Text}, reorder_level={u_reorderLevelTB.Text} where product_id ={u_productIdTB.Text}";
            command = new SqlCommand(updateQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
            //MessageBox.Show(updateQuery);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
