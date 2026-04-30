/**************************************************************************
 *                                                                        *
 *  File:        FormUpdatePass.cs                                        *
 *  Copyright:   (c) 2025, Lefter Andrei                                  *
 *  E-mail:      andrei.lefter@student.tuiasi.ro                          *
 *  Description: This file contains the implementation of Update Password *
 *               Interface where the admin can change the password of an  *
 *               user                                                     *
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
    /// Form used to update a user's password. Uses validation to ensure all fields are completed.
    /// </summary>
    public partial class FormUpdatePass : TemplateActionForm
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();
        private static FormUpdatePass _instance = null;

        /// <summary>
        /// Private constructor that initializes the form and connects the confirm button.
        /// </summary>
        private FormUpdatePass()
        {
            InitializeComponent();
            ConnectButton(buttonUpdate);
        }

        /// <summary>
        /// Gets the singleton instance of this form.
        /// </summary>
        /// <returns>The single instance of FormUpdatePass.</returns>
        public static FormUpdatePass GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormUpdatePass();
            }
            else
            {
                _instance.BringToFront();
            }
            return _instance;
        }

        /// <summary>
        /// Validates the input fields for user, old password, and new password.
        /// </summary>
        /// <returns>True if all fields are filled; otherwise, false.</returns>
        protected override bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxUser.Text) ||
                string.IsNullOrWhiteSpace(textBoxOldPass.Text) ||
                string.IsNullOrWhiteSpace(textBoxNewPass.Text))
            {
                MessageBox.Show("All fields must be completed.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Executes the password update operation.
        /// </summary>
        protected override void ExecuteAction()
        {
            string username = textBoxUser.Text;
            string oldPass = textBoxOldPass.Text;
            string newPass = textBoxNewPass.Text;

            _util.UpdateUserPassword(username, oldPass, newPass);
            MessageBox.Show("Password updated successfully!");
            this.Close();
        }
    }
}
