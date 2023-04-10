namespace Invenetory_Management
{
    partial class Suppliers
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
            this.supplierDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierDataGrid
            // 
            this.supplierDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGrid.Location = new System.Drawing.Point(12, 12);
            this.supplierDataGrid.Name = "supplierDataGrid";
            this.supplierDataGrid.RowTemplate.Height = 25;
            this.supplierDataGrid.Size = new System.Drawing.Size(791, 379);
            this.supplierDataGrid.TabIndex = 0;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 547);
            this.Controls.Add(this.supplierDataGrid);
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView supplierDataGrid;
    }
}