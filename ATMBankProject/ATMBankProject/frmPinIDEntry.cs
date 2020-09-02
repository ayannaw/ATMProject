using ATMBankProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMBankProject
{
    public partial class frmPinEntry : Form
    {
        public frmPinEntry()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string currentPin = txtPin.Text;
            string currentName = txtName.Text;
            MessageBox.Show("You entered the name " + currentName + " with the pin number: " + currentPin, "Current Entry");
            if ((currentPin.Length > 4) || (currentPin.Length < 4))
            {
                GlobalData.currentTries--;
                MessageBox.Show("Invalid Pin Number Length. \n Pin number must be 4 characters long. \n You have " + GlobalData.currentTries + " attempts left.", "Invalid Pin");
                txtPin.Text = "";
                txtPin.Focus();
            }
            else
            {
                if(GlobalData.customer.verifyNameAndPin(currentPin, currentName))
                {
                    MessageBox.Show("Name and Pin Matched.", "Success");
                    GlobalData.TransactionEntryForm.Show();

                }
                else
                {
                    if(currentName != (GlobalData.customer.getName()))
                    {
                        GlobalData.currentTries--;
                        MessageBox.Show("Name is incorrect. \n You have " + GlobalData.currentTries + " attempts left.", 
                            "Try Again.");
                        txtName.Text = "";
                        txtName.Focus();
                    }
                    if(currentPin != (GlobalData.customer.getPinNumber()))
                    {
                        GlobalData.currentTries--;
                        MessageBox.Show("The pin number is incorrect. \n You have " + GlobalData.currentTries + " attempts left.", "Try Again.");
                        txtPin.Text = "";
                        txtPin.Focus();
                    }
                }
            }   //end if/else

        }
    }
}
