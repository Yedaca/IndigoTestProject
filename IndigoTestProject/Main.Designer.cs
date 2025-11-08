namespace IndigoTestProject
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bProducts = new System.Windows.Forms.Button();
            this.bBuyProduct = new System.Windows.Forms.Button();
            this.bSalesReports = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bProducts
            // 
            this.bProducts.Location = new System.Drawing.Point(187, 101);
            this.bProducts.Name = "bProducts";
            this.bProducts.Size = new System.Drawing.Size(170, 52);
            this.bProducts.TabIndex = 0;
            this.bProducts.Text = "Productos";
            this.bProducts.UseVisualStyleBackColor = true;
            // 
            // bBuyProduct
            // 
            this.bBuyProduct.Location = new System.Drawing.Point(187, 159);
            this.bBuyProduct.Name = "bBuyProduct";
            this.bBuyProduct.Size = new System.Drawing.Size(170, 52);
            this.bBuyProduct.TabIndex = 2;
            this.bBuyProduct.Text = "Comprar productos";
            this.bBuyProduct.UseVisualStyleBackColor = true;
            // 
            // bSalesReports
            // 
            this.bSalesReports.Location = new System.Drawing.Point(187, 217);
            this.bSalesReports.Name = "bSalesReports";
            this.bSalesReports.Size = new System.Drawing.Size(170, 52);
            this.bSalesReports.TabIndex = 3;
            this.bSalesReports.Text = "Reportes de ventas";
            this.bSalesReports.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema de gestión y venta de productos";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSalesReports);
            this.Controls.Add(this.bBuyProduct);
            this.Controls.Add(this.bProducts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Sistema de gestión y venta de productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bProducts;
        private System.Windows.Forms.Button bBuyProduct;
        private System.Windows.Forms.Button bSalesReports;
        private System.Windows.Forms.Label label1;
    }
}

