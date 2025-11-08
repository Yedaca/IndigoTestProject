namespace IndigoTestProjectFront
{
    partial class Main
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
            label1 = new Label();
            bProducts = new Button();
            bSalesReports = new Button();
            bBuyProduct = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold);
            label1.Location = new Point(205, 128);
            label1.Name = "label1";
            label1.Size = new Size(551, 32);
            label1.TabIndex = 0;
            label1.Text = "Sistema de gestión y venta de productos";
            // 
            // bProducts
            // 
            bProducts.Location = new Point(380, 200);
            bProducts.Name = "bProducts";
            bProducts.Size = new Size(170, 52);
            bProducts.TabIndex = 1;
            bProducts.Text = "Productos";
            bProducts.UseVisualStyleBackColor = true;
            bProducts.Click += bProducts_Click;
            // 
            // bSalesReports
            // 
            bSalesReports.Location = new Point(380, 316);
            bSalesReports.Name = "bSalesReports";
            bSalesReports.Size = new Size(170, 52);
            bSalesReports.TabIndex = 2;
            bSalesReports.Text = "Reportes de ventas";
            bSalesReports.UseVisualStyleBackColor = true;
            // 
            // bBuyProduct
            // 
            bBuyProduct.Location = new Point(380, 258);
            bBuyProduct.Name = "bBuyProduct";
            bBuyProduct.Size = new Size(170, 52);
            bBuyProduct.TabIndex = 3;
            bBuyProduct.Text = "Comprar productos";
            bBuyProduct.UseVisualStyleBackColor = true;
            bBuyProduct.Click += bBuyProduct_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 508);
            Controls.Add(bBuyProduct);
            Controls.Add(bSalesReports);
            Controls.Add(bProducts);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de gestión y venta de productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bProducts;
        private Button bSalesReports;
        private Button bBuyProduct;
    }
}
