namespace IndigoTestProjectFront
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
            label1 = new Label();
            dgvProducts = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            AvailableQuantity = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            bBuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 32);
            label1.TabIndex = 0;
            label1.Text = "Comprar productos";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { Id, ProductCode, Product, Price, AvailableQuantity, Quantity });
            dgvProducts.Location = new Point(12, 53);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(665, 204);
            dgvProducts.TabIndex = 1;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ProductId";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // ProductCode
            // 
            ProductCode.DataPropertyName = "ProductCode";
            ProductCode.HeaderText = "Código del producto";
            ProductCode.Name = "ProductCode";
            ProductCode.Visible = false;
            // 
            // Product
            // 
            Product.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Product.DataPropertyName = "ProductName";
            Product.HeaderText = "Producto";
            Product.Name = "Product";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Precio";
            Price.Name = "Price";
            // 
            // AvailableQuantity
            // 
            AvailableQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AvailableQuantity.DataPropertyName = "Quantity";
            AvailableQuantity.HeaderText = "Cantidad disponible";
            AvailableQuantity.Name = "AvailableQuantity";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.HeaderText = "Cantidad a comprar";
            Quantity.Name = "Quantity";
            // 
            // bBuy
            // 
            bBuy.Location = new Point(308, 263);
            bBuy.Name = "bBuy";
            bBuy.Size = new Size(75, 23);
            bBuy.TabIndex = 2;
            bBuy.Text = "Comprar";
            bBuy.UseVisualStyleBackColor = true;
            bBuy.Click += bBuy_Click;
            // 
            // MainBuyProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 287);
            Controls.Add(bBuy);
            Controls.Add(dgvProducts);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainBuyProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprar productos";
            Load += MainBuyProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvProducts;
        private Button bBuy;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn AvailableQuantity;
        private DataGridViewTextBoxColumn Quantity;
    }
}