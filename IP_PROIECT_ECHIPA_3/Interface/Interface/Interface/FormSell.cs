/**************************************************************************
 *                                                                        *
 *  File:        FormSell.cs                                              *
 *  Copyright:   (c) 2025, Lefter Andrei                                  *
 *  E-mail:      andrei.lefter@student.tuiasi.ro                          *
 *  Description: This file contains the implementation of Sell Product    *
 *               Interface where we can sell a product                    *
 *                                                                        *
 **************************************************************************/



using System;
using System.Windows.Forms;
using Exceptions.DataBaseExceptions;
using Exceptions.AccessRightsExceptions;
using AutoPartsManagementDLL;

namespace Interface
{
    /// <summary>
    /// Form used to sell an existing auto part. Implements validation and sale logic.
    /// </summary>
    public partial class FormSell : TemplateActionForm
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();
        private static FormSell _instance = null;

        /// <summary>
        /// Private constructor that initializes the form and connects the confirm button.
        /// </summary>
        private FormSell()
        {
            InitializeComponent();
            ConnectButton(buttonSell);
        }

        /// <summary>
        /// Gets the singleton instance of this form.
        /// </summary>
        /// <returns>The single instance of FormSell.</returns>
        public static FormSell GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormSell();
            }
            else
            {
                _instance.BringToFront();
            }
            return _instance;
        }

        /// <summary>
        /// Validates the input values for barcode and quantity.
        /// </summary>
        /// <returns>True if input is valid; otherwise, false.</returns>
        protected override bool ValidateInput()
        {
            int id;
            if (!int.TryParse(textBoxBarcode.Text, out id))
            {
                MessageBox.Show("Invalid Barcode.");
                return false;
            }

            if (numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity shoud be >= 1.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Executes the operation to sell the part.
        /// </summary>
        protected override void ExecuteAction()
        {
            int partId = Convert.ToInt32(textBoxBarcode.Text);
            int quantity = Convert.ToInt32(numericUpDownQuantity.Value);

            _util.SellPart(partId, quantity);
            MessageBox.Show("Part sold sucessfully.");
            this.Close();
        }
    }
}
