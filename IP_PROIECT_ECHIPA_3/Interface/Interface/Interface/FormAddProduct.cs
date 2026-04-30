/**************************************************************************
 *                                                                        *
 *  File:        FormAddProducts.cs                                       *
 *  Copyright:   (c) 2025, Lefter Andrei                                  *
 *  E-mail:      andrei.lefter@student.tuiasi.ro                          *
 *  Description: This file contains the implementation of Add New Product *
 *               Interface where we can add new products and some details *
 *               about them                                               *
 *                                                                        *
 **************************************************************************/



using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Items.DataBaseObjects;
using Exceptions.AccessRightsExceptions;
using Exceptions.DataBaseExceptions;
using AutoPartsManagementDLL;

namespace Interface
{
    /// <summary>
    /// Form used to add new auto parts to the system. Utilizes a template form with validation and confirmation logic.
    /// </summary>
    public partial class FormAddProduct : TemplateActionForm
    {
        private ValidAutoParts _validParts = ValidAutoParts.GetInstance();
        private ProxyActionManager _util = ProxyActionManager.GetInstance();
        static private FormAddProduct _formAddProduct = null;

        /// <summary>
        /// Private constructor to prevent direct instantiation. Initializes form controls and category dropdown.
        /// </summary>
        private FormAddProduct()
        {
            InitializeComponent();

            foreach (string brand in _validParts.Parts.Keys)
            {
                comboBoxCategory.Items.Add(brand);
            }

            ConnectButton(buttonAddProduct);
        }

        /// <summary>
        /// Returns a singleton instance of the form, bringing it to front if already open.
        /// </summary>
        /// <returns>Instance of FormAddProduct.</returns>
        public static FormAddProduct GetInstace()
        {
            if (_formAddProduct == null || _formAddProduct.IsDisposed)
            {
                _formAddProduct = new FormAddProduct();
            }
            else
            {
                _formAddProduct.BringToFront();
            }
            return _formAddProduct;
        }

        /// <summary>
        /// Event triggered when a category is selected. Populates the product dropdown based on brand.
        /// </summary>
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brand = comboBoxCategory.SelectedItem.ToString();
            List<string> models = _validParts.Parts[brand];

            comboBoxProduct.Items.Clear();
            foreach (string model in models)
            {
                comboBoxProduct.Items.Add(model);
            }
        }

        /// <summary>
        /// Validates user input before submitting the form.
        /// </summary>
        /// <returns>True if input is valid; otherwise, false.</returns>
        protected override bool ValidateInput()
        {
            if (!comboBoxCategory.Items.Contains(comboBoxCategory.Text))
            {
                MessageBox.Show("Please select a valid brand.");
                return false;
            }

            if (!comboBoxProduct.Items.Contains(comboBoxProduct.Text))
            {
                MessageBox.Show("Please select a valid part.");
                return false;
            }

            int barcode;
            if (!int.TryParse(textBoxBarcode.Text, out barcode))
            {
                MessageBox.Show("Invalid barcode!");
                return false;
            }

            if (numericUpDownPrice.Value <= 0 || numericUpDownStock.Value < 0)
            {
                MessageBox.Show("Invalid values for price/stock!");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Executes the action to add a new part to the database after validation.
        /// </summary>
        protected override void ExecuteAction()
        {
            int barcode = Convert.ToInt32(textBoxBarcode.Text);
            string name = comboBoxProduct.Text;
            string brand = comboBoxCategory.Text;
            double price = Convert.ToDouble(numericUpDownPrice.Value);
            int stock = Convert.ToInt32(numericUpDownStock.Value);

            AutoPart part = new AutoPart(barcode, name, brand, price, stock);
            _util.AddNewPart(part);

            MessageBox.Show("Part added successfully.");
            this.Close();
        }
    }
}
