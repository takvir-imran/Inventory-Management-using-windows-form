namespace Invenetory_Management
{
    partial class UpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            this.u_productIdTB = new System.Windows.Forms.TextBox();
            this.u_searchButton = new System.Windows.Forms.Button();
            this.u_productNameTB = new System.Windows.Forms.TextBox();
            this.u_categoryTB = new System.Windows.Forms.TextBox();
            this.u_brandTB = new System.Windows.Forms.TextBox();
            this.u_unitpriceTB = new System.Windows.Forms.TextBox();
            this.u_stockQuantityTB = new System.Windows.Forms.TextBox();
            this.u_reorderLevelTB = new System.Windows.Forms.TextBox();
            this.u_updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // u_productIdTB
            // 
            this.u_productIdTB.Location = new System.Drawing.Point(21, 65);
            this.u_productIdTB.Name = "u_productIdTB";
            this.u_productIdTB.PlaceholderText = "Enter Product ID";
            this.u_productIdTB.Size = new System.Drawing.Size(194, 23);
            this.u_productIdTB.TabIndex = 0;
            this.u_productIdTB.TextChanged += new System.EventHandler(this.u_productIdTB_TextChanged);
            // 
            // u_searchButton
            // 
            this.u_searchButton.Image = ((System.Drawing.Image)(resources.GetObject("u_searchButton.Image")));
            this.u_searchButton.Location = new System.Drawing.Point(222, 65);
            this.u_searchButton.Name = "u_searchButton";
            this.u_searchButton.Size = new System.Drawing.Size(47, 23);
            this.u_searchButton.TabIndex = 1;
            this.u_searchButton.UseVisualStyleBackColor = true;
            this.u_searchButton.Click += new System.EventHandler(this.u_searchButton_Click);
            // 
            // u_productNameTB
            // 
            this.u_productNameTB.Location = new System.Drawing.Point(22, 98);
            this.u_productNameTB.Name = "u_productNameTB";
            this.u_productNameTB.PlaceholderText = "Product Name";
            this.u_productNameTB.Size = new System.Drawing.Size(247, 23);
            this.u_productNameTB.TabIndex = 2;
            // 
            // u_categoryTB
            // 
            this.u_categoryTB.Location = new System.Drawing.Point(21, 134);
            this.u_categoryTB.Name = "u_categoryTB";
            this.u_categoryTB.PlaceholderText = "Category";
            this.u_categoryTB.Size = new System.Drawing.Size(122, 23);
            this.u_categoryTB.TabIndex = 3;
            // 
            // u_brandTB
            // 
            this.u_brandTB.Location = new System.Drawing.Point(149, 134);
            this.u_brandTB.Name = "u_brandTB";
            this.u_brandTB.PlaceholderText = "Brand";
            this.u_brandTB.Size = new System.Drawing.Size(120, 23);
            this.u_brandTB.TabIndex = 4;
            // 
            // u_unitpriceTB
            // 
            this.u_unitpriceTB.Location = new System.Drawing.Point(21, 172);
            this.u_unitpriceTB.Name = "u_unitpriceTB";
            this.u_unitpriceTB.PlaceholderText = "Unit Price";
            this.u_unitpriceTB.Size = new System.Drawing.Size(247, 23);
            this.u_unitpriceTB.TabIndex = 5;
            // 
            // u_stockQuantityTB
            // 
            this.u_stockQuantityTB.Location = new System.Drawing.Point(22, 211);
            this.u_stockQuantityTB.Name = "u_stockQuantityTB";
            this.u_stockQuantityTB.PlaceholderText = "Stock Quantity";
            this.u_stockQuantityTB.Size = new System.Drawing.Size(247, 23);
            this.u_stockQuantityTB.TabIndex = 6;
            // 
            // u_reorderLevelTB
            // 
            this.u_reorderLevelTB.Location = new System.Drawing.Point(22, 249);
            this.u_reorderLevelTB.Name = "u_reorderLevelTB";
            this.u_reorderLevelTB.PlaceholderText = "Reorder Level";
            this.u_reorderLevelTB.Size = new System.Drawing.Size(247, 23);
            this.u_reorderLevelTB.TabIndex = 7;
            // 
            // u_updateButton
            // 
            this.u_updateButton.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.u_updateButton.Location = new System.Drawing.Point(181, 307);
            this.u_updateButton.Name = "u_updateButton";
            this.u_updateButton.Size = new System.Drawing.Size(87, 48);
            this.u_updateButton.TabIndex = 8;
            this.u_updateButton.Text = "Update";
            this.u_updateButton.UseVisualStyleBackColor = true;
            this.u_updateButton.Click += new System.EventHandler(this.u_updateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Enter Product ID To Find The Product You \r\nWant To Update\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.u_updateButton);
            this.Controls.Add(this.u_reorderLevelTB);
            this.Controls.Add(this.u_stockQuantityTB);
            this.Controls.Add(this.u_unitpriceTB);
            this.Controls.Add(this.u_brandTB);
            this.Controls.Add(this.u_categoryTB);
            this.Controls.Add(this.u_productNameTB);
            this.Controls.Add(this.u_searchButton);
            this.Controls.Add(this.u_productIdTB);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UpdateProduct";
            this.Text = "UpdateProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox u_productIdTB;
        private Button u_searchButton;
        private TextBox u_productNameTB;
        private TextBox u_categoryTB;
        private TextBox u_brandTB;
        private TextBox u_unitpriceTB;
        private TextBox u_stockQuantityTB;
        private TextBox u_reorderLevelTB;
        private Button u_updateButton;
        private Label label1;
    }
}