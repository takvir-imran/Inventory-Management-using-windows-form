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
    public partial class AddProduct : Form
    {
        private int pid;

        SqlConnection connection = new SqlConnection(ConnectionQuery.connectionString);

        public AddProduct()
        {
            InitializeComponent();
        }
        public AddProduct(int productID, List<string> category, List<string> brands)
        {
            pid = productID;
            InitializeComponent();
            productIdTB.Text = pid.ToString();
            foreach (string categoryItem in category)
            {
                categoryCB.Items.Add(categoryItem);
            }
            foreach(string brandItem in brands)
            {
                brandCB.Items.Add(brandItem);
            }
            categoryCB.SelectedIndex = 0;
            brandCB.SelectedIndex= 0;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO products (product_id, product_name, category, brand, unit_price, stock_quantity, reorder_level) VALUES ({pid}, '{productNameTB.Text}', '{categoryCB.Text}', '{brandCB.Text}', {unitPriceTB.Text}, {stockQuantityTB.Text}, {reorderLevelTB.Text});";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
    }
}
