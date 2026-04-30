/**************************************************************************
 *                                                                        *
 *  File:        FormMenu.cs                                              *
 *  Copyright:   (c) 2025, Lefter Andrei                                  *
 *  E-mail:      andrei.lefter@student.tuiasi.ro                          *
 *  Description: This file contains the implementation of Menu Interface  *
 *               where we have all the functionalities, depending on      *
 *               users rights                                             *
 *                                                                        *
 **************************************************************************/



using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using AutoPartsManagementDLL;
using Items.DataBaseObjects;

namespace Interface
{
    /// <summary>
    /// Main application menu form displaying UI and functionality based on user permissions.
    /// Provides access to product and user management features.
    /// </summary>
    public partial class FormMenu : Form
    {
        private ProxyActionManager _util;

        /// <summary>
        /// Initializes the form, applies styling, and loads content based on user access rights.
        /// </summary>
        public FormMenu()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            InitializeComponent();
            _util = ProxyActionManager.GetInstance();

            InitializeDataGrid();
            labelAuthenticatedUser.Text = "Welcome back, " + _util.CurrentUser.Username.ToUpper(CultureInfo.CurrentCulture);
            InitializeButtons();

            // Styling the DataGridView for dark theme
            dataGridViewDBInfo.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridViewDBInfo.EnableHeadersVisualStyles = false;
            dataGridViewDBInfo.DefaultCellStyle.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewDBInfo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 39, 42);
            dataGridViewDBInfo.DefaultCellStyle.ForeColor = Color.FromArgb(153, 170, 180);
            dataGridViewDBInfo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(28, 28, 28);
            dataGridViewDBInfo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            dataGridViewDBInfo.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(153, 170, 180);
            dataGridViewDBInfo.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(153, 170, 180);
            dataGridViewDBInfo.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            dataGridViewDBInfo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDBInfo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// Initializes UI buttons and displays sections based on user rights.
        /// </summary>
        private void InitializeButtons()
        {

            Permissions permissions = new Permissions();
            List<int> rights = permissions.RightsList(_util.CurrentUser.Rights);
           
            if (!rights.Contains(Constants.ModifyUsersDBRight))
            {
                buttonAddUser.Hide();
                buttonDeleteUser.Hide();
                buttonPassUpdate.Hide();
                groupBoxRootAccess.Hide();
            }

            if (!rights.Contains(Constants.ModifyPartsDBRight) && !rights.Contains(Constants.SellRight))
            {
                buttonAddNewPart.Hide();
                buttonAddStock.Hide();
                buttonUpdateProductPrice.Hide();
                groupBoxEmployeeAccess.Hide();
                dataGridViewDBInfo.Width = (int)(this.ClientSize.Width * 0.95);
                dataGridViewDBInfo.Font = new Font("Segoe UI", 14, FontStyle.Regular);
                int totalWidth = dataGridViewDBInfo.ClientSize.Width;
                dataGridViewDBInfo.Columns[0].Width = (int)(totalWidth * 0.31);
                dataGridViewDBInfo.Columns[1].Width = (int)(totalWidth * 0.31);
                dataGridViewDBInfo.Columns[2].Width = (int)(totalWidth * 0.31);
            }
            else if (!rights.Contains(Constants.ModifyPartsDBRight) && rights.Contains(Constants.SellRight))
            {
                groupBoxEmployeeAccess.Location = groupBoxRootAccess.Location;
                groupBoxEmployeeAccess.Size = new Size(groupBoxEmployeeAccess.Width * 2, groupBoxRootAccess.Height);
                buttonAddNewPart.Hide();
                buttonAddStock.Hide();
                buttonUpdateProductPrice.Hide();
                buttonSellPart.Location = new Point(buttonPartList.Location.X + 25 + buttonPartList.Width, buttonPartList.Location.Y );
            }

            if (!rights.Contains(Constants.SellRight))
            {
                buttonSellPart.Hide();
            }
            if (!rights.Contains(Constants.ViewUsersRight)) buttonUsersList.Hide();
            else DisplayUsers();
            if (!rights.Contains(Constants.ViewPartsRight)) buttonPartList.Hide();
            else DisplayProducts();
        }

        /// <summary>
        /// Sets up the data grid columns based on whether the user is admin or employee.
        /// </summary>
        private void InitializeDataGrid()
        {
            dataGridViewDBInfo.AllowUserToAddRows = false;
            dataGridViewDBInfo.Columns.Clear();
            dataGridViewDBInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            if (_util.IsAdmin())
            {
                dataGridViewDBInfo.Columns.Add("ID", "ID");
                dataGridViewDBInfo.Columns.Add("Username", "Username");
                dataGridViewDBInfo.Columns.Add("Rights", "Rights");
            }
            else
            {
                dataGridViewDBInfo.Columns.Add("Barcode", "ID");
                dataGridViewDBInfo.Columns.Add("Name", "Name");
                dataGridViewDBInfo.Columns.Add("Category", "Brand");
                dataGridViewDBInfo.Columns.Add("Price", "Price");
                dataGridViewDBInfo.Columns.Add("Stock", "Stock");

                var imgColumn = new DataGridViewImageColumn
                {
                    Name = "Poza",
                    HeaderText = "Picture",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 100
                };
                dataGridViewDBInfo.Columns.Add(imgColumn);
            }
        }

        /// <summary>
        /// Loads and displays all auto parts in the data grid, including their images.
        /// </summary>
        private void DisplayProducts()
        {
            List<AutoPart> parts = _util.GetParts();
            dataGridViewDBInfo.Rows.Clear();

            string imagesDir = Path.Combine(Application.StartupPath, "images");
            string fallback = Path.Combine(imagesDir, "default.jpg");

            foreach (AutoPart p in parts)
            {
                string imagePath = Path.Combine(imagesDir, $"{p.Id}.jpg");
                Image img;

                try
                {
                    img = File.Exists(imagePath) ? Image.FromFile(imagePath) : Image.FromFile(fallback);
                }
                catch
                {
                    img = null;
                }

                dataGridViewDBInfo.Rows.Add(p.Id, p.Name, p.Brand, p.Price, p.Stock, img);
            }
        }

        /// <summary>
        /// Loads and displays all users in the data grid.
        /// </summary>
        private void DisplayUsers()
        {
            List<User> users = _util.GetUsers();
            dataGridViewDBInfo.Rows.Clear();

            foreach (User u in users)
            {
                dataGridViewDBInfo.Rows.Add(u.Id, u.Username, u.Rights);
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form login = new FormLogIn();
            this.Hide();
            login.Show();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser.GetInstance().Show();
        }
        private void buttonPassUpdate_Click(object sender, EventArgs e)
        {
            FormUpdatePass.GetInstance().Show();
        }
        private void buttonUsersList_Click(object sender, EventArgs e)
        {
            DisplayUsers();
        }
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            FormDeleteUser.GetInstance().Show();
        }
        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct.GetInstace().Show();
        }
        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            FormAddToStock.GetInstance().Show();
        }
        private void buttonSellProduct_Click(object sender, EventArgs e)
        {
            FormSell.GetInstance().Show();
        }
        private void buttonProductList_Click(object sender, EventArgs e)
        {
            DisplayProducts();
        }
        private void buttonUpdateProductPrice_Click(object sender, EventArgs e)
        {
            FormUpdatePrice.GetInstance().Show();
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AutoPartsStoreManagementAppFinal.chm");
        }

        /// <summary>
        /// Closes the entire application when this form is closed.
        /// </summary>
        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
