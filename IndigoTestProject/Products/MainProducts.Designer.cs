namespace IndigoTestProject
{
    partial class MainProducts
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
            this.lProductCode = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lProductName = new System.Windows.Forms.Label();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.bProductImage = new System.Windows.Forms.Button();
            this.mtbProductCode = new System.Windows.Forms.MaskedTextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.lQuantity = new System.Windows.Forms.Label();
            this.mtbQuantity = new System.Windows.Forms.MaskedTextBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.mtbPrice = new System.Windows.Forms.MaskedTextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.bClean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lProductCode
            // 
            this.lProductCode.Location = new System.Drawing.Point(12, 50);
            this.lProductCode.Name = "lProductCode";
            this.lProductCode.Size = new System.Drawing.Size(105, 13);
            this.lProductCode.TabIndex = 0;
            this.lProductCode.Text = "Código del producto:";
            // 
            // tbProductName
            // 
            this.tbProductName.Enabled = false;
            this.tbProductName.Location = new System.Drawing.Point(127, 73);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(267, 20);
            this.tbProductName.TabIndex = 3;
            // 
            // lProductName
            // 
            this.lProductName.Location = new System.Drawing.Point(12, 76);
            this.lProductName.Name = "lProductName";
            this.lProductName.Size = new System.Drawing.Size(109, 13);
            this.lProductName.TabIndex = 2;
            this.lProductName.Text = "Nombre del producto:";
            // 
            // pbProductImage
            // 
            this.pbProductImage.Location = new System.Drawing.Point(127, 160);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(139, 90);
            this.pbProductImage.TabIndex = 4;
            this.pbProductImage.TabStop = false;
            // 
            // bProductImage
            // 
            this.bProductImage.Enabled = false;
            this.bProductImage.Location = new System.Drawing.Point(12, 190);
            this.bProductImage.Name = "bProductImage";
            this.bProductImage.Size = new System.Drawing.Size(109, 27);
            this.bProductImage.TabIndex = 6;
            this.bProductImage.Text = "Agregar imagen:";
            this.bProductImage.UseVisualStyleBackColor = true;
            // 
            // mtbProductCode
            // 
            this.mtbProductCode.HidePromptOnLeave = true;
            this.mtbProductCode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtbProductCode.Location = new System.Drawing.Point(127, 47);
            this.mtbProductCode.Mask = "999";
            this.mtbProductCode.Name = "mtbProductCode";
            this.mtbProductCode.PromptChar = ' ';
            this.mtbProductCode.Size = new System.Drawing.Size(267, 20);
            this.mtbProductCode.TabIndex = 7;
            this.mtbProductCode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mtbProductCode.ValidatingType = typeof(int);
            this.mtbProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbProductCode_KeyDown);
            // 
            // bSave
            // 
            this.bSave.Enabled = false;
            this.bSave.Location = new System.Drawing.Point(176, 258);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Guardar";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lQuantity
            // 
            this.lQuantity.Location = new System.Drawing.Point(12, 102);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.Size = new System.Drawing.Size(109, 13);
            this.lQuantity.TabIndex = 9;
            this.lQuantity.Text = "Cantidad actual:";
            // 
            // mtbQuantity
            // 
            this.mtbQuantity.Enabled = false;
            this.mtbQuantity.HidePromptOnLeave = true;
            this.mtbQuantity.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtbQuantity.Location = new System.Drawing.Point(127, 99);
            this.mtbQuantity.Mask = "999";
            this.mtbQuantity.Name = "mtbQuantity";
            this.mtbQuantity.PromptChar = ' ';
            this.mtbQuantity.Size = new System.Drawing.Size(267, 20);
            this.mtbQuantity.TabIndex = 11;
            this.mtbQuantity.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mtbQuantity.ValidatingType = typeof(int);
            // 
            // bDelete
            // 
            this.bDelete.Enabled = false;
            this.bDelete.Location = new System.Drawing.Point(274, 258);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(123, 23);
            this.bDelete.TabIndex = 12;
            this.bDelete.Text = "Eliminar producto";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // mtbPrice
            // 
            this.mtbPrice.Enabled = false;
            this.mtbPrice.HidePromptOnLeave = true;
            this.mtbPrice.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtbPrice.Location = new System.Drawing.Point(127, 125);
            this.mtbPrice.Mask = "999";
            this.mtbPrice.Name = "mtbPrice";
            this.mtbPrice.PromptChar = ' ';
            this.mtbPrice.Size = new System.Drawing.Size(267, 20);
            this.mtbPrice.TabIndex = 14;
            this.mtbPrice.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mtbPrice.ValidatingType = typeof(int);
            // 
            // lPrice
            // 
            this.lPrice.Location = new System.Drawing.Point(12, 128);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(105, 13);
            this.lPrice.TabIndex = 13;
            this.lPrice.Text = "Precio:";
            // 
            // bClean
            // 
            this.bClean.Enabled = false;
            this.bClean.Location = new System.Drawing.Point(80, 258);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(75, 23);
            this.bClean.TabIndex = 15;
            this.bClean.Text = "Limpiar";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Productos";
            // 
            // MainProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.mtbPrice);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.mtbQuantity);
            this.Controls.Add(this.lQuantity);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.mtbProductCode);
            this.Controls.Add(this.bProductImage);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.lProductName);
            this.Controls.Add(this.lProductCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainProducts";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lProductCode;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lProductName;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Button bProductImage;
        private System.Windows.Forms.MaskedTextBox mtbProductCode;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lQuantity;
        private System.Windows.Forms.MaskedTextBox mtbQuantity;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.MaskedTextBox mtbPrice;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.Label label1;
    }
}