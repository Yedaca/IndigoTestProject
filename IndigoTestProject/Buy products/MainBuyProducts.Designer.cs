namespace IndigoTestProject.Buy_products
{
    partial class MainBuyProducts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selection,
            this.Product,
            this.Price,
            this.QuantityAvailable,
            this.Quantity,
            this.Image});
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // Selection
            // 
            this.Selection.HeaderText = "Selección";
            this.Selection.Name = "Selection";
            this.Selection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Product
            // 
            this.Product.HeaderText = "Producto";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Precio";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // QuantityAvailable
            // 
            this.QuantityAvailable.HeaderText = "Cantidad disponible";
            this.QuantityAvailable.Name = "QuantityAvailable";
            this.QuantityAvailable.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            // 
            // Image
            // 
            this.Image.HeaderText = "Imagen";
            this.Image.Name = "Image";
            // 
            // bBuy
            // 
            this.bBuy.Location = new System.Drawing.Point(279, 262);
            this.bBuy.Name = "bBuy";
            this.bBuy.Size = new System.Drawing.Size(120, 23);
            this.bBuy.TabIndex = 1;
            this.bBuy.Text = "Comprar";
            this.bBuy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Comprar productos";
            // 
            // MainBuyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBuy);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainBuyProducts";
            this.Text = "Comprar productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn Image;
        private System.Windows.Forms.Button bBuy;
        private System.Windows.Forms.Label label1;
    }
}