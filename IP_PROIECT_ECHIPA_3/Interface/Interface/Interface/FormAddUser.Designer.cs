
namespace Interface
{
    partial class FormAddUser
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
            buttonAddNewUser = new Button();
            groupBoxAddUser = new GroupBox();
            labelNewUserOccupation = new Label();
            labelNewUserPass = new Label();
            labelNewUserName = new Label();
            textBoxNewUserOccupation = new TextBox();
            textBoxNewUserPassword = new TextBox();
            textBoxNewUserName = new TextBox();
            groupBoxAddUser.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddNewUser
            // 
            buttonAddNewUser.BackColor = Color.FromArgb(35, 39, 42);
            buttonAddNewUser.Cursor = Cursors.Hand;
            buttonAddNewUser.FlatStyle = FlatStyle.Flat;
            buttonAddNewUser.Location = new Point(221, 205);
            buttonAddNewUser.Name = "buttonAddNewUser";
            buttonAddNewUser.Size = new Size(242, 75);
            buttonAddNewUser.TabIndex = 6;
            buttonAddNewUser.Text = "Add";
            buttonAddNewUser.UseVisualStyleBackColor = false;
            // 
            // groupBoxAddUser
            // 
            groupBoxAddUser.Controls.Add(labelNewUserOccupation);
            groupBoxAddUser.Controls.Add(buttonAddNewUser);
            groupBoxAddUser.Controls.Add(labelNewUserPass);
            groupBoxAddUser.Controls.Add(labelNewUserName);
            groupBoxAddUser.Controls.Add(textBoxNewUserOccupation);
            groupBoxAddUser.Controls.Add(textBoxNewUserPassword);
            groupBoxAddUser.Controls.Add(textBoxNewUserName);
            groupBoxAddUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxAddUser.ForeColor = Color.FromArgb(153, 170, 181);
            groupBoxAddUser.Location = new Point(48, 32);
            groupBoxAddUser.Name = "groupBoxAddUser";
            groupBoxAddUser.Size = new Size(718, 327);
            groupBoxAddUser.TabIndex = 7;
            groupBoxAddUser.TabStop = false;
            groupBoxAddUser.Text = "Add New User";
            // 
            // labelNewUserOccupation
            // 
            labelNewUserOccupation.AutoSize = true;
            labelNewUserOccupation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNewUserOccupation.Location = new Point(497, 65);
            labelNewUserOccupation.Name = "labelNewUserOccupation";
            labelNewUserOccupation.Size = new Size(112, 28);
            labelNewUserOccupation.TabIndex = 11;
            labelNewUserOccupation.Text = "Role Code:";
            // 
            // labelNewUserPass
            // 
            labelNewUserPass.AutoSize = true;
            labelNewUserPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNewUserPass.Location = new Point(33, 125);
            labelNewUserPass.Name = "labelNewUserPass";
            labelNewUserPass.Size = new Size(106, 28);
            labelNewUserPass.TabIndex = 10;
            labelNewUserPass.Text = "Password:";
            // 
            // labelNewUserName
            // 
            labelNewUserName.AutoSize = true;
            labelNewUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNewUserName.Location = new Point(33, 67);
            labelNewUserName.Name = "labelNewUserName";
            labelNewUserName.Size = new Size(111, 28);
            labelNewUserName.TabIndex = 9;
            labelNewUserName.Text = "Username:";
            // 
            // textBoxNewUserOccupation
            // 
            textBoxNewUserOccupation.BackColor = Color.FromArgb(35, 39, 42);
            textBoxNewUserOccupation.BorderStyle = BorderStyle.None;
            textBoxNewUserOccupation.Cursor = Cursors.IBeam;
            textBoxNewUserOccupation.ForeColor = Color.FromArgb(153, 170, 181);
            textBoxNewUserOccupation.Location = new Point(502, 125);
            textBoxNewUserOccupation.Name = "textBoxNewUserOccupation";
            textBoxNewUserOccupation.Size = new Size(134, 27);
            textBoxNewUserOccupation.TabIndex = 8;
            // 
            // textBoxNewUserPassword
            // 
            textBoxNewUserPassword.BackColor = Color.FromArgb(35, 39, 42);
            textBoxNewUserPassword.BorderStyle = BorderStyle.None;
            textBoxNewUserPassword.Cursor = Cursors.IBeam;
            textBoxNewUserPassword.ForeColor = Color.FromArgb(153, 170, 181);
            textBoxNewUserPassword.Location = new Point(235, 125);
            textBoxNewUserPassword.Name = "textBoxNewUserPassword";
            textBoxNewUserPassword.Size = new Size(203, 27);
            textBoxNewUserPassword.TabIndex = 7;
            // 
            // textBoxNewUserName
            // 
            textBoxNewUserName.BackColor = Color.FromArgb(35, 39, 42);
            textBoxNewUserName.BorderStyle = BorderStyle.None;
            textBoxNewUserName.Cursor = Cursors.IBeam;
            textBoxNewUserName.ForeColor = Color.FromArgb(153, 170, 181);
            textBoxNewUserName.Location = new Point(235, 68);
            textBoxNewUserName.Name = "textBoxNewUserName";
            textBoxNewUserName.Size = new Size(203, 27);
            textBoxNewUserName.TabIndex = 6;
            // 
            // FormAddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(800, 391);
            Controls.Add(groupBoxAddUser);
            Name = "FormAddUser";
            Text = "Add user";
            groupBoxAddUser.ResumeLayout(false);
            groupBoxAddUser.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.GroupBox groupBoxAddUser;
        private System.Windows.Forms.Label labelNewUserOccupation;
        private System.Windows.Forms.Label labelNewUserPass;
        private System.Windows.Forms.Label labelNewUserName;
        private System.Windows.Forms.TextBox textBoxNewUserOccupation;
        private System.Windows.Forms.TextBox textBoxNewUserPassword;
        private System.Windows.Forms.TextBox textBoxNewUserName;
    }
}