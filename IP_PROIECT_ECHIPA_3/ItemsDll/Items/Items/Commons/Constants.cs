/**************************************************************************
 *                                                                        *
 *  File:        Constants.cs                                             *
 *  Copyright:   (c) 2025, Sfichi Alin-Ionuț                              *
 *  E-mail:      alin-ionut.sfichi@student.tuiasi.ro                      *
 *  Description: This file defines constants for app control              *
 *                                                                        *
 **************************************************************************/



namespace AutoPartsManagementDLL
{
    /// <summary>
    /// Contains constant values representing user roles and access rights.
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// Right to sell parts.
        /// </summary>
        public const int SellRight = 10;

        /// <summary>
        /// Right to view parts in the system.
        /// </summary>
        public const int ViewPartsRight = 11;

        /// <summary>
        /// Right to modify the parts database.
        /// </summary>
        public const int ModifyPartsDBRight = 12;

        /// <summary>
        /// Right to modify user accounts.
        /// </summary>
        public const int ModifyUsersDBRight = 13;

        /// <summary>
        /// Right to view user accounts.
        /// </summary>
        public const int ViewUsersRight = 14;

        /// <summary>
        /// Administrator role identifier.
        /// </summary>
        public const int Admin = -1;

        /// <summary>
        /// Stock manager role identifier.
        /// </summary>
        public const int StockManager = 0;

        /// <summary>
        /// Sales clerk role identifier.
        /// </summary>
        public const int SalesClerk = 1;
    }
}
