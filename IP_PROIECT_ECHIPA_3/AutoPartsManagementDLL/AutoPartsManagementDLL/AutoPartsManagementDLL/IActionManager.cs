/**************************************************************************
 *                                                                        *
 *  File:        IActionManager.cs                                        *
 *  Copyright:   (c) 2025, Pitic Emanuel                                  *
 *  E-mail:      emanuel.pitic@student.tuiasi.ro                          *
 *  Description: This file contains a generic Manager definition.         *
 *               It also defines the Subject from Proxy Pattern           *
 *                                                                        *
 **************************************************************************/



using System.Collections.Generic;
using Items.DataBaseObjects;

namespace AutoPartsManagementDLL
{
    /// <summary>
    /// Interface for defining user and part management operations.
    /// </summary>
    public interface IActionManager
    {
        /// <summary>
        /// Adds a new auto part.
        /// </summary>
        /// <param name="part">Part to be added.</param>
        void AddNewPart(AutoPart part);

        /// <summary>
        /// Processes a part sale by decreasing stock.
        /// </summary>
        /// <param name="partId">ID of the part.</param>
        /// <param name="quantity">Quantity to sell.</param>
        void SellPart(int partId, int quantity);

        /// <summary>
        /// Adds stock to an existing part.
        /// </summary>
        /// <param name="partId">ID of the part.</param>
        /// <param name="quantity">Quantity to add.</param>
        void AddToStock(int partId, int quantity);

        /// <summary>
        /// Updates the price of a specific part.
        /// </summary>
        /// <param name="partId">ID of the part.</param>
        /// <param name="price">New price value.</param>
        void UpdatePartPrice(int partId, double price);

        /// <summary>
        /// Returns the list of all auto parts.
        /// </summary>
        /// <returns>List of parts.</returns>
        List<AutoPart> GetParts();

        /// <summary>
        /// Adds a new user to the system.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        /// <param name="role">Role of the user.</param>
        void AddUser(string username, string password, int role);

        /// <summary>
        /// Updates a user's password.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="oldPass">Current password.</param>
        /// <param name="newPass">New password.</param>
        void UpdateUserPassword(string username, string oldPass, string newPass);

        /// <summary>
        /// Retrieves a user by ID.
        /// </summary>
        /// <param name="userId">ID of the user.</param>
        /// <returns>User instance.</returns>
        User GetUser(int userId);

        /// <summary>
        /// Deletes a user by username.
        /// </summary>
        /// <param name="username">Username of the user to delete.</param>
        void DeleteUser(string username);

        /// <summary>
        /// Returns the list of all users.
        /// </summary>
        /// <returns>List of users.</returns>
        List<User> GetUsers();
    }

}
