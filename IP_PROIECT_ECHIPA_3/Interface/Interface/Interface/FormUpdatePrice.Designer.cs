
namespace Interface
{
    partial class FormUpdatePrice
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
            groupBoxUpdatePrice = new GroupBox();
            buttonUpdatePrice = new Button();
            labelBarcode = new Label();
            labelNewPrice = new Label();
            numericUpDownNewPrice = new NumericUpDown();
            textBoxBarcode = new TextBox();
            groupBoxUpdatePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewPrice).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUpdatePrice
            // 
            groupBoxUpdatePrice.Controls.Add(buttonUpdatePrice);
            groupBoxUpdatePrice.Controls.Add(labelBarcode);
            groupBoxUpdatePrice.Controls.Add(labelNewPrice);
            groupBoxUpdatePrice.Controls.Add(numericUpDownNewPrice);
            groupBoxUpdatePrice.Controls.Add(textBoxBarcode);
            groupBoxUpdatePrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxUpdatePrice.ForeColor = Color.FromArgb(153, 170, 181);
            groupBoxUpdatePrice.Location = new Point(57, 12);
            groupBoxUpdatePrice.Name = "groupBoxUpdatePrice";
            groupBoxUpdatePrice.Size = new Size(562, 301);
            groupBoxUpdatePrice.TabIndex = 4;
            groupBoxUpdatePrice.TabStop = false;
            groupBoxUpdatePrice.Text = "Update Part Price";
            // 
            // buttonUpdatePrice
            // 
            buttonUpdatePrice.BackColor = Color.FromArgb(35, 39, 42);
            buttonUpdatePrice.Cursor = Cursors.Hand;
            buttonUpdatePrice.FlatStyle = FlatStyle.Flat;
            buttonUpdatePrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonUpdatePrice.ForeColor = Color.FromArgb(153, 170, 181);
            buttonUpdatePrice.Location = new Point(162, 185);
            buttonUpdatePrice.Name = "buttonUpdatePrice";
            buttonUpdatePrice.Size = new Size(231, 89);
            buttonUpdatePrice.TabIndex = 5;
            buttonUpdatePrice.Text = "Update";
            buttonUpdatePrice.UseVisualStyleBackColor = false;
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelBarcode.Location = new Point(73, 65);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(94, 28);
            labelBarcode.TabIndex = 7;
            labelBarcode.Text = "Barcode:";
            // 
            // labelNewPrice
            // 
            labelNewPrice.AutoSize = true;
            labelNewPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNewPrice.Location = new Point(73, 123);
            labelNewPrice.Name = "labelNewPrice";
            labelNewPrice.Size = new Size(113, 28);
            labelNewPrice.TabIndex = 6;
            labelNewPrice.Text = "New Price:";
            // 
            // numericUpDownNewPrice
            // 
            numericUpDownNewPrice.BackColor = Color.FromArgb(35, 39, 42);
            numericUpDownNewPrice.BorderStyle = BorderStyle.None;
            numericUpDownNewPrice.DecimalPlaces = 2;
            numericUpDownNewPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            numericUpDownNewPrice.ForeColor = Color.FromArgb(153, 170, 181);
            numericUpDownNewPrice.Location = new Point(221, 124);
            numericUpDownNewPrice.Name = "numericUpDownNewPrice";
            numericUpDownNewPrice.Size = new Size(255, 30);
            numericUpDownNewPrice.TabIndex = 5;
            // 
            // textBoxBarcode
            // 
            textBoxBarcode.BackColor = Color.FromArgb(35, 39, 42);
            textBoxBarcode.BorderStyle = BorderStyle.None;
            textBoxBarcode.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxBarcode.ForeColor = Color.FromArgb(153, 170, 181);
            textBoxBarcode.Location = new Point(221, 65);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.PlaceholderText = "123...";
            textBoxBarcode.Size = new Size(255, 27);
            textBoxBarcode.TabIndex = 4;
            // 
            // FormUpdatePrice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(667, 336);
            Controls.Add(groupBoxUpdatePrice);
            Name = "FormUpdatePrice";
            Text = "Update Price";
            groupBoxUpdatePrice.ResumeLayout(false);
            groupBoxUpdatePrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewPrice).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxUpdatePrice;
        private System.Windows.Forms.Button buttonUpdatePrice;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.Label labelNewPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownNewPrice;
        private System.Windows.Forms.TextBox textBoxBarcode;
    }
}