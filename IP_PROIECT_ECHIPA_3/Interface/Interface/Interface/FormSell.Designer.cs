
namespace Interface
{
    partial class FormSell
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
            buttonSell = new Button();
            labelQuantity = new Label();
            labelBarcode = new Label();
            textBoxBarcode = new TextBox();
            numericUpDownQuantity = new NumericUpDown();
            groupBoxSell = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            groupBoxSell.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSell
            // 
            buttonSell.BackColor = Color.FromArgb(35, 39, 42);
            buttonSell.FlatStyle = FlatStyle.Flat;
            buttonSell.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSell.ForeColor = Color.FromArgb(153, 170, 181);
            buttonSell.Location = new Point(208, 223);
            buttonSell.Margin = new Padding(3, 4, 3, 4);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(198, 64);
            buttonSell.TabIndex = 16;
            buttonSell.Text = "Sell";
            buttonSell.UseVisualStyleBackColor = false;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelQuantity.ForeColor = Color.FromArgb(153, 170, 181);
            labelQuantity.Location = new Point(133, 152);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(100, 28);
            labelQuantity.TabIndex = 15;
            labelQuantity.Text = "Quantity:";
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelBarcode.ForeColor = Color.FromArgb(153, 170, 181);
            labelBarcode.Location = new Point(133, 84);
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
            textBoxBarcode.Location = new Point(251, 85);
            textBoxBarcode.Margin = new Padding(3, 4, 3, 4);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.Size = new Size(249, 27);
            textBoxBarcode.TabIndex = 12;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.BackColor = Color.FromArgb(35, 39, 42);
            numericUpDownQuantity.BorderStyle = BorderStyle.None;
            numericUpDownQuantity.ForeColor = Color.FromArgb(153, 170, 181);
            numericUpDownQuantity.Location = new Point(251, 153);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(249, 30);
            numericUpDownQuantity.TabIndex = 17;
            // 
            // groupBoxSell
            // 
            groupBoxSell.Controls.Add(labelBarcode);
            groupBoxSell.Controls.Add(buttonSell);
            groupBoxSell.Controls.Add(numericUpDownQuantity);
            groupBoxSell.Controls.Add(textBoxBarcode);
            groupBoxSell.Controls.Add(labelQuantity);
            groupBoxSell.FlatStyle = FlatStyle.Flat;
            groupBoxSell.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxSell.ForeColor = Color.FromArgb(153, 170, 181);
            groupBoxSell.Location = new Point(40, 27);
            groupBoxSell.Name = "groupBoxSell";
            groupBoxSell.Size = new Size(635, 313);
            groupBoxSell.TabIndex = 18;
            groupBoxSell.TabStop = false;
            groupBoxSell.Text = "Sell Part";
            // 
            // FormSell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(712, 379);
            Controls.Add(groupBoxSell);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSell";
            Text = "Sell Part";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            groupBoxSell.ResumeLayout(false);
            groupBoxSell.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.GroupBox groupBoxSell;
    }
}