/**************************************************************************
 *                                                                        *
 *  File:        FormAddUser.cs                                           *
 *  Copyright:   (c) 2025, Lefter Andrei                                  *
 *  E-mail:      andrei.lefter@student.tuiasi.ro                          *
 *  Description: This file contains the implementation of Add New User    *
 *               Interface where we can add username and password for a   *
 *               new user                                                 *
 *                                                                        *
 **************************************************************************/



using System;
using System.Windows.Forms;
using Exceptions.AccessRightsExceptions;
using Exceptions.DataBaseExceptions;
using AutoPartsManagementDLL;
using System.IO;

namespace Interface
{
    /// <summary>
    /// Form used to add a new user to the system. Implements validation and permission logic.
    /// </summary>
    public partial class FormAddUser : TemplateActionForm
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();
        private static FormAddUser _instance = null;

        /// <summary>
        /// Private constructor that initializes the form and connects the confirm button.
        /// </summary>
        private FormAddUser()
        {
            InitializeComponent();
            ConnectButton(buttonAddNewUser);
        }

        /// <summary>
        /// Gets the singleton instance of this form.
        /// </summary>
        /// <returns>The single instance of FormAddUser.</returns>
        public static FormAddUser GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormAddUser();
            }
            else
            {
                _instance.BringToFront();
            }
            return _instance;
        }

        /// <summary>
        /// Validates the input values for username, password, and role.
        /// </summary>
        /// <returns>True if the input is valid; otherwise, false.</returns>
        protected override bool ValidateInput()
        {
            string username = textBoxNewUserName.Text;
            string password = textBoxNewUserPassword.Text;
            string roleText = textBoxNewUserOccupation.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                
                MessageBox.Show("Username and password fields must not be empty!");
                return false;
            }

            int role;
            if (!int.TryParse(roleText, out role) || (role != 0 && role != 1))
            {
                MessageBox.Show("Occupation must be 0 (Stock Manager) or 1 (Sales Clerk).");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Executes the operation to add the new user to the database.
        /// </summary>
        protected override void ExecuteAction()
        {
            string username = textBoxNewUserName.Text;
            string password = textBoxNewUserPassword.Text;
            int role = Convert.ToInt32(textBoxNewUserOccupation.Text);

            _util.AddUser(username, password, role);
            MessageBox.Show("Successfully added user: '" + username + "'");
            this.Close();
        }
    }
}
