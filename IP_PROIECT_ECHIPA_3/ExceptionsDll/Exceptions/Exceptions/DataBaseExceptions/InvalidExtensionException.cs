/**************************************************************************
 *                                                                        *
 *  File:        InvalidExtensionException.cs                             *
 *  Copyright:   (c) 2025, Samachiș Eduard-Iulian                         *
 *  E-mail:      eduard-iulian.samachis@student.tuiasi.ro                 *
 *  Description: This file defines an exception for invalid DB file       *
 *               extensions                                               *
 *                                                                        *
 **************************************************************************/



using System;

namespace Exceptions.DataBaseExceptions
{
    /// <summary>
    /// Exception thrown when a file with an invalid extension is encountered.
    /// </summary>
    public class InvalidExtensionException : Exception
    {
        private string _message;

        /// <summary>
        /// Initializes a new instance of the InvalidExtensionException class with a default message.
        /// </summary>
        public InvalidExtensionException()
        {
            _message = "Extensie fișier invalidă!";
        }

        /// <summary>
        /// Initializes a new instance of the InvalidExtensionException class with a custom message.
        /// </summary>
        /// <param name="message">The custom error message.</param>
        public InvalidExtensionException(string message)
        {
            _message = message;
        }

        /// <summary>
        /// Gets the error message that explains the reason for the exception.
        /// </summary>
        public override string Message
        {
            get { return _message; }
        }
    }
}
