/**************************************************************************
 *                                                                        *
 *  File:        FormDeleteUser.cs                                        *
 *  Copyright:   (c) 2025, Lefter Andrei                                  *
 *  E-mail:      andrei.lefter@student.tuiasi.ro                          *
 *  Description: This file contains the implementation of Delete User     *
 *               Interface where we can delete from database an user      *
 *                                                                        *
 **************************************************************************/



using System;
using System.Windows.Forms;
using Exceptions.AccessRightsExceptions;
using Exceptions.DataBaseExceptions;
using AutoPartsManagementDLL;

namespace Interface
{
    /// <summary>
    /// Form used to delete an existing user from the system.
    /// </summary>
    public partial class FormDeleteUser : TemplateActionForm
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();
        private static FormDeleteUser _instance = null;

        /// <summary>
        /// Private constructor that initializes the form and connects the confirm button.
        /// </summary>
        private FormDeleteUser()
        {
            InitializeComponent();
            ConnectButton(buttonDelete);
        }

        /// <summary>
        /// Gets the singleton instance of this form.
        /// </summary>
        /// <returns>The single instance of FormDeleteUser.</returns>
        public static FormDeleteUser GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormDeleteUser();
            }
            else
            {
                _instance.BringToFront();
            }
            return _instance;
        }

        /// <summary>
        /// Validates the input value for the username to delete.
        /// </summary>
        /// <returns>True if input is valid; otherwise, false.</returns>
        protected override bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxDeletedUsername.Text))
            {
                MessageBox.Show("Username is required.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Executes the operation to delete the specified user.
        /// </summary>
        protected override void ExecuteAction()
        {
            string username = textBoxDeletedUsername.Text;
            _util.DeleteUser(username);
            MessageBox.Show("Successfully deleted user '" + username + "'");
            this.Close();
        }
    }
}
