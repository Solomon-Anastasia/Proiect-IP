
namespace Interface
{
    partial class FormAddProduct
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
            buttonAddProduct = new Button();
            groupBoxAddProduct = new GroupBox();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownStock = new NumericUpDown();
            textBoxBarcode = new TextBox();
            labelInitialStock = new Label();
            labelPrice = new Label();
            labelBarcode = new Label();
            comboBoxCategory = new ComboBox();
            labelBrand = new Label();
            labelNewPart = new Label();
            comboBoxProduct = new ComboBox();
            groupBoxAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.BackColor = Color.FromArgb(35, 39, 42);
            buttonAddProduct.Cursor = Cursors.Hand;
            buttonAddProduct.FlatAppearance.BorderSize = 0;
            buttonAddProduct.FlatStyle = FlatStyle.Flat;
            buttonAddProduct.Location = new Point(191, 346);
            buttonAddProduct.Margin = new Padding(3, 2, 3, 2);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(301, 62);
            buttonAddProduct.TabIndex = 7;
            buttonAddProduct.Text = "Add Part!";
            buttonAddProduct.UseVisualStyleBackColor = false;
            // 
            // groupBoxAddProduct
            // 
            groupBoxAddProduct.Controls.Add(numericUpDownPrice);
            groupBoxAddProduct.Controls.Add(buttonAddProduct);
            groupBoxAddProduct.Controls.Add(numericUpDownStock);
            groupBoxAddProduct.Controls.Add(textBoxBarcode);
            groupBoxAddProduct.Controls.Add(labelInitialStock);
            groupBoxAddProduct.Controls.Add(labelPrice);
            groupBoxAddProduct.Controls.Add(labelBarcode);
            groupBoxAddProduct.Controls.Add(comboBoxCategory);
            groupBoxAddProduct.Controls.Add(labelBrand);
            groupBoxAddProduct.Controls.Add(labelNewPart);
            groupBoxAddProduct.Controls.Add(comboBoxProduct);
            groupBoxAddProduct.FlatStyle = FlatStyle.Flat;
            groupBoxAddProduct.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxAddProduct.ForeColor = Color.FromArgb(153, 170, 181);
            groupBoxAddProduct.Location = new Point(44, 29);
            groupBoxAddProduct.Margin = new Padding(3, 2, 3, 2);
            groupBoxAddProduct.Name = "groupBoxAddProduct";
            groupBoxAddProduct.Padding = new Padding(3, 2, 3, 2);
            groupBoxAddProduct.Size = new Size(718, 478);
            groupBoxAddProduct.TabIndex = 18;
            groupBoxAddProduct.TabStop = false;
            groupBoxAddProduct.Text = "New Part";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.BackColor = Color.FromArgb(35, 39, 42);
            numericUpDownPrice.BorderStyle = BorderStyle.None;
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.ForeColor = Color.FromArgb(153, 170, 181);
            numericUpDownPrice.Location = new Point(433, 158);
            numericUpDownPrice.Margin = new Padding(3, 2, 3, 2);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(250, 37);
            numericUpDownPrice.TabIndex = 39;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.BackColor = Color.FromArgb(35, 39, 42);
            numericUpDownStock.BorderStyle = BorderStyle.None;
            numericUpDownStock.ForeColor = Color.FromArgb(153, 170, 181);
            numericUpDownStock.Location = new Point(182, 158);
            numericUpDownStock.Margin = new Padding(3, 2, 3, 2);
            numericUpDownStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(145, 37);
            numericUpDownStock.TabIndex = 38;
            // 
            // textBoxBarcode
            // 
            textBoxBarcode.BackColor = Color.FromArgb(35, 39, 42);
            textBoxBarcode.BorderStyle = BorderStyle.None;
            textBoxBarcode.Cursor = Cursors.IBeam;
            textBoxBarcode.ForeColor = Color.FromArgb(153, 170, 181);
            textBoxBarcode.Location = new Point(182, 89);
            textBoxBarcode.Margin = new Padding(3, 2, 3, 2);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.PlaceholderText = "123..";
            textBoxBarcode.Size = new Size(145, 34);
            textBoxBarcode.TabIndex = 37;
            // 
            // labelInitialStock
            // 
            labelInitialStock.AutoSize = true;
            labelInitialStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelInitialStock.Location = new Point(43, 165);
            labelInitialStock.Name = "labelInitialStock";
            labelInitialStock.Size = new Size(131, 28);
            labelInitialStock.TabIndex = 36;
            labelInitialStock.Text = "Initial Stock:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPrice.Location = new Point(343, 165);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(70, 28);
            labelPrice.TabIndex = 35;
            labelPrice.Text = "Price :";
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBarcode.Location = new Point(43, 95);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(100, 28);
            labelBarcode.TabIndex = 34;
            labelBarcode.Text = "Barcode: ";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.FromArgb(35, 39, 42);
            comboBoxCategory.Cursor = Cursors.Hand;
            comboBoxCategory.FlatStyle = FlatStyle.Flat;
            comboBoxCategory.ForeColor = Color.FromArgb(153, 170, 181);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(431, 86);
            comboBoxCategory.Margin = new Padding(3, 2, 3, 2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(252, 43);
            comboBoxCategory.TabIndex = 33;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelBrand.Location = new Point(343, 95);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(73, 28);
            labelBrand.TabIndex = 32;
            labelBrand.Text = "Brand:";
            // 
            // labelNewPart
            // 
            labelNewPart.AutoSize = true;
            labelNewPart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNewPart.Location = new Point(43, 224);
            labelNewPart.Name = "labelNewPart";
            labelNewPart.Size = new Size(63, 28);
            labelNewPart.TabIndex = 31;
            labelNewPart.Text = "Part :";
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.BackColor = Color.FromArgb(35, 39, 42);
            comboBoxProduct.FlatStyle = FlatStyle.Flat;
            comboBoxProduct.ForeColor = Color.FromArgb(153, 170, 181);
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(182, 216);
            comboBoxProduct.Margin = new Padding(3, 2, 3, 2);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(501, 43);
            comboBoxProduct.TabIndex = 30;
            // 
            // FormAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(800, 562);
            Controls.Add(groupBoxAddProduct);
            ForeColor = Color.FromArgb(153, 170, 181);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddProduct";
            Text = "Add new part";
            groupBoxAddProduct.ResumeLayout(false);
            groupBoxAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label labelInitialStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelNewPart;
        private System.Windows.Forms.ComboBox comboBoxProduct;
    }
}