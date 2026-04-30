/**************************************************************************
 *                                                                        *
 *  File:        FormUpdatePrice.cs                                       *
 *  Copyright:   (c) 2025, Lefter Andrei                                  *
 *  E-mail:      andrei.lefter@student.tuiasi.ro                          *
 *  Description: This file contains the implementation of Update Price    *
 *               Interface where we can update the price                  *
 *                                                                        *
 **************************************************************************/



using System;
using System.Windows.Forms;
using Exceptions.DataBaseExceptions;
using Exceptions.AccessRightsExceptions;
using AutoPartsManagementDLL;
using System.IO;
using System.Dynamic;

namespace Interface
{
    /// <summary>
    /// Form used to update the price of an existing auto part.
    /// </summary>
    public partial class FormUpdatePrice : TemplateActionForm
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public static FormUpdatePrice _instance = null;

        /// <summary>
        /// Private constructor that initializes the form and connects the confirm button.
        /// </summary>
        private FormUpdatePrice()
        {
            InitializeComponent();
            ConnectButton(buttonUpdatePrice); // asigură-te că în Designer are acest nume
        }

        /// <summary>
        /// Gets the singleton instance of this form.
        /// </summary>
        /// <returns>The single instance of FormUpdatePrice.</returns>
        public static FormUpdatePrice GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormUpdatePrice();
            }
            else
            {
                _instance.BringToFront();
            }
            return _instance;
        }

        /// <summary>
        /// Validates the input for part ID and new price.
        /// </summary>
        /// <returns>True if input is valid; otherwise, false.</returns>
        protected override bool ValidateInput()
        {
            int partId;
            if (!int.TryParse(textBoxBarcode.Text, out partId))
            {
                MessageBox.Show("Part code should be valid.");
                return false;
            }

            if (numericUpDownNewPrice.Value <= 0)
            {
                MessageBox.Show("Price must be greater than 0");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Executes the price update operation for the specified part.
        /// </summary>
        protected override void ExecuteAction()
        {
            int partId = Convert.ToInt32(textBoxBarcode.Text);
            double price = Convert.ToDouble(numericUpDownNewPrice.Value);

            _util.UpdatePartPrice(partId, price);
            MessageBox.Show("Price updated successfuly.");
            this.Close();
        }
    }
}
