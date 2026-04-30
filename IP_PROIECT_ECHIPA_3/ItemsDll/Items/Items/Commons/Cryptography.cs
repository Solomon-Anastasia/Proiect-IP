/**************************************************************************
 *                                                                        *
 *  File:        Cryptography.cs                                          *
 *  Copyright:   (c) 2025, Sfichi Alin-Ionuț                              *
 *  E-mail:      alin-ionut.sfichi@student.tuiasi.ro                      *
 *  Description: This file implements password encryption                 *
 *                                                                        *
 **************************************************************************/



using System;
using System.Security.Cryptography;
using System.Text;

namespace Items.Commons
{
    /// <summary>
    /// Provides methods for hashing strings using cryptographic algorithms.
    /// </summary>
    public class Cryptography
    {
        /// <summary>
        /// Computes a SHA1 hash of the input string and returns it as a Base64-encoded string.
        /// </summary>
        /// <param name="str">The input string to hash.</param>
        /// <returns>A Base64 string representing the SHA1 hash.</returns>
        public static string HashString(string str)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] buf = Encoding.UTF8.GetBytes(str);
            byte[] result = sha.ComputeHash(buf);
            return Convert.ToBase64String(result);
        }
    }
}
