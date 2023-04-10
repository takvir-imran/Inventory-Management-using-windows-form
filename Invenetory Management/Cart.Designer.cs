namespace Invenetory_Management
{
    partial class Cart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.cart_productIDTB = new System.Windows.Forms.TextBox();
            this.cart_quantityTB = new System.Windows.Forms.TextBox();
            this.cartProcutGrid = new System.Windows.Forms.DataGridView();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addToCartButton = new System.Windows.Forms.Button();
            this.cart_updateButton = new System.Windows.Forms.Button();
            this.cart_deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cartValueLabel = new System.Windows.Forms.Label();
            this.cart_checkoutButton = new System.Windows.Forms.Button();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.customerContactTB = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContact = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cartProcutGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).BeginInit();
            this.SuspendLayout();
            // 
            // cart_productIDTB
            // 
            this.cart_productIDTB.Location = new System.Drawing.Point(10, 21);
            this.cart_productIDTB.Name = "cart_productIDTB";
            this.cart_productIDTB.PlaceholderText = "Product ID";
            this.cart_productIDTB.Size = new System.Drawing.Size(222, 22);
            this.cart_productIDTB.TabIndex = 0;
            this.cart_productIDTB.TextChanged += new System.EventHandler(this.cart_productIDTB_TextChanged);
            // 
            // cart_quantityTB
            // 
            this.cart_quantityTB.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cart_quantityTB.Location = new System.Drawing.Point(237, 21);
            this.cart_quantityTB.Name = "cart_quantityTB";
            this.cart_quantityTB.PlaceholderText = "Quantity";
            this.cart_quantityTB.Size = new System.Drawing.Size(207, 23);
            this.cart_quantityTB.TabIndex = 1;
            this.cart_quantityTB.TextChanged += new System.EventHandler(this.cart_quantityTB_TextChanged);
            // 
            // cartProcutGrid
            // 
            this.cartProcutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartProcutGrid.Location = new System.Drawing.Point(12, 50);
            this.cartProcutGrid.Name = "cartProcutGrid";
            this.cartProcutGrid.RowTemplate.Height = 25;
            this.cartProcutGrid.Size = new System.Drawing.Size(691, 370);
            this.cartProcutGrid.TabIndex = 2;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataSource = typeof(Invenetory_Management.Cart);
            // 
            // cartBindingSource1
            // 
            this.cartBindingSource1.DataSource = typeof(Invenetory_Management.Cart);
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(450, 21);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(91, 23);
            this.addToCartButton.TabIndex = 3;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // cart_updateButton
            // 
            this.cart_updateButton.Location = new System.Drawing.Point(547, 20);
            this.cart_updateButton.Name = "cart_updateButton";
            this.cart_updateButton.Size = new System.Drawing.Size(75, 23);
            this.cart_updateButton.TabIndex = 4;
            this.cart_updateButton.Text = "Update";
            this.cart_updateButton.UseVisualStyleBackColor = true;
            this.cart_updateButton.Click += new System.EventHandler(this.cart_updateButton_Click);
            // 
            // cart_deleteButton
            // 
            this.cart_deleteButton.Location = new System.Drawing.Point(628, 21);
            this.cart_deleteButton.Name = "cart_deleteButton";
            this.cart_deleteButton.Size = new System.Drawing.Size(75, 23);
            this.cart_deleteButton.TabIndex = 5;
            this.cart_deleteButton.Text = "Delete";
            this.cart_deleteButton.UseVisualStyleBackColor = true;
            this.cart_deleteButton.Click += new System.EventHandler(this.cart_deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(709, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Cart Value";
            // 
            // cartValueLabel
            // 
            this.cartValueLabel.AutoSize = true;
            this.cartValueLabel.Font = new System.Drawing.Font("Roboto Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cartValueLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cartValueLabel.Location = new System.Drawing.Point(709, 313);
            this.cartValueLabel.Name = "cartValueLabel";
            this.cartValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cartValueLabel.Size = new System.Drawing.Size(74, 35);
            this.cartValueLabel.TabIndex = 7;
            this.cartValueLabel.Text = "Tk 0 ";
            // 
            // cart_checkoutButton
            // 
            this.cart_checkoutButton.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cart_checkoutButton.Location = new System.Drawing.Point(709, 373);
            this.cart_checkoutButton.Name = "cart_checkoutButton";
            this.cart_checkoutButton.Size = new System.Drawing.Size(141, 47);
            this.cart_checkoutButton.TabIndex = 8;
            this.cart_checkoutButton.Text = "Check Out";
            this.cart_checkoutButton.UseVisualStyleBackColor = true;
            this.cart_checkoutButton.Click += new System.EventHandler(this.cart_checkoutButton_Click);
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(713, 54);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.PlaceholderText = "Customer Name";
            this.customerNameTB.Size = new System.Drawing.Size(137, 22);
            this.customerNameTB.TabIndex = 9;
            // 
            // customerContactTB
            // 
            this.customerContactTB.Location = new System.Drawing.Point(713, 82);
            this.customerContactTB.Name = "customerContactTB";
            this.customerContactTB.PlaceholderText = "Contact No";
            this.customerContactTB.Size = new System.Drawing.Size(137, 22);
            this.customerContactTB.TabIndex = 10;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProviderContact
            // 
            this.errorProviderContact.ContainerControl = this;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 440);
            this.Controls.Add(this.customerContactTB);
            this.Controls.Add(this.customerNameTB);
            this.Controls.Add(this.cart_checkoutButton);
            this.Controls.Add(this.cartValueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cart_deleteButton);
            this.Controls.Add(this.cart_updateButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.cartProcutGrid);
            this.Controls.Add(this.cart_quantityTB);
            this.Controls.Add(this.cart_productIDTB);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartProcutGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox cart_productIDTB;
        private TextBox cart_quantityTB;
        private DataGridView cartProcutGrid;
        private BindingSource cartBindingSource;
        private BindingSource cartBindingSource1;
        private Button addToCartButton;
        private Button cart_updateButton;
        private Button cart_deleteButton;
        private Label label1;
        private Label cartValueLabel;
        private Button cart_checkoutButton;
        private TextBox customerNameTB;
        private TextBox customerContactTB;
        private ErrorProvider errorProvider;
        private ErrorProvider errorProviderContact;
    }
}