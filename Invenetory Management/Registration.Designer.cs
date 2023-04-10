namespace Invenetory_Management
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.r_userNameTB = new System.Windows.Forms.TextBox();
            this.r_emailTB = new System.Windows.Forms.TextBox();
            this.r_passowordTB = new System.Windows.Forms.TextBox();
            this.r_contactNoTB = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // r_userNameTB
            // 
            this.r_userNameTB.Location = new System.Drawing.Point(41, 74);
            this.r_userNameTB.Name = "r_userNameTB";
            this.r_userNameTB.PlaceholderText = "Username";
            this.r_userNameTB.Size = new System.Drawing.Size(303, 23);
            this.r_userNameTB.TabIndex = 0;
            // 
            // r_emailTB
            // 
            this.r_emailTB.Location = new System.Drawing.Point(41, 162);
            this.r_emailTB.Name = "r_emailTB";
            this.r_emailTB.PlaceholderText = "Email";
            this.r_emailTB.Size = new System.Drawing.Size(303, 23);
            this.r_emailTB.TabIndex = 1;
            // 
            // r_passowordTB
            // 
            this.r_passowordTB.Location = new System.Drawing.Point(41, 208);
            this.r_passowordTB.Name = "r_passowordTB";
            this.r_passowordTB.PasswordChar = '*';
            this.r_passowordTB.PlaceholderText = "Password";
            this.r_passowordTB.Size = new System.Drawing.Size(303, 23);
            this.r_passowordTB.TabIndex = 2;
            // 
            // r_contactNoTB
            // 
            this.r_contactNoTB.Location = new System.Drawing.Point(41, 121);
            this.r_contactNoTB.Name = "r_contactNoTB";
            this.r_contactNoTB.PlaceholderText = "Contact No.";
            this.r_contactNoTB.Size = new System.Drawing.Size(303, 23);
            this.r_contactNoTB.TabIndex = 3;
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(215, 263);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(129, 35);
            this.signupButton.TabIndex = 4;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create User Form";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.r_contactNoTB);
            this.Controls.Add(this.r_passowordTB);
            this.Controls.Add(this.r_emailTB);
            this.Controls.Add(this.r_userNameTB);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Registration";
            this.Text = "Create User";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox r_userNameTB;
        private TextBox r_emailTB;
        private TextBox r_passowordTB;
        private TextBox r_contactNoTB;
        private Button signupButton;
        private Label label1;
    }
}