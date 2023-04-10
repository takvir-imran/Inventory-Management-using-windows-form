namespace Invenetory_Management
{
    partial class ForgetPasswordForm
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
            this.f_emailTB = new System.Windows.Forms.TextBox();
            this.sendCodeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.f_varificationCodeTB = new System.Windows.Forms.TextBox();
            this.varifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f_emailTB
            // 
            this.f_emailTB.Location = new System.Drawing.Point(28, 78);
            this.f_emailTB.Name = "f_emailTB";
            this.f_emailTB.PlaceholderText = "Enter Email";
            this.f_emailTB.Size = new System.Drawing.Size(189, 23);
            this.f_emailTB.TabIndex = 0;
            // 
            // sendCodeButton
            // 
            this.sendCodeButton.Location = new System.Drawing.Point(223, 77);
            this.sendCodeButton.Name = "sendCodeButton";
            this.sendCodeButton.Size = new System.Drawing.Size(74, 24);
            this.sendCodeButton.TabIndex = 1;
            this.sendCodeButton.Text = "Send Code";
            this.sendCodeButton.UseVisualStyleBackColor = true;
            this.sendCodeButton.Click += new System.EventHandler(this.sendCodeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "If the account exist then a recovery email will \r\nbe sent to your email account\r\n" +
    "\r\n";
            // 
            // f_varificationCodeTB
            // 
            this.f_varificationCodeTB.Location = new System.Drawing.Point(28, 122);
            this.f_varificationCodeTB.Name = "f_varificationCodeTB";
            this.f_varificationCodeTB.PlaceholderText = "Enter Varification Code";
            this.f_varificationCodeTB.Size = new System.Drawing.Size(189, 23);
            this.f_varificationCodeTB.TabIndex = 3;
            this.f_varificationCodeTB.Visible = false;
            // 
            // varifyButton
            // 
            this.varifyButton.Location = new System.Drawing.Point(223, 122);
            this.varifyButton.Name = "varifyButton";
            this.varifyButton.Size = new System.Drawing.Size(74, 23);
            this.varifyButton.TabIndex = 4;
            this.varifyButton.Text = "Varify";
            this.varifyButton.UseVisualStyleBackColor = true;
            this.varifyButton.Visible = false;
            this.varifyButton.Click += new System.EventHandler(this.varifyButton_Click);
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 140);
            this.Controls.Add(this.varifyButton);
            this.Controls.Add(this.f_varificationCodeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendCodeButton);
            this.Controls.Add(this.f_emailTB);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Forget Password ";
            this.Load += new System.EventHandler(this.ForgetPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox f_emailTB;
        private Button sendCodeButton;
        private Label label1;
        private TextBox f_varificationCodeTB;
        private Button varifyButton;
    }
}