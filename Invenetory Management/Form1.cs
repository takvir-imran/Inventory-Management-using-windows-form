using Microsoft.Data.SqlClient;
using System.Data;
using System.Net.Mail;
namespace Invenetory_Management
{
    public partial class loginForm : Form
    {
        SqlConnection connection = new SqlConnection(ConnectionQuery.connectionString);
        public static bool isLoggedIn = false;
        
        public loginForm()
        {
            InitializeComponent();
        }
        private void signInButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from users where email=@email and pswd =@pass;", connection);
            cmd.Parameters.AddWithValue("email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("pass", passwordTextBox.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) {
                if(reader["email"].ToString() == emailTextBox.Text && reader["pswd"].ToString()== passwordTextBox.Text && isLoggedIn==false)
                {
                    MainScreenForm mainScreenForm = new MainScreenForm(reader["username"].ToString());
                    mainScreenForm.RefToLoginForm = this;
                    mainScreenForm.Show();
                    isLoggedIn= true;
                    this.Hide();
                }
            }
            else
            {
                warningLabel.Visible = true;
            }
            connection.Close();
        }
       

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgetPassLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPasswordForm fp = new ForgetPasswordForm();
            fp.ShowDialog();
        }
    }
}