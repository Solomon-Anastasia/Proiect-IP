/**************************************************************************
 *                                                                        *
 *  File:        RealActionManagerTests                                   *
 *  Copyright:   (c) 2025, Samachiș Eduard-Iulian                         *
 *  E-mail:      eduard-iulian.samachis@student.tuiasi.ro                 *
 *  Description: This file contains unit testing module for AutoParts     *
 *               Management DLL                                           *
 *                                                                        *
 **************************************************************************/



using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoPartsManagementDLL;
using Items.DataBaseObjects;
using Exceptions.DataBaseExceptions;
using Exceptions.AccessRightsExceptions;
using System;
using System.Collections.Generic;
using AutoPartsDataManager;

namespace AutoPartsManagementDLL.Tests
{
    /// <summary>
    /// Unit tests for the RealActionManager class, covering CRUD operations for parts and users.
    /// </summary>
    [TestClass]
    public class RealActionManagerTests
    {
        private RealActionManager _manager;
        private DB _db;

        /// <summary>
        /// Initializes an in-memory database and RealActionManager instance before each test.
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            _db = DB.CreateTestInstance(":memory:");
            _manager = new RealActionManager(_db);
        }

        /// <summary>
        /// Tests that a valid part is added successfully.
        /// </summary>
        [TestMethod]
        public void AddNewPart_ValidPart_ShouldAddSuccessfully()
        {
            var part = new AutoPart(1, "Part1", "Brand1", 100.0, 10);
            _manager.AddNewPart(part);

            var parts = _manager.GetParts();
            Assert.IsTrue(parts.Exists(p => p.Id == 1));
        }

        /// <summary>
        /// Tests that adding a part with negative stock throws InvalidStockException.
        /// </summary>
        [TestMethod]
        public void AddNewPart_NegativeStock_ShouldThrowInvalidStockException()
        {
            var part = new AutoPart(2, "Part2", "Brand2", 50.0, -5);
            Assert.ThrowsException<InvalidStockException>(() => _manager.AddNewPart(part));
        }

        /// <summary>
        /// Tests that adding a part with negative price throws InvalidDataException.
        /// </summary>
        [TestMethod]
        public void AddNewPart_NegativePrice_ShouldThrowInvalidDataException()
        {
            var part = new AutoPart(3, "Part3", "Brand3", -10.0, 5);
            Assert.ThrowsException<InvalidDataException>(() => _manager.AddNewPart(part));
        }

        /// <summary>
        /// Tests that selling a part with valid quantity reduces the stock.
        /// </summary>
        [TestMethod]
        public void SellPart_ValidQuantity_ShouldReduceStock()
        {
            var part = new AutoPart(4, "Part4", "Brand4", 20.0, 10);
            _manager.AddNewPart(part);

            _manager.SellPart(4, 5);

            var updatedPart = _manager.GetParts().Find(p => p.Id == 4);
            Assert.AreEqual(5, updatedPart.Stock);
        }

        /// <summary>
        /// Tests that selling more than available stock throws InvalidStockException.
        /// </summary>
        [TestMethod]
        public void SellPart_InsufficientStock_ShouldThrowInvalidStockException()
        {
            var part = new AutoPart(5, "Part5", "Brand5", 30.0, 3);
            _manager.AddNewPart(part);

            Assert.ThrowsException<InvalidStockException>(() => _manager.SellPart(5, 5));
        }

        /// <summary>
        /// Tests that selling a non-existent part throws RecordNotFoundException.
        /// </summary>
        [TestMethod]
        public void SellPart_PartNotFound_ShouldThrowRecordNotFoundException()
        {
            Assert.ThrowsException<RecordNotFoundException>(() => _manager.SellPart(999, 1));
        }

        /// <summary>
        /// Tests that adding stock to an existing part increases its quantity.
        /// </summary>
        [TestMethod]
        public void AddToStock_Valid_ShouldIncreaseStock()
        {
            var part = new AutoPart(6, "Part6", "Brand6", 10.0, 5);
            _manager.AddNewPart(part);

            _manager.AddToStock(6, 10);

            var updatedPart = _manager.GetParts().Find(p => p.Id == 6);
            Assert.AreEqual(15, updatedPart.Stock);
        }

        /// <summary>
        /// Tests that adding stock to a non-existent part throws RecordNotFoundException.
        /// </summary>
        [TestMethod]
        public void AddToStock_PartNotFound_ShouldThrowRecordNotFoundException()
        {
            Assert.ThrowsException<RecordNotFoundException>(() => _manager.AddToStock(999, 10));
        }

        /// <summary>
        /// Tests that updating the price of a part works correctly.
        /// </summary>
        [TestMethod]
        public void UpdatePartPrice_ValidPrice_ShouldUpdatePrice()
        {
            var part = new AutoPart(7, "Part7", "Brand7", 10.0, 10);
            _manager.AddNewPart(part);

            _manager.UpdatePartPrice(7, 15.0);

            var updatedPart = _manager.GetParts().Find(p => p.Id == 7);
            Assert.AreEqual(15.0, updatedPart.Price);
        }

        /// <summary>
        /// Tests that a negative price throws InvalidDataException.
        /// </summary>
        [TestMethod]
        public void UpdatePartPrice_NegativePrice_ShouldThrowInvalidDataException()
        {
            var part = new AutoPart(8, "Part8", "Brand8", 10.0, 10);
            _manager.AddNewPart(part);

            Assert.ThrowsException<InvalidDataException>(() => _manager.UpdatePartPrice(8, -5));
        }

        /// <summary>
        /// Tests that updating the price of a non-existent part throws RecordNotFoundException.
        /// </summary>
        [TestMethod]
        public void UpdatePartPrice_PartNotFound_ShouldThrowRecordNotFoundException()
        {
            Assert.ThrowsException<RecordNotFoundException>(() => _manager.UpdatePartPrice(999, 10));
        }

        /// <summary>
        /// Tests that getting all parts returns a non-empty list after insertion.
        /// </summary>
        [TestMethod]
        public void GetParts_ShouldReturnList()
        {
            var part = new AutoPart(9, "Part9", "Brand9", 20.0, 10);
            _manager.AddNewPart(part);

            var parts = _manager.GetParts();

            Assert.IsTrue(parts.Count > 0);
        }

        /// <summary>
        /// Tests that a valid user is added successfully.
        /// </summary>
        [TestMethod]
        public void AddUser_ValidUser_ShouldAddSuccessfully()
        {
            _manager.AddUser("user1", "password", Constants.StockManager);

            var users = _manager.GetUsers();
            Assert.IsTrue(users.Exists(u => u.Username == "user1"));
        }

        /// <summary>
        /// Tests that adding a user with an invalid role throws InvalidDataException.
        /// </summary>
        [TestMethod]
        public void AddUser_InvalidRole_ShouldThrowInvalidDataException()
        {
            Assert.ThrowsException<InvalidDataException>(() => _manager.AddUser("user2", "password", 999));
        }

        /// <summary>
        /// Tests that providing the wrong old password throws InvalidDataException.
        /// </summary>
        [TestMethod]
        public void UpdateUserPassword_WrongOldPassword_ShouldThrowInvalidDataException()
        {
            _manager.AddUser("user4", "oldpass", Constants.StockManager);

            Assert.ThrowsException<InvalidDataException>(() => _manager.UpdateUserPassword("user4", "wrongold", "newpass"));
        }

        /// <summary>
        /// Tests that updating the password for a non-existent user throws RecordNotFoundException.
        /// </summary>
        [TestMethod]
        public void UpdateUserPassword_UserNotFound_ShouldThrowRecordNotFoundException()
        {
            Assert.ThrowsException<RecordNotFoundException>(() => _manager.UpdateUserPassword("nouser", "old", "new"));
        }

        /// <summary>
        /// Tests that an existing user is returned correctly.
        /// </summary>
        [TestMethod]
        public void GetUser_ExistingUser_ShouldReturnUser()
        {
            _manager.AddUser("user5", "password", Constants.StockManager);
            var user = _manager.GetUser(_manager.GetUsers().Find(u => u.Username == "user5").Id);

            Assert.IsNotNull(user);
            Assert.AreEqual("user5", user.Username);
        }

        /// <summary>
        /// Tests that attempting to retrieve a non-existent user throws RecordNotFoundException.
        /// </summary>
        [TestMethod]
        public void GetUser_NotFound_ShouldThrowRecordNotFoundException()
        {
            Assert.ThrowsException<RecordNotFoundException>(() => _manager.GetUser(9999));
        }

        /// <summary>
        /// Tests that deleting a valid user removes them from the system.
        /// </summary>
        [TestMethod]
        public void DeleteUser_Valid_ShouldDeleteUser()
        {
            _manager.AddUser("user6", "password", Constants.StockManager);
            var user = _manager.GetUsers().Find(u => u.Username == "user6");

            _manager.DeleteUser("user6");

            Assert.ThrowsException<RecordNotFoundException>(() => (_manager.GetUser(user.Id)));
        }

        /// <summary>
        /// Tests that deleting a non-existent user throws RecordNotFoundException.
        /// </summary>
        [TestMethod]
        public void DeleteUser_UserNotFound_ShouldThrowRecordNotFoundException()
        {
            Assert.ThrowsException<RecordNotFoundException>(() => _manager.DeleteUser("nouser"));
        }

        /// <summary>
        /// Tests that GetUsers returns a non-empty list after adding users.
        /// </summary>
        [TestMethod]
        public void GetUsers_ShouldReturnList()
        {
            _manager.AddUser("user7", "password", Constants.StockManager);

            var users = _manager.GetUsers();
            Assert.IsTrue(users.Count > 0);
        }
    }
}
