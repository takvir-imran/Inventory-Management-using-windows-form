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
using Microsoft.Data.Sql;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections;

namespace Invenetory_Management
{
    public partial class MainScreenForm : Form
    {
        List<string> category = new List<string>();
        List<string> brands = new List<string>();
        List <int> prodList = new List<int>();
        SqlConnection connection = new SqlConnection(ConnectionQuery.connectionString);
        SqlDataAdapter? adapter;
        DataTable? dt;

        private string username;
        string defaultQuery = "select * from products";
        private Form refToLoginForm;

        Excel.Application xlapp = new Excel.Application();

        public Form RefToLoginForm { get => refToLoginForm; set => refToLoginForm = value; }

        public MainScreenForm()
        {
            InitializeComponent();
            ShowData(defaultQuery);
        }
        public MainScreenForm(string username)
        {
            this.username = username;
            InitializeComponent();
            ShowData(defaultQuery);
            logInfoLabel.Text = $"User: {this.username}, Logged at: {DateTime.Now.TimeOfDay}";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void ShowData(string query)
        {
            
            adapter = new SqlDataAdapter(query, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows= false;

            foreach(DataGridViewRow x in dataGridView1.Rows)
            {
                int value = Convert.ToInt32(x.Cells[5].Value);
                if (value <= 10)
                {
                    x.Cells[5].Style.BackColor = Color.IndianRed;
                }
                if(value>10 && value < 20)
                {
                    x.Cells[5].Style.BackColor = Color.YellowGreen;
                }
            }
            foreach (DataRow row in dt.Rows)
            {
                category.Add(row[2].ToString());
                brands.Add(row[3].ToString());
                prodList.Add(Convert.ToInt32(row[0].ToString()));
            }
            category = category.Distinct().ToList();
            brands= brands.Distinct().ToList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ShowData($"select * from products where product_name like '%{searchTextBox.Text}%' or brand like '%{searchTextBox.Text}%'");
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            ShowData(defaultQuery);
            AddProduct ap = new AddProduct(prodList.Max()+1, category, brands);
            ap.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowData(defaultQuery);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateProduct up = new UpdateProduct();
            up.ShowDialog();
        }

        private void MainScreenForm_Load_1(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteProduct dp = new DeleteProduct();
            dp.ShowDialog();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowData(defaultQuery);
            AddProduct ap = new AddProduct(prodList.Max() + 1, category, brands);
            ap.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProduct up = new UpdateProduct();
            up.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProduct dp = new DeleteProduct();
            dp.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.isLoggedIn = false;
            refToLoginForm.Show();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            Cart cart= new Cart();
            cart.ShowDialog();
        }

        private void sellProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.ShowDialog();
        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void generateSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales sales= new Sales();
            sales.ShowDialog();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.ShowDialog();
        }

        private void suppliersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
