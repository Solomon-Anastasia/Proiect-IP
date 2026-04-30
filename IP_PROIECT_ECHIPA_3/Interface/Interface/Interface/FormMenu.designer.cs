
namespace Interface
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            dataGridViewDBInfo = new DataGridView();
            groupBoxRootAccess = new GroupBox();
            buttonDeleteUser = new Button();
            buttonPassUpdate = new Button();
            buttonAddUser = new Button();
            buttonUsersList = new Button();
            groupBoxEmployeeAccess = new GroupBox();
            buttonUpdateProductPrice = new Button();
            buttonAddNewPart = new Button();
            buttonSellPart = new Button();
            buttonPartList = new Button();
            buttonAddStock = new Button();
            groupBoxLogin = new GroupBox();
            buttonHelp = new Button();
            labelAuthenticatedUser = new Label();
            buttonLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDBInfo).BeginInit();
            groupBoxRootAccess.SuspendLayout();
            groupBoxEmployeeAccess.SuspendLayout();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewDBInfo
            // 
            dataGridViewDBInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDBInfo.GridColor = SystemColors.ButtonFace;
            dataGridViewDBInfo.Location = new Point(26, 123);
            dataGridViewDBInfo.Margin = new Padding(3, 4, 3, 4);
            dataGridViewDBInfo.Name = "dataGridViewDBInfo";
            dataGridViewDBInfo.RowHeadersWidth = 51;
            dataGridViewDBInfo.RowTemplate.Height = 24;
            dataGridViewDBInfo.Size = new Size(816, 392);
            dataGridViewDBInfo.TabIndex = 14;
            // 
            // groupBoxRootAccess
            // 
            groupBoxRootAccess.Controls.Add(buttonDeleteUser);
            groupBoxRootAccess.Controls.Add(buttonPassUpdate);
            groupBoxRootAccess.Controls.Add(buttonAddUser);
            groupBoxRootAccess.Controls.Add(buttonUsersList);
            groupBoxRootAccess.Location = new Point(353, 12);
            groupBoxRootAccess.Name = "groupBoxRootAccess";
            groupBoxRootAccess.Size = new Size(671, 97);
            groupBoxRootAccess.TabIndex = 16;
            groupBoxRootAccess.TabStop = false;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.BackColor = Color.FromArgb(35, 39, 42);
            buttonDeleteUser.Cursor = Cursors.Hand;
            buttonDeleteUser.FlatStyle = FlatStyle.Flat;
            buttonDeleteUser.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            buttonDeleteUser.ForeColor = Color.FromArgb(153, 170, 181);
            buttonDeleteUser.Image = (Image)resources.GetObject("buttonDeleteUser.Image");
            buttonDeleteUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDeleteUser.Location = new Point(341, 24);
            buttonDeleteUser.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Padding = new Padding(10);
            buttonDeleteUser.Size = new Size(130, 58);
            buttonDeleteUser.TabIndex = 16;
            buttonDeleteUser.Text = "Delete User";
            buttonDeleteUser.TextAlign = ContentAlignment.MiddleRight;
            buttonDeleteUser.UseVisualStyleBackColor = false;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // buttonPassUpdate
            // 
            buttonPassUpdate.BackColor = Color.FromArgb(35, 39, 42);
            buttonPassUpdate.Cursor = Cursors.Hand;
            buttonPassUpdate.FlatStyle = FlatStyle.Flat;
            buttonPassUpdate.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            buttonPassUpdate.ForeColor = Color.FromArgb(153, 170, 181);
            buttonPassUpdate.Image = (Image)resources.GetObject("buttonPassUpdate.Image");
            buttonPassUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPassUpdate.Location = new Point(487, 24);
            buttonPassUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonPassUpdate.Name = "buttonPassUpdate";
            buttonPassUpdate.Padding = new Padding(10);
            buttonPassUpdate.Size = new Size(165, 58);
            buttonPassUpdate.TabIndex = 14;
            buttonPassUpdate.Text = "Update Password";
            buttonPassUpdate.TextAlign = ContentAlignment.MiddleRight;
            buttonPassUpdate.UseVisualStyleBackColor = false;
            buttonPassUpdate.Click += buttonPassUpdate_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = Color.FromArgb(35, 39, 42);
            buttonAddUser.Cursor = Cursors.Hand;
            buttonAddUser.FlatStyle = FlatStyle.Flat;
            buttonAddUser.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            buttonAddUser.ForeColor = Color.FromArgb(153, 170, 181);
            buttonAddUser.Image = (Image)resources.GetObject("buttonAddUser.Image");
            buttonAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new Point(23, 24);
            buttonAddUser.Margin = new Padding(4, 3, 4, 3);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Padding = new Padding(10);
            buttonAddUser.Size = new Size(123, 58);
            buttonAddUser.TabIndex = 13;
            buttonAddUser.Text = "Add User";
            buttonAddUser.TextAlign = ContentAlignment.MiddleRight;
            buttonAddUser.UseVisualStyleBackColor = false;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // buttonUsersList
            // 
            buttonUsersList.BackColor = Color.FromArgb(35, 39, 42);
            buttonUsersList.Cursor = Cursors.Hand;
            buttonUsersList.FlatStyle = FlatStyle.Flat;
            buttonUsersList.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            buttonUsersList.ForeColor = Color.FromArgb(153, 170, 181);
            buttonUsersList.Image = (Image)resources.GetObject("buttonUsersList.Image");
            buttonUsersList.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsersList.Location = new Point(163, 24);
            buttonUsersList.Margin = new Padding(3, 4, 3, 4);
            buttonUsersList.Name = "buttonUsersList";
            buttonUsersList.Padding = new Padding(10);
            buttonUsersList.Size = new Size(163, 58);
            buttonUsersList.TabIndex = 15;
            buttonUsersList.Text = "Refresh User List";
            buttonUsersList.TextAlign = ContentAlignment.MiddleRight;
            buttonUsersList.UseVisualStyleBackColor = false;
            buttonUsersList.Click += buttonUsersList_Click;
            // 
            // groupBoxEmployeeAccess
            // 
            groupBoxEmployeeAccess.Controls.Add(buttonUpdateProductPrice);
            groupBoxEmployeeAccess.Controls.Add(buttonPartList);
            groupBoxEmployeeAccess.Controls.Add(buttonSellPart);
            groupBoxEmployeeAccess.Controls.Add(buttonAddStock);
            groupBoxEmployeeAccess.Controls.Add(buttonAddNewPart);
            groupBoxEmployeeAccess.Location = new Point(864, 114);
            groupBoxEmployeeAccess.Name = "groupBoxEmployeeAccess";
            groupBoxEmployeeAccess.Size = new Size(160, 403);
            groupBoxEmployeeAccess.TabIndex = 17;
            groupBoxEmployeeAccess.TabStop = false;
            // 
            // buttonUpdateProductPrice
            // 
            buttonUpdateProductPrice.BackColor = Color.FromArgb(35, 39, 42);
            buttonUpdateProductPrice.FlatStyle = FlatStyle.Flat;
            buttonUpdateProductPrice.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            buttonUpdateProductPrice.ForeColor = Color.FromArgb(153, 170, 181);
            buttonUpdateProductPrice.Image = (Image)resources.GetObject("buttonUpdateProductPrice.Image");
            buttonUpdateProductPrice.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpdateProductPrice.Location = new Point(13, 327);
            buttonUpdateProductPrice.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateProductPrice.Name = "buttonUpdateProductPrice";
            buttonUpdateProductPrice.Padding = new Padding(10);
            buttonUpdateProductPrice.Size = new Size(136, 58);
            buttonUpdateProductPrice.TabIndex = 25;
            buttonUpdateProductPrice.Text = "Update Price";
            buttonUpdateProductPrice.TextAlign = ContentAlignment.MiddleRight;
            buttonUpdateProductPrice.UseVisualStyleBackColor = false;
            buttonUpdateProductPrice.Click += buttonUpdateProductPrice_Click;
            // 
            // buttonAddNewPart
            // 
            buttonAddNewPart.BackColor = Color.FromArgb(35, 39, 42);
            buttonAddNewPart.Cursor = Cursors.Hand;
            buttonAddNewPart.FlatStyle = FlatStyle.Flat;
            buttonAddNewPart.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            buttonAddNewPart.ForeColor = Color.FromArgb(153, 170, 181);
            buttonAddNewPart.Image = (Image)resources.GetObject("buttonAddNewPart.Image");
            buttonAddNewPart.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddNewPart.Location = new Point(13, 179);
            buttonAddNewPart.Margin = new Padding(3, 4, 3, 4);
            buttonAddNewPart.Name = "buttonAddNewPart";
            buttonAddNewPart.Padding = new Padding(10, 10, 30, 10);
            buttonAddNewPart.Size = new Size(136, 58);
            buttonAddNewPart.TabIndex = 24;
            buttonAddNewPart.Text = "Add Part";
            buttonAddNewPart.TextAlign = ContentAlignment.MiddleRight;
            buttonAddNewPart.UseVisualStyleBackColor = false;
            buttonAddNewPart.Click += buttonAddNewProduct_Click;
            // 
            // buttonSellPart
            // 
            buttonSellPart.BackColor = Color.FromArgb(35, 39, 42);
            buttonSellPart.Cursor = Cursors.Hand;
            buttonSellPart.FlatStyle = FlatStyle.Flat;
            buttonSellPart.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            buttonSellPart.ForeColor = Color.FromArgb(153, 170, 181);
            buttonSellPart.Image = (Image)resources.GetObject("buttonSellPart.Image");
            buttonSellPart.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSellPart.Location = new Point(13, 103);
            buttonSellPart.Margin = new Padding(3, 4, 3, 4);
            buttonSellPart.Name = "buttonSellPart";
            buttonSellPart.Padding = new Padding(10, 10, 30, 10);
            buttonSellPart.Size = new Size(136, 58);
            buttonSellPart.TabIndex = 23;
            buttonSellPart.Text = "Sell Part";
            buttonSellPart.TextAlign = ContentAlignment.MiddleRight;
            buttonSellPart.UseVisualStyleBackColor = false;
            buttonSellPart.Click += buttonSellProduct_Click;
            // 
            // buttonPartList
            // 
            buttonPartList.BackColor = Color.FromArgb(35, 39, 42);
            buttonPartList.Cursor = Cursors.Hand;
            buttonPartList.FlatStyle = FlatStyle.Flat;
            buttonPartList.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            buttonPartList.ForeColor = Color.FromArgb(153, 170, 181);
            buttonPartList.Image = (Image)resources.GetObject("buttonPartList.Image");
            buttonPartList.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPartList.Location = new Point(13, 25);
            buttonPartList.Margin = new Padding(3, 4, 3, 4);
            buttonPartList.Name = "buttonPartList";
            buttonPartList.Padding = new Padding(10);
            buttonPartList.Size = new Size(136, 58);
            buttonPartList.TabIndex = 22;
            buttonPartList.Text = "Refresh Parts";
            buttonPartList.TextAlign = ContentAlignment.MiddleRight;
            buttonPartList.UseVisualStyleBackColor = false;
            buttonPartList.Click += buttonProductList_Click;
            // 
            // buttonAddStock
            // 
            buttonAddStock.BackColor = Color.FromArgb(35, 39, 42);
            buttonAddStock.Cursor = Cursors.Hand;
            buttonAddStock.FlatStyle = FlatStyle.Flat;
            buttonAddStock.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            buttonAddStock.ForeColor = Color.FromArgb(153, 170, 181);
            buttonAddStock.Image = (Image)resources.GetObject("buttonAddStock.Image");
            buttonAddStock.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddStock.Location = new Point(13, 251);
            buttonAddStock.Margin = new Padding(3, 4, 3, 4);
            buttonAddStock.Name = "buttonAddStock";
            buttonAddStock.Padding = new Padding(10, 10, 20, 10);
            buttonAddStock.Size = new Size(136, 58);
            buttonAddStock.TabIndex = 21;
            buttonAddStock.Text = "Add stock";
            buttonAddStock.TextAlign = ContentAlignment.MiddleRight;
            buttonAddStock.UseVisualStyleBackColor = false;
            buttonAddStock.Click += buttonAddStock_Click;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(buttonHelp);
            groupBoxLogin.Controls.Add(labelAuthenticatedUser);
            groupBoxLogin.Controls.Add(buttonLogOut);
            groupBoxLogin.ForeColor = Color.FromArgb(153, 170, 181);
            groupBoxLogin.Location = new Point(27, 12);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(320, 97);
            groupBoxLogin.TabIndex = 18;
            groupBoxLogin.TabStop = false;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(35, 39, 42);
            buttonHelp.Cursor = Cursors.Hand;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            buttonHelp.ForeColor = Color.FromArgb(153, 170, 181);
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelp.Location = new Point(43, 47);
            buttonHelp.Margin = new Padding(3, 4, 3, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(73, 35);
            buttonHelp.TabIndex = 16;
            buttonHelp.Text = "Help";
            buttonHelp.TextAlign = ContentAlignment.MiddleRight;
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // labelAuthenticatedUser
            // 
            labelAuthenticatedUser.AutoSize = true;
            labelAuthenticatedUser.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold | FontStyle.Italic);
            labelAuthenticatedUser.Location = new Point(43, 4);
            labelAuthenticatedUser.Name = "labelAuthenticatedUser";
            labelAuthenticatedUser.Size = new Size(0, 26);
            labelAuthenticatedUser.TabIndex = 15;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.FromArgb(183, 21, 64);
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOut.ForeColor = Color.Black;
            buttonLogOut.Image = (Image)resources.GetObject("buttonLogOut.Image");
            buttonLogOut.ImageAlign = ContentAlignment.MiddleRight;
            buttonLogOut.Location = new Point(190, 47);
            buttonLogOut.Margin = new Padding(3, 4, 3, 4);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.RightToLeft = RightToLeft.Yes;
            buttonLogOut.Size = new Size(97, 35);
            buttonLogOut.TabIndex = 14;
            buttonLogOut.Text = "Logout";
            buttonLogOut.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += logOut_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(1043, 534);
            Controls.Add(groupBoxLogin);
            Controls.Add(groupBoxRootAccess);
            Controls.Add(dataGridViewDBInfo);
            Controls.Add(groupBoxEmployeeAccess);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            Text = "Menu";
            FormClosing += FormMenu_FormClosing;
            Load += FormMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDBInfo).EndInit();
            groupBoxRootAccess.ResumeLayout(false);
            groupBoxEmployeeAccess.ResumeLayout(false);
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDBInfo;
        private System.Windows.Forms.GroupBox groupBoxRootAccess;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUsersList;
        private System.Windows.Forms.Button buttonPassUpdate;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.GroupBox groupBoxEmployeeAccess;
        private System.Windows.Forms.Button buttonUpdateProductPrice;
        private System.Windows.Forms.Button buttonAddNewPart;
        private System.Windows.Forms.Button buttonSellPart;
        private System.Windows.Forms.Button buttonPartList;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelAuthenticatedUser;
        private System.Windows.Forms.Button buttonLogOut;
    }
}