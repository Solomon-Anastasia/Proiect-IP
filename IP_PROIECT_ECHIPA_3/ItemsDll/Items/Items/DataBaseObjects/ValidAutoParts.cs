/**************************************************************************
 *                                                                        *
 *  File:        ValidProducts.cs                                         *
 *  Copyright:   (c) 2025, Sfichi Alin-Ionuț                              *
 *  E-mail:      alin-ionut.sfichi@student.tuiasi.ro                      *
 *  Description: This file deals with management of valid products in     *
 *               database table.                                          *
 *                                                                        *
 **************************************************************************/



using System;
using System.Collections.Generic;
using System.IO;

namespace Items.DataBaseObjects
{
    /// <summary>
    /// Singleton class that holds a list of valid auto parts, organized by brand.
    /// Data is loaded from a text file.
    /// </summary>
    public class ValidAutoParts
    {
        private Dictionary<string, List<string>> _parts = new Dictionary<string, List<string>>();
        private static ValidAutoParts _instance;

        /// <summary>
        /// Private constructor that loads valid auto parts from a text file.
        /// </summary>
        private ValidAutoParts()
        {
            string[] lines = File.ReadAllLines("ValidAutoParts.txt");
            foreach (string line in lines)
            {
                string[] elements = line.Split(':');
                string brand = elements[0];
                string[] models = elements[1].Split(',');
                _parts.Add(brand, new List<string>(models));
            }
        }

        /// <summary>
        /// Gets the singleton instance of the ValidAutoParts class.
        /// </summary>
        /// <returns>The single instance of ValidAutoParts.</returns>
        public static ValidAutoParts GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ValidAutoParts();
            }
            return _instance;
        }

        /// <summary>
        /// Gets the dictionary of valid parts grouped by brand.
        /// </summary>
        public Dictionary<string, List<string>> Parts
        {
            get { return _parts; }
        }
    }
}
