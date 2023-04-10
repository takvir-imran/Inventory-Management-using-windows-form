namespace Invenetory_Management
{
    partial class AddProduct
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
            this.productIdTB = new System.Windows.Forms.TextBox();
            this.productNameTB = new System.Windows.Forms.TextBox();
            this.unitPriceTB = new System.Windows.Forms.TextBox();
            this.stockQuantityTB = new System.Windows.Forms.TextBox();
            this.reorderLevelTB = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.brandCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // productIdTB
            // 
            this.productIdTB.Location = new System.Drawing.Point(34, 33);
            this.productIdTB.Name = "productIdTB";
            this.productIdTB.PlaceholderText = "Product ID";
            this.productIdTB.Size = new System.Drawing.Size(282, 23);
            this.productIdTB.TabIndex = 0;
            // 
            // productNameTB
            // 
            this.productNameTB.Location = new System.Drawing.Point(34, 78);
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.PlaceholderText = "Product Name";
            this.productNameTB.Size = new System.Drawing.Size(282, 23);
            this.productNameTB.TabIndex = 1;
            // 
            // unitPriceTB
            // 
            this.unitPriceTB.Location = new System.Drawing.Point(35, 162);
            this.unitPriceTB.Name = "unitPriceTB";
            this.unitPriceTB.PlaceholderText = "Unit Price";
            this.unitPriceTB.Size = new System.Drawing.Size(281, 23);
            this.unitPriceTB.TabIndex = 4;
            // 
            // stockQuantityTB
            // 
            this.stockQuantityTB.Location = new System.Drawing.Point(35, 205);
            this.stockQuantityTB.Name = "stockQuantityTB";
            this.stockQuantityTB.PlaceholderText = "Stock Quantity";
            this.stockQuantityTB.Size = new System.Drawing.Size(282, 23);
            this.stockQuantityTB.TabIndex = 5;
            // 
            // reorderLevelTB
            // 
            this.reorderLevelTB.Location = new System.Drawing.Point(34, 249);
            this.reorderLevelTB.Name = "reorderLevelTB";
            this.reorderLevelTB.PlaceholderText = "Reorder Level";
            this.reorderLevelTB.Size = new System.Drawing.Size(282, 23);
            this.reorderLevelTB.TabIndex = 6;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(209, 301);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(108, 35);
            this.addProductButton.TabIndex = 7;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // categoryCB
            // 
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(34, 122);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(141, 23);
            this.categoryCB.Sorted = true;
            this.categoryCB.TabIndex = 8;
            // 
            // brandCB
            // 
            this.brandCB.FormattingEnabled = true;
            this.brandCB.Location = new System.Drawing.Point(181, 122);
            this.brandCB.Name = "brandCB";
            this.brandCB.Size = new System.Drawing.Size(135, 23);
            this.brandCB.Sorted = true;
            this.brandCB.TabIndex = 9;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 385);
            this.Controls.Add(this.brandCB);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.reorderLevelTB);
            this.Controls.Add(this.stockQuantityTB);
            this.Controls.Add(this.unitPriceTB);
            this.Controls.Add(this.productNameTB);
            this.Controls.Add(this.productIdTB);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox productIdTB;
        private TextBox productNameTB;
        private TextBox unitPriceTB;
        private TextBox stockQuantityTB;
        private TextBox reorderLevelTB;
        private Button addProductButton;
        private ComboBox categoryCB;
        private ComboBox brandCB;
    }
}