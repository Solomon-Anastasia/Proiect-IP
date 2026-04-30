/**************************************************************************
 *                                                                        *
 *  File:        PermissionDeniedException.cs                             *
 *  Copyright:   (c) 2025, Samachiș Eduard-Iulian                         *
 *  E-mail:      eduard-iulian.samachis@student.tuiasi.ro                 *
 *  Description: This file implements an exception for access right       *
 *               violations                                               *
 *                                                                        *
 **************************************************************************/



using System;

namespace Exceptions.AccessRightsExceptions
{
    /// <summary>
    /// Exception thrown when a user attempts to perform an action without the necessary permission.
    /// </summary>
    public class PermissionDeniedException : Exception
    {
        private string _message;

        /// <summary>
        /// Initializes a new instance of the PermissionDeniedException class with a default message.
        /// </summary>
        public PermissionDeniedException()
        {
            _message = "Nu ai acces pentru acestă acțiune!";
        }

        /// <summary>
        /// Initializes a new instance of the PermissionDeniedException class with a custom message.
        /// </summary>
        /// <param name="message">The custom error message.</param>
        public PermissionDeniedException(string message)
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
