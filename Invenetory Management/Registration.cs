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
    public partial class Registration : Form
    {
        SqlConnection connection = new SqlConnection(ConnectionQuery.connectionString);
        SqlCommand command;

        public Registration()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand($"insert into users (username, email, pswd, contactNo) values ('{r_userNameTB.Text}', '{r_emailTB.Text}', '{r_passowordTB.Text}', '{r_contactNoTB.Text}')", connection);
            try
            {
                if (command.ExecuteNonQuery() != 0)
                {
                    connection.Close();
                    this.Close();
                    MessageBox.Show("User Created", "Successfull");
                    
                }
            }catch(Exception ex)
            {
                string msg = "Error Report: " + ex.Message + "\nThis email address already exists";
                MessageBox.Show(msg, "Error");
            }
           
            connection.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
