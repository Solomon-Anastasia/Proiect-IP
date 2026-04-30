/**************************************************************************
 *                                                                        *
 *  File:        FormLogIn.cs                                             *
 *  Copyright:   (c) 2025, Lefter Andrei                                  *
 *  E-mail:      andrei.lefter@student.tuiasi.ro                          *
 *  Description: This file contains the implementation of LogIn Interface *
 *                                                                        *
 **************************************************************************/



using System;
using System.Windows.Forms;
using AutoPartsManagementDLL;

namespace Interface
{
    /// <summary>
    /// Form used to authenticate users into the system.
    /// Uses TemplateActionForm for standardized validation and execution flow.
    /// </summary>
    public partial class FormLogIn : TemplateActionForm
    {
        private ProxyActionManager _util;

        /// <summary>
        /// Initializes the login form and connects logic to the login button.
        /// </summary>
        public FormLogIn()
        {
            InitializeComponent();
            _util = ProxyActionManager.GetInstance();

            this.AcceptButton = login;
            textBoxPass.PasswordChar = '*';

            ConnectButton(login);
        }

        /// <summary>
        /// Validates input fields for username and password.
        /// </summary>
        /// <returns>True if both fields are filled; otherwise, false.</returns>
        protected override bool ValidateInput()
        {
            return !string.IsNullOrWhiteSpace(textBoxUser.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxPass.Text);
        }

        /// <summary>
        /// Attempts user login and redirects to menu if successful.
        /// </summary>
        protected override void ExecuteAction()
        {
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;

            if (_util.Login(username, password))
            {
                Form pagina2 = new FormMenu();
                pagina2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error");
                textBoxUser.Clear();
                textBoxPass.Clear();
            }
        }

        /// <summary>
        /// Handles application exit when the login form is closed.
        /// </summary>
        private void FormLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
