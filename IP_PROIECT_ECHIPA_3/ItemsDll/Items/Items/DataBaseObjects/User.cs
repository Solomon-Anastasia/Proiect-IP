/**************************************************************************
 *                                                                        *
 *  File:        User.cs                                                  *
 *  Copyright:   (c) 2025, Sfichi Alin-Ionuț                              *
 *  E-mail:      alin-ionut.sfichi@student.tuiasi.ro                      *
 *  Description: This file implement the data class for an user           *
 *                                                                        *
 **************************************************************************/



namespace Items.DataBaseObjects
{
    /// <summary>
    /// Represents a user in the system, including credentials and role-based rights.
    /// </summary>
    public class User
    {
        private int _id;
        private string _username;
        private string _password;
        private int _rights;

        /// <summary>
        /// Initializes a new instance of the User class with specified credentials and rights.
        /// </summary>
        /// <param name="id">The unique identifier of the user.</param>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The hashed password of the user.</param>
        /// <param name="rights">The access rights of the user.</param>
        public User(int id, string username, string password, int rights)
        {
            _id = id;
            _username = username;
            _password = password;
            _rights = rights;
        }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public int Id { get { return _id; } set { _id = value; } }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get { return _username; } set { _username = value; } }

        /// <summary>
        /// Gets or sets the user's password.
        /// </summary>
        public string Password { get { return _password; } set { _password = value; } }

        /// <summary>
        /// Gets or sets the user's rights/role level.
        /// </summary>
        public int Rights { get { return _rights; } set { _rights = value; } }

        /// <summary>
        /// Returns a string that represents the current user.
        /// </summary>
        /// <returns>A string with user ID, username, password, and rights.</returns>
        public string ToString()
        {
            return _id + " " + _username + " " + _password + " " + _rights;
        }
    }
}
