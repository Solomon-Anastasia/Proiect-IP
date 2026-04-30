/**************************************************************************
 *                                                                        *
 *  File:        DBTests.cs                                               *
 *  Copyright:   (c) 2025, Samachiș Eduard-Iulian                         *
 *  E-mail:      eduard-iulian.samachis@student.tuiasi.ro                 *
 *  Description: This file contains unit testing module for DataBase      *
 *               Manager DLL                                              *
 *                                                                        *
 **************************************************************************/



using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoPartsDataManager;
using Items.DataBaseObjects;
using Exceptions.DataBaseExceptions;
using System;
using System.IO;
using System.Linq;

namespace AutoPartsDataManager.Tests
{
    /// <summary>
    /// Unit tests for the DB class, verifying database operations including insertions, updates, deletions, and queries.
    /// </summary>
    [TestClass]
    public class DBTests
    {
        private DB _db;

        /// <summary>
        /// Initializes an in-memory database before each test.
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            _db = DB.CreateTestInstance(":memory:");
            _db.CreateTables();
        }

        /// <summary>
        /// Verifies that the USERS and AUTOPARTS tables are created successfully.
        /// </summary>
        [TestMethod]
        public void CreateTables_CreatesUsersAndAutoPartsTables()
        {
            var users = _db.SelectAllUsers();
            var parts = _db.SelectAllParts();

            Assert.IsNotNull(users);
            Assert.IsNotNull(parts);
            Assert.AreEqual(0, users.Count);
            Assert.AreEqual(0, parts.Count);
        }

        /// <summary>
        /// Verifies that a user is inserted successfully.
        /// </summary>
        [TestMethod]
        public void InsertUser_InsertsUserSuccessfully()
        {
            var user = new User(1, "user1", "pass", 1);
            _db.Insert(user);

            var users = _db.SelectAllUsers();
            Assert.AreEqual(1, users.Count);
            Assert.AreEqual("user1", users[0].Username);
        }

        /// <summary>
        /// Verifies that inserting a user with duplicate ID throws ConstraintViolatedException.
        /// </summary>
        [TestMethod]
        public void InsertUser_DuplicateId_ThrowsException()
        {
            var user1 = new User(1, "user1", "pass", 1);
            var user2 = new User(1, "user2", "pass", 1);
            _db.Insert(user1);
            Assert.ThrowsException<ConstraintViolatedException>(() => _db.Insert(user2));
        }

        /// <summary>
        /// Verifies that inserting a user with duplicate username throws ConstraintViolatedException.
        /// </summary>
        [TestMethod]
        public void InsertUser_DuplicateUsername_ThrowsException()
        {
            var user1 = new User(1, "user1", "pass", 1);
            var user2 = new User(2, "user1", "pass", 1);
            _db.Insert(user1);
            Assert.ThrowsException<ConstraintViolatedException>(() => _db.Insert(user2));
        }

        /// <summary>
        /// Verifies that an auto part is inserted successfully.
        /// </summary>
        [TestMethod]
        public void InsertAutoPart_InsertsPartSuccessfully()
        {
            var part = new AutoPart(1, "part1", "brand", 10.0, 5);
            _db.Insert(part);

            var parts = _db.SelectAllParts();
            Assert.AreEqual(1, parts.Count);
            Assert.AreEqual("part1", parts[0].Name);
        }

        /// <summary>
        /// Verifies that inserting an auto part with negative stock throws InvalidStockException.
        /// </summary>
        [TestMethod]
        public void InsertAutoPart_NegativeStock_ThrowsException()
        {
            var part = new AutoPart(1, "part1", "brand", 10.0, -1);
            Assert.ThrowsException<InvalidStockException>(() => _db.Insert(part));
        }

        /// <summary>
        /// Verifies that inserting an auto part with duplicate ID throws ConstraintViolatedException.
        /// </summary>
        [TestMethod]
        public void InsertAutoPart_DuplicateId_ThrowsException()
        {
            var part1 = new AutoPart(1, "part1", "brand", 10.0, 5);
            var part2 = new AutoPart(1, "part2", "brand", 10.0, 5);
            _db.Insert(part1);
            Assert.ThrowsException<ConstraintViolatedException>(() => _db.Insert(part2));
        }

        /// <summary>
        /// Verifies that inserting an auto part with duplicate name throws ConstraintViolatedException.
        /// </summary>
        [TestMethod]
        public void InsertAutoPart_DuplicateName_ThrowsException()
        {
            var part1 = new AutoPart(1, "part1", "brand", 10.0, 5);
            var part2 = new AutoPart(2, "part1", "brand", 10.0, 5);
            _db.Insert(part1);
            Assert.ThrowsException<ConstraintViolatedException>(() => _db.Insert(part2));
        }

        /// <summary>
        /// Verifies that selecting an existing user returns the correct user.
        /// </summary>
        [TestMethod]
        public void SelectUser_ReturnsUser_WhenExists()
        {
            var user = new User(1, "user1", "pass", 1);
            _db.Insert(user);

            var result = _db.SelectUser("user1");
            Assert.IsNotNull(result);
            Assert.AreEqual("user1", result.Username);
        }

        /// <summary>
        /// Verifies that selecting a non-existent user returns null.
        /// </summary>
        [TestMethod]
        public void SelectUser_ReturnsNull_WhenNotExists()
        {
            var result = _db.SelectUser("nouser");
            Assert.IsNull(result);
        }

        /// <summary>
        /// Verifies that selecting an existing part returns the correct part.
        /// </summary>
        [TestMethod]
        public void SelectPart_ReturnsPart_WhenExists()
        {
            var part = new AutoPart(1, "part1", "brand", 10.0, 5);
            _db.Insert(part);

            var result = _db.SelectPart(1);
            Assert.IsNotNull(result);
            Assert.AreEqual("part1", result.Name);
        }

        /// <summary>
        /// Verifies that selecting a non-existent part returns null.
        /// </summary>
        [TestMethod]
        public void SelectPart_ReturnsNull_WhenNotExists()
        {
            var result = _db.SelectPart(999);
            Assert.IsNull(result);
        }

        /// <summary>
        /// Verifies that updating an existing user is successful.
        /// </summary>
        [TestMethod]
        public void UpdateUser_UpdatesSuccessfully()
        {
            var user = new User(1, "user1", "pass", 1);
            _db.Insert(user);

            user.Username = "updated";
            user.Password = "newpass";
            _db.Update(user);

            var updatedUser = _db.SelectUser("updated");
            Assert.IsNotNull(updatedUser);
            Assert.AreEqual("newpass", updatedUser.Password);
        }

        /// <summary>
        /// Verifies that updating a non-existent user throws RecordNotFoundException.
        /// </summary>
        [TestMethod]
        public void UpdateUser_NotFound_ThrowsException()
        {
            var user = new User(999, "nouser", "pass", 1);
            Assert.ThrowsException<RecordNotFoundException>(() => _db.Update(user));
        }

        /// <summary>
        /// Verifies that updating an existing part is successful.
        /// </summary>
        [TestMethod]
        public void UpdateAutoPart_UpdatesSuccessfully()
        {
            var part = new AutoPart(1, "part1", "brand", 10.0, 5);
            _db.Insert(part);

            part.Name = "updated";
            part.Price = 20.0;
            part.Stock = 10;
            _db.Update(part);

            var updatedPart = _db.SelectPart(1);
            Assert.AreEqual("updated", updatedPart.Name);
            Assert.AreEqual(20.0, updatedPart.Price);
            Assert.AreEqual(10, updatedPart.Stock);
        }

        /// <summary>
        /// Verifies that updating a part with negative stock throws InvalidStockException.
        /// </summary>
        [TestMethod]
        public void UpdateAutoPart_NegativeStock_ThrowsException()
        {
            var part = new AutoPart(1, "part1", "brand", 10.0, 5);
            _db.Insert(part);
            part.Stock = -5;
            Assert.ThrowsException<InvalidStockException>(() => _db.Update(part));
        }

        /// <summary>
        /// Verifies that updating a non-existent part throws RecordNotFoundException.
        /// </summary>
        [TestMethod]
        public void UpdateAutoPart_NotFound_ThrowsException()
        {
            var part = new AutoPart(999, "nonexistent", "brand", 10.0, 5);
            Assert.ThrowsException<RecordNotFoundException>(() => _db.Update(part));
        }

        /// <summary>
        /// Verifies that deleting an existing user works.
        /// </summary>
        [TestMethod]
        public void DeleteUser_DeletesSuccessfully()
        {
            var user = new User(1, "user1", "pass", 1);
            _db.Insert(user);

            _db.DeleteUser(1);
            var deletedUser = _db.SelectUser("user1");
            Assert.IsNull(deletedUser);
        }

        /// <summary>
        /// Verifies that deleting a non-existent user does not throw.
        /// </summary>
        [TestMethod]
        public void DeleteUser_NotExisting_NoException()
        {
            _db.DeleteUser(999);
        }

        /// <summary>
        /// Verifies that deleting an existing part works.
        /// </summary>
        [TestMethod]
        public void DeletePart_DeletesSuccessfully()
        {
            var part = new AutoPart(1, "part1", "brand", 10.0, 5);
            _db.Insert(part);

            _db.DeletePart(1);
            var deletedPart = _db.SelectPart(1);
            Assert.IsNull(deletedPart);
        }

        /// <summary>
        /// Verifies that deleting a non-existent part does not throw.
        /// </summary>
        [TestMethod]
        public void DeletePart_NotExisting_NoException()
        {
            _db.DeletePart(999);
        }

        /// <summary>
        /// Verifies that all users are deleted using ClearUsers.
        /// </summary>
        [TestMethod]
        public void ClearUsers_DeletesAllUsers()
        {
            _db.Insert(new User(1, "user1", "pass", 1));
            _db.Insert(new User(2, "user2", "pass", 1));
            _db.ClearUsers();

            var users = _db.SelectAllUsers();
            Assert.AreEqual(0, users.Count);
        }

        /// <summary>
        /// Verifies that all parts are deleted using ClearParts.
        /// </summary>
        [TestMethod]
        public void ClearParts_DeletesAllParts()
        {
            _db.Insert(new AutoPart(1, "part1", "brand", 10.0, 5));
            _db.Insert(new AutoPart(2, "part2", "brand", 10.0, 5));
            _db.ClearParts();

            var parts = _db.SelectAllParts();
            Assert.AreEqual(0, parts.Count);
        }

        /// <summary>
        /// Verifies that GetLastUserID returns the highest user ID.
        /// </summary>
        [TestMethod]
        public void GetLastUserID_ReturnsCorrectValue()
        {
            Assert.AreEqual(-1, _db.GetLastUserID());

            _db.Insert(new User(5, "user5", "pass", 1));
            _db.Insert(new User(10, "user10", "pass", 1));
            Assert.AreEqual(10, _db.GetLastUserID());
        }

        /// <summary>
        /// Verifies that GetLastPartID returns the highest part ID.
        /// </summary>
        [TestMethod]
        public void GetLastPartID_ReturnsCorrectValue()
        {
            Assert.AreEqual(-1, _db.GetLastPartID());

            _db.Insert(new AutoPart(7, "part7", "brand", 10.0, 5));
            _db.Insert(new AutoPart(9, "part9", "brand", 10.0, 5));
            Assert.AreEqual(9, _db.GetLastPartID());
        }
    }
}
