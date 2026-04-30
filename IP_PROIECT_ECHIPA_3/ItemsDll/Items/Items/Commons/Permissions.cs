/**************************************************************************
 *                                                                        *
 *  File:        Permissions.cs                                           *
 *  Copyright:   (c) 2025, Sfichi Alin-Ionuț                              *
 *  E-mail:      alin-ionut.sfichi@student.tuiasi.ro                      *
 *  Description: This file contains permissions for different user types  *
 *                                                                        *
 **************************************************************************/



using System.Collections.Generic;

namespace AutoPartsManagementDLL
{
    /// <summary>
    /// Manages permissions based on user roles. Associates each role with specific access rights.
    /// </summary>
    public class Permissions
    {
        private Dictionary<int, List<int>> _permissionsList;

        /// <summary>
        /// Initializes the permissions dictionary with predefined roles and rights.
        /// </summary>
        public Permissions()
        {
            _permissionsList = new Dictionary<int, List<int>>();
            _permissionsList.Add(Constants.SalesClerk, new List<int> { Constants.SellRight, Constants.ViewPartsRight });
            _permissionsList.Add(Constants.StockManager, new List<int> { Constants.SellRight, Constants.ViewPartsRight, Constants.ModifyPartsDBRight });
            _permissionsList.Add(Constants.Admin, new List<int> { Constants.ModifyUsersDBRight, Constants.ViewUsersRight });
        }

        /// <summary>
        /// Returns the list of rights associated with a specific user role.
        /// </summary>
        /// <param name="role">The role identifier.</param>
        /// <returns>A list of access right constants.</returns>
        public List<int> RightsList(int role)
        {
            if (_permissionsList.ContainsKey(role))
            {
                return _permissionsList[role];
            }
            return new List<int>();
        }
    }
}
