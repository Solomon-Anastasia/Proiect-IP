/**************************************************************************
 *                                                                        *
 *  File:        FormAddToStock.cs                                        *
 *  Copyright:   (c) 2025, Lefter Andrei                                  *
 *  E-mail:      andrei.lefter@student.tuiasi.ro                          *
 *  Description: This file contains the implementation of Add To Stock    *
 *               Interface where we can add new stocks of a specific      *
 *               product                                                  *
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
    /// Form used to add stock quantity to an existing part.
    /// </summary>
    public partial class FormAddToStock : TemplateActionForm
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();
        static private FormAddToStock _instance = null;

        /// <summary>
        /// Private constructor that initializes form components and connects the confirm button.
        /// </summary>
        private FormAddToStock()
        {
            InitializeComponent();
            ConnectButton(buttonAddToStock);
        }

        /// <summary>
        /// Gets the singleton instance of this form.
        /// </summary>
        /// <returns>The single instance of FormAddToStock.</returns>
        static public FormAddToStock GetInstance()
        {
            if (_instance == null || _instance.IsDisposed )
            {
                _instance = new FormAddToStock();
            }
            else
            {
                _instance.BringToFront();
            }
            return _instance;
        }

        /// <summary>
        /// Validates the input values for part ID and quantity.
        /// </summary>
        /// <returns>True if valid; otherwise, false.</returns>
        protected override bool ValidateInput()
        {
            int id;
            if (!int.TryParse(textBoxBarcode.Text, out id))
            {
                MessageBox.Show("ID invalid format.");
                return false;
            }

            if (numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than 1.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Executes the operation to add the given quantity to the part's stock.
        /// </summary>
        protected override void ExecuteAction()
        {
            int partId = Convert.ToInt32(textBoxBarcode.Text);
            int quantity = Convert.ToInt32(numericUpDownQuantity.Value);

            _util.AddToStock(partId, quantity);
            MessageBox.Show("Stock updated successfully.");
            this.Close();
        }

        /// <summary>
        /// Click event placeholder for add-to-stock button (unused).
        /// </summary>
        private void buttonAddToStock_Click(object sender, EventArgs e)
        {

        }
    }
}
