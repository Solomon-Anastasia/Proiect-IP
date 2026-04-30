
namespace Interface
{
    partial class FormDeleteUser
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
            buttonDelete = new Button();
            groupBoxDeleteUser = new GroupBox();
            labelNewUserName = new Label();
            textBoxDeletedUsername = new TextBox();
            groupBoxDeleteUser.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(183, 21, 64);
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.Black;
            buttonDelete.Location = new Point(155, 205);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(266, 67);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete User!";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // groupBoxDeleteUser
            // 
            groupBoxDeleteUser.Controls.Add(labelNewUserName);
            groupBoxDeleteUser.Controls.Add(buttonDelete);
            groupBoxDeleteUser.Controls.Add(textBoxDeletedUsername);
            groupBoxDeleteUser.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBoxDeleteUser.ForeColor = Color.FromArgb(153, 170, 181);
            groupBoxDeleteUser.Location = new Point(31, 32);
            groupBoxDeleteUser.Name = "groupBoxDeleteUser";
            groupBoxDeleteUser.Size = new Size(582, 299);
            groupBoxDeleteUser.TabIndex = 6;
            groupBoxDeleteUser.TabStop = false;
            groupBoxDeleteUser.Text = "Delete User Account";
            // 
            // labelNewUserName
            // 
            labelNewUserName.AutoSize = true;
            labelNewUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelNewUserName.ForeColor = Color.FromArgb(153, 170, 181);
            labelNewUserName.Location = new Point(102, 120);
            labelNewUserName.Name = "labelNewUserName";
            labelNewUserName.Size = new Size(94, 23);
            labelNewUserName.TabIndex = 6;
            labelNewUserName.Text = "Username:";
            // 
            // textBoxDeletedUsername
            // 
            textBoxDeletedUsername.BackColor = Color.FromArgb(35, 39, 42);
            textBoxDeletedUsername.BorderStyle = BorderStyle.None;
            textBoxDeletedUsername.Cursor = Cursors.IBeam;
            textBoxDeletedUsername.ForeColor = Color.FromArgb(153, 170, 181);
            textBoxDeletedUsername.Location = new Point(266, 109);
            textBoxDeletedUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxDeletedUsername.Name = "textBoxDeletedUsername";
            textBoxDeletedUsername.Size = new Size(234, 34);
            textBoxDeletedUsername.TabIndex = 5;
            // 
            // FormDeleteUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(650, 368);
            Controls.Add(groupBoxDeleteUser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDeleteUser";
            Text = "Delete user";
            groupBoxDeleteUser.ResumeLayout(false);
            groupBoxDeleteUser.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxDeleteUser;
        private System.Windows.Forms.Label labelNewUserName;
        private System.Windows.Forms.TextBox textBoxDeletedUsername;
    }
}