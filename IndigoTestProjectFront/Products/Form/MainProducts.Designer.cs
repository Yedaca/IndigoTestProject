namespace IndigoTestProjectFront.Products
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
            label1 = new Label();
            lProductCode = new Label();
            lProductName = new Label();
            lQuantity = new Label();
            lPrice = new Label();
            mtbProductCode = new MaskedTextBox();
            mtbQuantity = new MaskedTextBox();
            tbProductName = new TextBox();
            mtbPrice = new MaskedTextBox();
            bClean = new Button();
            bSave = new Button();
            bDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // lProductCode
            // 
            lProductCode.AutoSize = true;
            lProductCode.Location = new Point(12, 50);
            lProductCode.Name = "lProductCode";
            lProductCode.Size = new Size(120, 15);
            lProductCode.TabIndex = 1;
            lProductCode.Text = "Código del producto:";
            // 
            // lProductName
            // 
            lProductName.AutoSize = true;
            lProductName.Location = new Point(12, 76);
            lProductName.Name = "lProductName";
            lProductName.Size = new Size(125, 15);
            lProductName.TabIndex = 2;
            lProductName.Text = "Nombre del producto:";
            // 
            // lQuantity
            // 
            lQuantity.AutoSize = true;
            lQuantity.Location = new Point(12, 103);
            lQuantity.Name = "lQuantity";
            lQuantity.Size = new Size(93, 15);
            lQuantity.TabIndex = 3;
            lQuantity.Text = "Cantidad actual:";
            // 
            // lPrice
            // 
            lPrice.AutoSize = true;
            lPrice.Location = new Point(12, 132);
            lPrice.Name = "lPrice";
            lPrice.Size = new Size(43, 15);
            lPrice.TabIndex = 4;
            lPrice.Text = "Precio:";
            // 
            // mtbProductCode
            // 
            mtbProductCode.HidePromptOnLeave = true;
            mtbProductCode.InsertKeyMode = InsertKeyMode.Insert;
            mtbProductCode.Location = new Point(153, 47);
            mtbProductCode.Mask = "999";
            mtbProductCode.Name = "mtbProductCode";
            mtbProductCode.PromptChar = ' ';
            mtbProductCode.Size = new Size(267, 23);
            mtbProductCode.TabIndex = 5;
            mtbProductCode.TextMaskFormat = MaskFormat.IncludePrompt;
            mtbProductCode.ValidatingType = typeof(int);
            mtbProductCode.KeyDown += mtbProductCode_KeyDown;
            // 
            // mtbQuantity
            // 
            mtbQuantity.Enabled = false;
            mtbQuantity.HidePromptOnLeave = true;
            mtbQuantity.InsertKeyMode = InsertKeyMode.Insert;
            mtbQuantity.Location = new Point(153, 100);
            mtbQuantity.Mask = "999";
            mtbQuantity.Name = "mtbQuantity";
            mtbQuantity.PromptChar = ' ';
            mtbQuantity.Size = new Size(267, 23);
            mtbQuantity.TabIndex = 6;
            mtbQuantity.TextMaskFormat = MaskFormat.IncludePrompt;
            mtbQuantity.ValidatingType = typeof(int);
            // 
            // tbProductName
            // 
            tbProductName.Enabled = false;
            tbProductName.Location = new Point(153, 73);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(267, 23);
            tbProductName.TabIndex = 7;
            // 
            // mtbPrice
            // 
            mtbPrice.Enabled = false;
            mtbPrice.HidePromptOnLeave = true;
            mtbPrice.InsertKeyMode = InsertKeyMode.Insert;
            mtbPrice.Location = new Point(153, 129);
            mtbPrice.Mask = "999";
            mtbPrice.Name = "mtbPrice";
            mtbPrice.PromptChar = ' ';
            mtbPrice.Size = new Size(267, 23);
            mtbPrice.TabIndex = 8;
            mtbPrice.TextMaskFormat = MaskFormat.IncludePrompt;
            mtbPrice.ValidatingType = typeof(int);
            // 
            // bClean
            // 
            bClean.Location = new Point(65, 257);
            bClean.Name = "bClean";
            bClean.Size = new Size(75, 23);
            bClean.TabIndex = 11;
            bClean.Text = "Limpiar";
            bClean.UseVisualStyleBackColor = true;
            bClean.Click += bClean_Click;
            // 
            // bSave
            // 
            bSave.Location = new Point(167, 257);
            bSave.Name = "bSave";
            bSave.Size = new Size(75, 23);
            bSave.TabIndex = 12;
            bSave.Text = "Guardar";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(268, 257);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(123, 23);
            bDelete.TabIndex = 13;
            bDelete.Text = "Eliminar producto";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += bDelete_Click;
            // 
            // MainProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 292);
            Controls.Add(bDelete);
            Controls.Add(bSave);
            Controls.Add(bClean);
            Controls.Add(mtbPrice);
            Controls.Add(tbProductName);
            Controls.Add(mtbQuantity);
            Controls.Add(mtbProductCode);
            Controls.Add(lPrice);
            Controls.Add(lQuantity);
            Controls.Add(lProductName);
            Controls.Add(lProductCode);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainProducts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lProductCode;
        private Label lProductName;
        private Label lQuantity;
        private Label lPrice;
        private MaskedTextBox mtbProductCode;
        private MaskedTextBox mtbQuantity;
        private TextBox tbProductName;
        private MaskedTextBox mtbPrice;
        private Button bClean;
        private Button bSave;
        private Button bDelete;
    }
}