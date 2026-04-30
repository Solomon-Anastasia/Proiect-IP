/**************************************************************************
 *                                                                        *
 *  File:        ProxyActionManager.cs                                    *
 *  Copyright:   (c) 2025, Pitic Emanuel                                  *
 *  E-mail:      emanuel.pitic@student.tuiasi.ro                          *
 *  Description: This file contains the implementation of Proxy class     *
 *               from Proxy Pattern                                       *
 *                                                                        *
 **************************************************************************/



using System.Collections.Generic;
using Items.DataBaseObjects;
using Exceptions.DataBaseExceptions;
using Exceptions.AccessRightsExceptions;
using Items.Commons;
using AutoPartsDataManager;

namespace AutoPartsManagementDLL
{
    /// <summary>
    /// Provides controlled access to application actions using permission checks. 
    /// Acts as a proxy to the RealActionManager.
    /// </summary>
    public class ProxyActionManager : IActionManager
    {
        private static ProxyActionManager _instance = null;
        private DB _db;
        private RealActionManager _realManager;
        private User _currentUser;
        private Permissions _permissions;

        /// <summary>
        /// Private constructor initializes dependencies.
        /// </summary>
        private ProxyActionManager()
        {
            _db = DB.GetInstance("AutoParts.db");
            _realManager = new RealActionManager();
            _permissions = new Permissions();
        }

        /// <summary>
        /// Gets the singleton instance of ProxyActionManager.
        /// </summary>
        public static ProxyActionManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ProxyActionManager();
            }
            return _instance;
        }

        /// <summary>
        /// Gets the currently logged-in user.
        /// </summary>
        public User CurrentUser => _currentUser;

        /// <summary>
        /// Attempts to log in with a given username and password.
        /// </summary>
        /// <param name="username">Username to log in.</param>
        /// <param name="password">Password to check.</param>
        /// <returns>True if login is successful; otherwise, false.</returns>
        public bool Login(string username, string password)
        {
            List<User> users = _db.SelectAllUsers();
            string hashedPassword = Cryptography.HashString(password);

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == username && users[i].Password == hashedPassword)
                {
                    _currentUser = users[i];
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Adds a new auto part if the user has permission.
        /// </summary>
        public void AddNewPart(AutoPart part)
        {
            if (!HasRight(Constants.ModifyPartsDBRight))
                throw new PermissionDeniedException();

            _realManager.AddNewPart(part);
        }

        /// <summary>
        /// Processes a sale for the given part and quantity.
        /// </summary>
        public void SellPart(int partId, int quantity)
        {
            if (!HasRight(Constants.SellRight))
                throw new PermissionDeniedException();

            _realManager.SellPart(partId, quantity);
        }

        /// <summary>
        /// Adds stock to an existing part.
        /// </summary>
        public void AddToStock(int partId, int quantity)
        {
            if (!HasRight(Constants.ModifyPartsDBRight))
                throw new PermissionDeniedException();

            _realManager.AddToStock(partId, quantity);
        }

        /// <summary>
        /// Updates the price of an auto part.
        /// </summary>
        public void UpdatePartPrice(int partId, double price)
        {
            if (!HasRight(Constants.ModifyPartsDBRight))
                throw new PermissionDeniedException();

            _realManager.UpdatePartPrice(partId, price);
        }

        /// <summary>
        /// Retrieves the list of all parts.
        /// </summary>
        public List<AutoPart> GetParts()
        {
            if (!HasRight(Constants.ViewPartsRight))
                throw new PermissionDeniedException();

            return _realManager.GetParts();
        }

        /// <summary>
        /// Adds a new user with specified credentials and role.
        /// </summary>
        public void AddUser(string username, string password, int role)
        {
            if (!HasRight(Constants.ModifyUsersDBRight))
                throw new PermissionDeniedException();

            _realManager.AddUser(username, password, role);
        }

        /// <summary>
        /// Updates the password of an existing user.
        /// </summary>
        public void UpdateUserPassword(string username, string oldPass, string newPass)
        {
            if (!HasRight(Constants.ModifyUsersDBRight))
                throw new PermissionDeniedException();

            _realManager.UpdateUserPassword(username, oldPass, newPass);
        }

        /// <summary>
        /// Retrieves a user by ID.
        /// </summary>
        public User GetUser(int userId)
        {
            if (!HasRight(Constants.ViewUsersRight))
                throw new PermissionDeniedException();

            return _realManager.GetUser(userId);
        }

        /// <summary>
        /// Deletes a user by username.
        /// </summary>
        public void DeleteUser(string username)
        {
            if (!HasRight(Constants.ModifyUsersDBRight))
                throw new PermissionDeniedException();

            _realManager.DeleteUser(username);
        }

        /// <summary>
        /// Retrieves the list of all users.
        /// </summary>
        public List<User> GetUsers()
        {
            if (!HasRight(Constants.ViewUsersRight))
                throw new PermissionDeniedException();

            return _realManager.GetUsers();
        }

        /// <summary>
        /// Checks if the current user is an administrator.
        /// </summary>
        public bool IsAdmin()
        {
            return _currentUser != null && _currentUser.Rights == Constants.Admin;
        }

        /// <summary>
        /// Checks if the current user has a specific permission right.
        /// </summary>
        /// <param name="right">The right to be verified.</param>
        /// <returns>True if the user has the right; otherwise, false.</returns>
        private bool HasRight(int right)
        {
            List<int> rights = _permissions.RightsList(_currentUser.Rights);
            for (int i = 0; i < rights.Count; i++)
            {
                if (rights[i] == right)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
