namespace Invenetory_Management
{
    partial class DeleteProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteProduct));
            this.d_productIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.d_deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // d_productIdTB
            // 
            this.d_productIdTB.Location = new System.Drawing.Point(31, 61);
            this.d_productIdTB.Name = "d_productIdTB";
            this.d_productIdTB.PlaceholderText = "Product ID";
            this.d_productIdTB.Size = new System.Drawing.Size(261, 23);
            this.d_productIdTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Product ID To Delete";
            // 
            // d_deleteButton
            // 
            this.d_deleteButton.Location = new System.Drawing.Point(182, 99);
            this.d_deleteButton.Name = "d_deleteButton";
            this.d_deleteButton.Size = new System.Drawing.Size(110, 33);
            this.d_deleteButton.TabIndex = 2;
            this.d_deleteButton.Text = "Delete";
            this.d_deleteButton.UseVisualStyleBackColor = true;
            this.d_deleteButton.Click += new System.EventHandler(this.d_deleteButton_Click);
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 158);
            this.Controls.Add(this.d_deleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d_productIdTB);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteProduct";
            this.Text = "Delete Product";
            this.Load += new System.EventHandler(this.DeleteProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox d_productIdTB;
        private Label label1;
        private Button d_deleteButton;
    }
}