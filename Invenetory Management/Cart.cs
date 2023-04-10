using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System.ComponentModel;


namespace Invenetory_Management
{
    public partial class Cart : Form
    {
        SqlCommand command;
        SqlDataReader productReader;
        BindingList<Product> productlist = new BindingList<Product>();
        

        private int id;
        private string productName;
        private string brandName;
        private double unitPrice;
        private double quantity;
        private double stockQuantity;

        private double cartValue = 0.0;
        private double variableMaximumQuantity;

        public Cart()
        {
            InitializeComponent();
            cartProcutGrid.DataSource = productlist;
            updateCartValue();
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionQuery.connectionString))
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand($"select * from products where product_id = {Convert.ToInt32(cart_productIDTB.Text)}", connection);
                    productReader = command.ExecuteReader();
                    while (productReader.Read())
                    {
                        if (productReader["product_id"].ToString() == cart_productIDTB.Text)
                        {
                            if (checkSimilarity(Convert.ToDouble(cart_productIDTB.Text)))
                            {
                                for(int i=0; i< productlist.Count; i++)
                                {
                                    if (String.IsNullOrEmpty(cart_quantityTB.Text))
                                    {
                                        if (productlist[i].Id == Convert.ToDouble(cart_productIDTB.Text) && productlist[i].Quantity + 1 <= variableMaximumQuantity )
                                        {
                                            productlist[i].Quantity = productlist[i].Quantity + 1;
                                            productlist[i].TotalPrice = productlist[i].Quantity * productlist[i].UnitPrice;
                                            productlist.ResetBindings();
                                        }
                                    }
                                    else
                                    {
                                        if (productlist[i].Id == Convert.ToDouble(cart_productIDTB.Text) && productlist[i].Quantity + Convert.ToDouble(cart_quantityTB.Text) <= variableMaximumQuantity)
                                        {
                                            productlist[i].Quantity = productlist[i].Quantity + Convert.ToDouble(cart_quantityTB.Text);
                                            productlist[i].TotalPrice = productlist[i].Quantity * productlist[i].UnitPrice;
                                            productlist.ResetBindings();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(cart_quantityTB.Text))
                                {
                                    this.quantity = 1;
                                }
                                else if (Convert.ToDouble(cart_quantityTB.Text) > 0)
                                {
                                    this.quantity = Convert.ToDouble(cart_quantityTB.Text);
                                }
                                this.id = Convert.ToInt32(productReader["product_id"].ToString());
                                this.productName = productReader["product_name"].ToString();
                                this.brandName = productReader["brand"].ToString();
                                this.unitPrice = Convert.ToDouble(productReader["unit_price"]);
                                this.stockQuantity = Convert.ToDouble(productReader["stock_quantity"]);
                                productlist.Add(new Product(this.id, this.productName, this.brandName, this.unitPrice, this.quantity, this.stockQuantity));
                            }
                        }
                    }
                    connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Please Enter Product ID");
                    Log.ReferenceEquals(this, ex);
                }
            }
            cart_productIDTB.Text = String.Empty;
            cart_quantityTB.Text = String.Empty;
            updateCartValue();
        }
       

        private void cart_productIDTB_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionQuery.connectionString))
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand($"select * from products where product_id = {Convert.ToInt32(cart_productIDTB.Text)}", connection);
                    productReader = command.ExecuteReader();
                    while (productReader.Read())
                    {
                        if (productReader["product_id"].ToString() == cart_productIDTB.Text)
                        {
                            variableMaximumQuantity = Convert.ToDouble(productReader["stock_quantity"].ToString());
                            cart_quantityTB.PlaceholderText = "Maximum Quantity: " + variableMaximumQuantity;
                        }              
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    cart_quantityTB.PlaceholderText = "Quantity";
                }
            }          
        }

        private void cart_updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < productlist.Count; i++)
                {
                    if (productlist[i].Id == Convert.ToInt32(cart_productIDTB.Text))
                    {
                        if (String.IsNullOrEmpty(cart_quantityTB.Text))
                        {
                            MessageBox.Show("Please enter the new quantity to update");
                        }
                        else if (Convert.ToDouble(cart_quantityTB.Text) > 0)
                        {
                            productlist[i].Quantity = Convert.ToDouble(cart_quantityTB.Text);
                            productlist[i].TotalPrice = productlist[i].Quantity * productlist[i].UnitPrice;
                            productlist.ResetBindings();
                        }
                    }
                }
                cart_productIDTB.Text = String.Empty;
                cart_quantityTB.Text = String.Empty;
                updateCartValue();
            }
            catch(Exception ex) {
                MessageBox.Show("Please Enter Product ID");
            }

        }

        private void cart_deleteButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cart_productIDTB.Text))
            {
                MessageBox.Show("Please Enter ProductID To Delete Item");
            }
            
            else
            {
                for (int i = 0; i < productlist.Count; i++)
                {
                    if (productlist[i].Id == Convert.ToInt32(cart_productIDTB.Text))
                    {
                        productlist.RemoveAt(i);
                    }
                }
            }
            
            cart_productIDTB.Text = String.Empty;
            cart_quantityTB.Text = String.Empty;
            updateCartValue();
        }

        public void updateCartValue()
        {
            cartValue = 0.0f;
            foreach(Product product in productlist) {
                cartValue += product.TotalPrice;
            }
            cartValueLabel.Text = "Tk " + cartValue.ToString();
        }
        public bool checkSimilarity(double id)
        {
            bool similar =false;
            for(int i=0; i<productlist.Count; i++)
            {
                if (productlist[i].Id== id)
                {
                    similar = true;
                }               
            }
            return similar;
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void cart_quantityTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(cart_quantityTB.Text.ToString()) > variableMaximumQuantity)
                {
                    MessageBox.Show($"Maximum Quantity Exceeded.\nYou Can take Maximum: {variableMaximumQuantity} units");
                    cart_quantityTB.Text = String.Empty;
                }
            }catch(Exception ex) {
                cart_quantityTB.PlaceholderText = "Quantity";
                Log.ReferenceEquals(this, ex);  
            }
        }

        private void cart_checkoutButton_Click(object sender, EventArgs e)
        {
            if (customerNameTB.Text!= String.Empty && customerContactTB.Text!=String.Empty )
            {
                using (SqlConnection conn = new SqlConnection(ConnectionQuery.connectionString))
                {
                    string query;
                    conn.Open();
                    foreach (Product product in productlist)
                    {
                        query = $"update products set stock_quantity= {product.getStockQuantity() - product.Quantity} where product_id ={product.Id}";
                        command = new SqlCommand(query, conn);
                        command.ExecuteNonQuery();
                    }
                    DateTime date = DateTime.Now;
                    query = $"INSERT INTO sales (sale_date, customer_name, customer_contact, total_amount) VALUES ('{date}', '{customerNameTB.Text}','{customerContactTB.Text}', {this.cartValue})";
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("CheckOut Successful", "Checkout");
                this.Close();
            }
            if(customerNameTB.Text == String.Empty) {
                
                errorProvider.SetError(customerNameTB, "Enter Customer Name");
            }
            if(customerContactTB.Text == String.Empty)
            {
                errorProviderContact.SetError(customerContactTB, "Enter Customer ContactNo");
            }
        }
    }

    class Product
    {
        private int id;
        private string productName;
        private string brandName;
        private double unitPrice;
        private double quantity;
        private double totalPrice;
        private double stockQuantity;

        public Product(int id, string productName, string brandName, double unitPrice, double quantity, double stockQuantity)
        {
            this.id = id;
            this.ProductName = productName;
            this.BrandName = brandName;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            if (quantity > 0)
            {
                this.TotalPrice = quantity * unitPrice;
            }
            this.stockQuantity= stockQuantity;
        }

        public int Id { get => id; set => id = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string BrandName { get => brandName; set => brandName = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        public double getStockQuantity()
        {
            return stockQuantity;
        }
    }
}
