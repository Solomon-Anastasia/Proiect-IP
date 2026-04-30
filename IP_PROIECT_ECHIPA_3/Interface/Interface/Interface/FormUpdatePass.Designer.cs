
namespace Interface
{
    partial class FormUpdatePass
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
            textBoxUser = new TextBox();
            textBoxOldPass = new TextBox();
            textBoxNewPass = new TextBox();
            labelUsername = new Label();
            labelOldPass = new Label();
            labelNewPass = new Label();
            buttonUpdate = new Button();
            groupBoxUpdatePass = new GroupBox();
            groupBoxUpdatePass.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxUser
            // 
            textBoxUser.BackColor = Color.FromArgb(35, 39, 42);
            textBoxUser.BorderStyle = BorderStyle.None;
            textBoxUser.Cursor = Cursors.IBeam;
            textBoxUser.ForeColor = Color.FromArgb(153, 170, 181);
            textBoxUser.Location = new Point(226, 71);
            textBoxUser.Margin = new Padding(3, 4, 3, 4);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "username";
            textBoxUser.Size = new Size(253, 27);
            textBoxUser.TabIndex = 0;
            // 
            // textBoxOldPass
            // 
            textBoxOldPass.BackColor = Color.FromArgb(35, 39, 42);
            textBoxOldPass.BorderStyle = BorderStyle.None;
            textBoxOldPass.Cursor = Cursors.IBeam;
            textBoxOldPass.ForeColor = Color.FromArgb(153, 170, 181);
            textBoxOldPass.Location = new Point(224, 123);
            textBoxOldPass.Margin = new Padding(3, 4, 3, 4);
            textBoxOldPass.Name = "textBoxOldPass";
            textBoxOldPass.PlaceholderText = "old password";
            textBoxOldPass.Size = new Size(255, 27);
            textBoxOldPass.TabIndex = 1;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.BackColor = Color.FromArgb(35, 39, 42);
            textBoxNewPass.BorderStyle = BorderStyle.None;
            textBoxNewPass.Cursor = Cursors.IBeam;
            textBoxNewPass.ForeColor = Color.FromArgb(153, 170, 181);
            textBoxNewPass.Location = new Point(224, 176);
            textBoxNewPass.Margin = new Padding(3, 4, 3, 4);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.PlaceholderText = "new password";
            textBoxNewPass.Size = new Size(255, 27);
            textBoxNewPass.TabIndex = 2;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUsername.Location = new Point(53, 69);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(111, 28);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username:";
            // 
            // labelOldPass
            // 
            labelOldPass.AutoSize = true;
            labelOldPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelOldPass.Location = new Point(53, 123);
            labelOldPass.Name = "labelOldPass";
            labelOldPass.Size = new Size(145, 28);
            labelOldPass.TabIndex = 4;
            labelOldPass.Text = "Old Password:";
            // 
            // labelNewPass
            // 
            labelNewPass.AutoSize = true;
            labelNewPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNewPass.Location = new Point(53, 175);
            labelNewPass.Name = "labelNewPass";
            labelNewPass.Size = new Size(155, 28);
            labelNewPass.TabIndex = 5;
            labelNewPass.Text = "New Password:";
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(35, 39, 42);
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.FromArgb(153, 170, 181);
            buttonUpdate.Location = new Point(118, 235);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(315, 71);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // groupBoxUpdatePass
            // 
            groupBoxUpdatePass.Controls.Add(labelUsername);
            groupBoxUpdatePass.Controls.Add(buttonUpdate);
            groupBoxUpdatePass.Controls.Add(textBoxUser);
            groupBoxUpdatePass.Controls.Add(labelNewPass);
            groupBoxUpdatePass.Controls.Add(textBoxOldPass);
            groupBoxUpdatePass.Controls.Add(labelOldPass);
            groupBoxUpdatePass.Controls.Add(textBoxNewPass);
            groupBoxUpdatePass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxUpdatePass.ForeColor = Color.FromArgb(153, 170, 181);
            groupBoxUpdatePass.Location = new Point(29, 35);
            groupBoxUpdatePass.Name = "groupBoxUpdatePass";
            groupBoxUpdatePass.Size = new Size(549, 360);
            groupBoxUpdatePass.TabIndex = 7;
            groupBoxUpdatePass.TabStop = false;
            groupBoxUpdatePass.Text = "Update Password";
            // 
            // FormUpdatePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(607, 433);
            Controls.Add(groupBoxUpdatePass);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormUpdatePass";
            Text = "Update Password";
            groupBoxUpdatePass.ResumeLayout(false);
            groupBoxUpdatePass.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelOldPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBoxUpdatePass;
    }
}