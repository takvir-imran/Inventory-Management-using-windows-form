namespace Invenetory_Management
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.forgetPassLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Invenetory_Management.Properties.Resources._172149;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(88, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.emailTextBox.Location = new System.Drawing.Point(38, 213);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PlaceholderText = "Email";
            this.emailTextBox.Size = new System.Drawing.Size(192, 22);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Text = "admin@gmail.com";
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Management System";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(38, 249);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Password";
            this.passwordTextBox.Size = new System.Drawing.Size(192, 22);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "1234";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signInButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signInButton.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signInButton.Location = new System.Drawing.Point(38, 356);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(192, 36);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(41, 314);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(182, 14);
            this.warningLabel.TabIndex = 6;
            this.warningLabel.Text = "Try Again. Wrong email or password\r\n";
            this.warningLabel.Visible = false;
            // 
            // forgetPassLabel
            // 
            this.forgetPassLabel.AutoSize = true;
            this.forgetPassLabel.Location = new System.Drawing.Point(90, 484);
            this.forgetPassLabel.Name = "forgetPassLabel";
            this.forgetPassLabel.Size = new System.Drawing.Size(94, 14);
            this.forgetPassLabel.TabIndex = 7;
            this.forgetPassLabel.TabStop = true;
            this.forgetPassLabel.Text = "Forget Password?";
            this.forgetPassLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetPassLabel_LinkClicked);
            // 
            // loginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(264, 531);
            this.Controls.Add(this.forgetPassLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox emailTextBox;
        private Label label1;
        private TextBox passwordTextBox;
        private Button signInButton;
        private Label warningLabel;
        private LinkLabel forgetPassLabel;
    }
}