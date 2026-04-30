/**************************************************************************
 *                                                                        *
 *  File:        RealActionManager.cs                                     *
 *  Copyright:   (c) 2025, Pitic Emanuel                                  *
 *  E-mail:      emanuel.pitic@student.tuiasi.ro                          *
 *  Description: This file contains the implementation of Real Subject    *
 *               from Proxy Pattern                                       *
 *                                                                        *
 **************************************************************************/



using System.Collections.Generic;
using Items.DataBaseObjects;
using Exceptions.DataBaseExceptions;
using Items.Commons;
using AutoPartsDataManager;
using Exceptions.AccessRightsExceptions;
using System.IO;

namespace AutoPartsManagementDLL
{
    /// <summary>
    /// Handles actual operations for managing auto parts and users.
    /// Performs direct data manipulation through the database layer.
    /// </summary>
    public class RealActionManager : IActionManager
    {
        private DB _db;

        /// <summary>
        /// Initializes a new instance using the default database file.
        /// </summary>
        public RealActionManager()
        {
            _db = DB.GetInstance("AutoParts.db");
            _db.CreateTables();
        }

        /// <summary>
        /// Initializes a new instance using a custom database instance.
        /// </summary>
        /// <param name="db">The database instance to use.</param>
        public RealActionManager(DB db)
        {
            _db = db;
            _db.CreateTables();
        }

        /// <summary>
        /// Adds a new auto part to the system.
        /// </summary>
        public void AddNewPart(AutoPart part)
        {
            if (part.Stock < 0)
                throw new InvalidStockException("The stock must be a positive number");
            if (part.Price < 0)
                throw new InvalidDataException("The price must be a positive number");

            _db.Insert(part);
        }

        /// <summary>
        /// Sells a part by decreasing its stock.
        /// </summary>
        public void SellPart(int partId, int quantity)
        {
            AutoPart part = _db.SelectPart(partId);
            if (part == null)
                throw new RecordNotFoundException("Part not found");

            int newStock = part.Stock - quantity;
            if (newStock < 0)
                throw new InvalidStockException("Insufficient stock");

            part.Stock = newStock;
            _db.Update(part);
        }

        /// <summary>
        /// Increases the stock of a part.
        /// </summary>
        public void AddToStock(int partId, int quantity)
        {
            AutoPart part = _db.SelectPart(partId);
            if (part == null)
                throw new RecordNotFoundException("Part not found");

            part.Stock += quantity;
            _db.Update(part);
        }

        /// <summary>
        /// Updates the price of an existing part.
        /// </summary>
        public void UpdatePartPrice(int partId, double price)
        {
            if (price < 0)
                throw new InvalidDataException("Invalid price");

            AutoPart part = _db.SelectPart(partId);
            if (part == null)
                throw new RecordNotFoundException("Part not found");

            part.Price = price;
            _db.Update(part);
        }

        /// <summary>
        /// Retrieves all auto parts from the database.
        /// </summary>
        public List<AutoPart> GetParts()
        {
            return _db.SelectAllParts();
        }

        /// <summary>
        /// Adds a new user to the system.
        /// </summary>
        public void AddUser(string username, string password, int role)
        {
            if (role != Constants.StockManager && role != Constants.SalesClerk)
                throw new InvalidDataException("Invalid role");

            int id = _db.GetLastUserID() + 1;
            string hashed = Cryptography.HashString(password);
            User user = new User(id, username, hashed, role);
            _db.Insert(user);
        }

        /// <summary>
        /// Updates the password for an existing user.
        /// </summary>
        public void UpdateUserPassword(string username, string oldPass, string newPass)
        {
            User user = _db.SelectUser(username);
            if (user == null)
                throw new RecordNotFoundException("User not found");

            string oldHash = Cryptography.HashString(oldPass);
            if (user.Password != oldHash)
                throw new InvalidDataException("Incorrect password");

            user.Password = Cryptography.HashString(newPass);
            _db.Update(user);
        }

        /// <summary>
        /// Retrieves a user by ID.
        /// </summary>
        public User GetUser(int userId)
        {
            List<User> all = _db.SelectAllUsers();
            foreach (User u in all)
            {
                if (u.Id == userId)
                    return u;
            }
            throw new RecordNotFoundException("User not found");
        }

        /// <summary>
        /// Deletes a user by username.
        /// </summary>
        public void DeleteUser(string username)
        {
            User user = _db.SelectUser(username);
            if (user == null)
                throw new RecordNotFoundException("User not found");
            if (user.Rights == Constants.Admin)
                throw new PermissionDeniedException("Admin cannot be deleted");

            _db.DeleteUser(user.Id);
        }

        /// <summary>
        /// Retrieves all users from the database.
        /// </summary>
        public List<User> GetUsers()
        {
            return _db.SelectAllUsers();
        }
    }
}
