using Invenetory_Management.Properties;
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
using Microsoft.Data.SqlClient;
using System.Net.Mail;

namespace Invenetory_Management
{
    public partial class ForgetPasswordForm : Form
    {
        SqlConnection? connection = new SqlConnection(ConnectionQuery.connectionString);
        SqlConnection? credCon = new SqlConnection(ConnectionQuery.connectionString);
        SqlCommand? command;
        SqlCommand? credCom;
        SqlDataReader? reader;
        SqlDataReader? credentials;
        
        private string? email; 
        private string? password;
        private int varificationCode;

        private string? userName;
        private string? userEmail;
        private string? userPassword;

        public ForgetPasswordForm()
        {
            InitializeComponent();
        }
        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void sendCodeButton_Click(object sender, EventArgs e)
        {
            connection?.Open();
            command = new SqlCommand($"select * from users;", connection);
            reader= command.ExecuteReader();
            while(reader.Read())
            {
                if(f_emailTB.Text == reader["email"].ToString()) {
                    userName = reader["username"].ToString();
                    userEmail = reader["email"].ToString();
                    userPassword = reader["pswd"].ToString();
                    setCredentials();
                    using (MailMessage mail = new MailMessage())
                    {
                        mail.Subject = "Invetory Management Account Varification";
                        mail.From = new MailAddress("acc.takvir@gmail.com");
                        mail.To.Add(userEmail);
                        mail.Body = $"<p>Your varification code is <b>{generateVarificationCode()}</b></p>";

                        mail.IsBodyHtml= true;
                        using(SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            try
                            {
                                smtp.Credentials = new System.Net.NetworkCredential(this.email, this.password);
                                smtp.EnableSsl = true;
                                smtp.Send(mail); 
                                sendCodeButton.Enabled = false;
                                MessageBox.Show("A varification code has been sent to your email address");
                                this.ClientSize = new System.Drawing.Size(341, 200);
                                f_varificationCodeTB.Visible = true;
                                varifyButton.Visible = true;
                            }
                            catch(Exception ex) {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }  
                }
            }
            connection.Close();
        }
        public void setCredentials()
        {   
            credCon?.Open();
            credCom = new SqlCommand("select * from cred", credCon);
            credentials= credCom.ExecuteReader();
            if(credentials.Read())
            {
                this.email = credentials["email"].ToString();
                this.password = credentials["pass"].ToString();
            }
            credCon.Close();
        }
        public int generateVarificationCode()
        {
            Random random= new Random();
            varificationCode = random.Next(999999);
            return varificationCode;
        }

        private void varifyButton_Click(object sender, EventArgs e)
        {
            if(f_varificationCodeTB.Text == this.varificationCode.ToString())
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.Subject = "Password Recovery";
                    mail.From = new MailAddress(this.email);
                    mail.To.Add(f_emailTB.Text);
                    mail.Body = $"<p>Hello <b>{userName}</b>,<br>Your app cretentials are given below<br>Email: {userEmail}<br>Password: {userPassword}</p>";
                    mail.IsBodyHtml = true;
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        try
                        {
                            setCredentials();
                            smtp.Credentials = new System.Net.NetworkCredential(this.email, this.password);
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                            MessageBox.Show("Verified! Your credentials has been sent to your email");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Varification Code Not Matched!!!");
            }
        }
    }
}
