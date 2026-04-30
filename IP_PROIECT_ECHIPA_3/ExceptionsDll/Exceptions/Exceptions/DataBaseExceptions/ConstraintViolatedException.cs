/**************************************************************************
 *                                                                        *
 *  File:        ConstraintViolatedException.cs                           *
 *  Copyright:   (c) 2025, Samachiș Eduard-Iulian                         *
 *  E-mail:      eduard-iulian.samachis@student.tuiasi.ro                 *
 *  Description: This file defines an exception for constraint violations *
 *                                                                        *
 **************************************************************************/



using System;

namespace Exceptions.DataBaseExceptions
{
    /// <summary>
    /// Exception thrown when a unique or primary key constraint is violated in the database.
    /// </summary>
    public class ConstraintViolatedException : Exception
    {
        private string _message;

        /// <summary>
        /// Initializes a new instance of the ConstraintViolatedException class with a default message.
        /// </summary>
        public ConstraintViolatedException()
        {
            _message = "Unique or primary key constraint violated.";
        }

        /// <summary>
        /// Initializes a new instance of the ConstraintViolatedException class with a custom message.
        /// </summary>
        /// <param name="message">The custom error message.</param>
        public ConstraintViolatedException(string message)
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
