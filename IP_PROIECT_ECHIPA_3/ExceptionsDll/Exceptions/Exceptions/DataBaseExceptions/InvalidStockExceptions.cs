/**************************************************************************
 *                                                                        *
 *  File:        InvalidStockException.cs                                 *
 *  Copyright:   (c) 2025, Samachiș Eduard-Iulian                         *
 *  E-mail:      eduard-iulian.samachis@student.tuiasi.ro                 *
 *  Description: This file defines an exception for negative stock values *
 *                                                                        *
 **************************************************************************/



using System;

namespace Exceptions.DataBaseExceptions
{
    /// <summary>
    /// Exception thrown when an invalid stock value is encountered.
    /// </summary>
    public class InvalidStockException : Exception
    {
        private string _message;

        /// <summary>
        /// Initializes a new instance of the InvalidStockException class with a default message.
        /// </summary>
        public InvalidStockException()
        {
            _message = "Stocul nu poate fi negativ.";
        }

        /// <summary>
        /// Initializes a new instance of the InvalidStockException class with a custom message.
        /// </summary>
        /// <param name="message">The custom error message.</param>
        public InvalidStockException(string message)
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
