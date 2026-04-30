namespace Interface
{
    partial class FormLogIn
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
            label2 = new Label();
            label3 = new Label();
            textBoxUser = new TextBox();
            textBoxPass = new TextBox();
            login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(153, 170, 181);
            label1.Location = new Point(305, 126);
            label1.Name = "label1";
            label1.Size = new Size(245, 50);
            label1.TabIndex = 0;
            label1.Text = "Authenticate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(153, 170, 181);
            label2.Location = new Point(377, 215);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(153, 170, 181);
            label3.Location = new Point(383, 277);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // textBoxUser
            // 
            textBoxUser.BackColor = Color.FromArgb(35, 39, 42);
            textBoxUser.BorderStyle = BorderStyle.FixedSingle;
            textBoxUser.ForeColor = Color.FromArgb(153, 170, 181);
            textBoxUser.Location = new Point(291, 247);
            textBoxUser.Margin = new Padding(3, 4, 3, 4);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "Username";
            textBoxUser.Size = new Size(273, 27);
            textBoxUser.TabIndex = 3;
            // 
            // textBoxPass
            // 
            textBoxPass.BackColor = Color.FromArgb(35, 39, 42);
            textBoxPass.BorderStyle = BorderStyle.FixedSingle;
            textBoxPass.ForeColor = Color.FromArgb(153, 170, 181);
            textBoxPass.Location = new Point(291, 309);
            textBoxPass.Margin = new Padding(3, 4, 3, 4);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PlaceholderText = "Password";
            textBoxPass.Size = new Size(273, 27);
            textBoxPass.TabIndex = 4;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(35, 39, 42);
            login.Cursor = Cursors.Hand;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI", 14F);
            login.ForeColor = Color.FromArgb(153, 170, 181);
            login.Location = new Point(357, 379);
            login.Margin = new Padding(3, 4, 3, 4);
            login.Name = "login";
            login.Size = new Size(123, 55);
            login.TabIndex = 5;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(865, 539);
            Controls.Add(login);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogIn";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUser;
        private TextBox textBoxPass;
        private Button login;
    }
}
