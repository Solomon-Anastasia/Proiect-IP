/**************************************************************************
 *                                                                        *
 *  File:        RecordNotFoundException.cs                               *
 *  Copyright:   (c) 2025, Samachiș Eduard-Iulian                         *
 *  E-mail:      eduard-iulian.samachis@student.tuiasi.ro                 *
 *  Description: This file defines an exception for missing table records *
 *                                                                        *
 **************************************************************************/



using System;

namespace Exceptions.DataBaseExceptions
{
    /// <summary>
    /// Exception thrown when a database record is not found.
    /// </summary>
    public class RecordNotFoundException : Exception
    {
        private string _message;

        /// <summary>
        /// Initializes a new instance of the RecordNotFoundException class with a default message.
        /// </summary>
        public RecordNotFoundException()
        {
            _message = "Înregistrarea nu a fost găsită în baza de date.";
        }

        /// <summary>
        /// Initializes a new instance of the RecordNotFoundException class with a custom message.
        /// </summary>
        /// <param name="message">The custom error message.</param>
        public RecordNotFoundException(string message)
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
