/**************************************************************************
 *                                                                        *
 *  File:        TemplateActionForm.cs                                    *
 *  Copyright:   (c) 2025, Lefter Andrei                                  *
 *  E-mail:      andrei.lefter@student.tuiasi.ro                          *
 *  Description: This file contains the implementation of Base form       *
 *               with confirm button logic and input check.               *
 *                                                                        *
 **************************************************************************/



using System;
using System.Windows.Forms;

namespace Interface
{
    public class TemplateActionForm : Form
    {
        protected Button buttonConfirm;

        // No constructor code to create a button!
        protected void ConnectButton(Button confirmButton)
        {
            buttonConfirm = confirmButton;
            buttonConfirm.Click += OnConfirmClick;
        }

        private void OnConfirmClick(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Invalid data.");
                return;
            }

            try
            {
                ExecuteAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        protected virtual bool ValidateInput() { return true; }
        protected virtual void ExecuteAction() { }
    }
}
