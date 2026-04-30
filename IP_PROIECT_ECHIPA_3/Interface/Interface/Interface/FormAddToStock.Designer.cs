
namespace Interface
{
    partial class FormAddToStock
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
            buttonAddToStock = new Button();
            groupBoxUpdateStock = new GroupBox();
            numericUpDownQuantity = new NumericUpDown();
            labelQuantity = new Label();
            labelBarcode = new Label();
            textBoxBarcode = new TextBox();
            groupBoxUpdateStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            SuspendLayout();
            // 
            // buttonAddToStock
            // 
            buttonAddToStock.BackColor = Color.FromArgb(35, 39, 42);
            buttonAddToStock.Cursor = Cursors.Hand;
            buttonAddToStock.FlatStyle = FlatStyle.Flat;
            buttonAddToStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAddToStock.Location = new Point(173, 195);
            buttonAddToStock.Margin = new Padding(3, 4, 3, 4);
            buttonAddToStock.Name = "buttonAddToStock";
            buttonAddToStock.Size = new Size(201, 71);
            buttonAddToStock.TabIndex = 11;
            buttonAddToStock.Text = "Add Stock";
            buttonAddToStock.UseVisualStyleBackColor = false;
            buttonAddToStock.Click += buttonAddToStock_Click;
            // 
            // groupBoxUpdateStock
            // 
            groupBoxUpdateStock.Controls.Add(numericUpDownQuantity);
            groupBoxUpdateStock.Controls.Add(buttonAddToStock);
            groupBoxUpdateStock.Controls.Add(labelQuantity);
            groupBoxUpdateStock.Controls.Add(labelBarcode);
            groupBoxUpdateStock.Controls.Add(textBoxBarcode);
            groupBoxUpdateStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxUpdateStock.ForeColor = Color.FromArgb(153, 170, 181);
            groupBoxUpdateStock.Location = new Point(37, 37);
            groupBoxUpdateStock.Name = "groupBoxUpdateStock";
            groupBoxUpdateStock.Size = new Size(571, 287);
            groupBoxUpdateStock.TabIndex = 13;
            groupBoxUpdateStock.TabStop = false;
            groupBoxUpdateStock.Text = "Add Stock";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.BackColor = Color.FromArgb(35, 39, 42);
            numericUpDownQuantity.BorderStyle = BorderStyle.None;
            numericUpDownQuantity.ForeColor = Color.FromArgb(153, 170, 181);
            numericUpDownQuantity.Location = new Point(224, 135);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(249, 23);
            numericUpDownQuantity.TabIndex = 16;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelQuantity.Location = new Point(83, 130);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(100, 28);
            labelQuantity.TabIndex = 15;
            labelQuantity.Text = "Quantity:";
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelBarcode.Location = new Point(74, 59);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(94, 28);
            labelBarcode.TabIndex = 14;
            labelBarcode.Text = "Barcode:";
            // 
            // textBoxBarcode
            // 
            textBoxBarcode.BackColor = Color.FromArgb(35, 39, 42);
            textBoxBarcode.BorderStyle = BorderStyle.None;
            textBoxBarcode.ForeColor = Color.FromArgb(153, 170, 181);
            textBoxBarcode.Location = new Point(224, 63);
            textBoxBarcode.Margin = new Padding(3, 4, 3, 4);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.Size = new Size(249, 20);
            textBoxBarcode.TabIndex = 13;
            // 
            // FormAddToStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(644, 365);
            Controls.Add(groupBoxUpdateStock);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddToStock";
            Text = "Add to stock";
            groupBoxUpdateStock.ResumeLayout(false);
            groupBoxUpdateStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button buttonAddToStock;
        private System.Windows.Forms.GroupBox groupBoxUpdateStock;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.TextBox textBoxBarcode;
    }
}