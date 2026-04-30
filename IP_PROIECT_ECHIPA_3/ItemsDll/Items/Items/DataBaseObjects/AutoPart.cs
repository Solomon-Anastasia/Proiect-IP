/**************************************************************************
 *                                                                        *
 *  File:        Product.cs                                               *
 *  Copyright:   (c) 2025, Sfichi Alin-Ionuț                              *
 *  E-mail:      alin-ionut.sfichi@student.tuiasi.ro                      *
 *  Description: This file implement the data class for a product         *
 *                                                                        *
 **************************************************************************/



namespace Items.DataBaseObjects
{
    /// <summary>
    /// Represents an auto part in the system, including its identifying information and stock status.
    /// </summary>
    public class AutoPart
    {
        private int _id;
        private string _name;
        private string _brand;
        private double _price;
        private int _stock;

        /// <summary>
        /// Initializes a new instance of the AutoPart class with specified details.
        /// </summary>
        /// <param name="id">The unique identifier for the part.</param>
        /// <param name="name">The name of the part.</param>
        /// <param name="brand">The brand of the part.</param>
        /// <param name="price">The price of the part.</param>
        /// <param name="stock">The current stock quantity.</param>
        public AutoPart(int id, string name, string brand, double price, int stock)
        {
            _id = id;
            _name = name;
            _brand = brand;
            _price = price;
            _stock = stock;
        }

        /// <summary>
        /// Gets or sets the part ID.
        /// </summary>
        public int Id { get { return _id; } set { _id = value; } }

        /// <summary>
        /// Gets or sets the name of the part.
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }

        /// <summary>
        /// Gets or sets the brand of the part.
        /// </summary>
        public string Brand { get { return _brand; } set { _brand = value; } }

        /// <summary>
        /// Gets or sets the price of the part.
        /// </summary>
        public double Price { get { return _price; } set { _price = value; } }

        /// <summary>
        /// Gets or sets the stock quantity of the part.
        /// </summary>
        public int Stock { get { return _stock; } set { _stock = value; } }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string containing part details.</returns>
        public string ToString()
        {
            return _id + " " + _name + " " + _brand + " " + _price + " " + _stock;
        }
    }
}
