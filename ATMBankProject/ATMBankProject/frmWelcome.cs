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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }
        //GlobalData.FormsCode = "WelcomeForm";
        private void btnFindMe_Click(object sender, EventArgs e)
        {
            
            string accountNumber = txtAccNumber.Text;
            if (accountNumber == "")
            {
                GlobalData.currentTries--;
                MessageBox.Show("Account Number cannot be blank.\n You have " + GlobalData.currentTries + " attempts left.", "Invalid Entry");
                txtAccNumber.Text = "";
                txtAccNumber.Focus();
            }
            else if (accountNumber.Length > 5) 
            {
                GlobalData.currentTries--;
                MessageBox.Show("Account Number cannot be longer than 5 characters.\n You have " + GlobalData.currentTries + " attempts left.", "Invalid Entry");
                txtAccNumber.Text = "";
                txtAccNumber.Focus();
            }
            else if (accountNumber.Length < 5)
            {
                GlobalData.currentTries--;
                MessageBox.Show("Account Number cannot be shorter than 5 characters.\n You have " + GlobalData.currentTries + " attempts left.", "Invalid Entry");
                txtAccNumber.Text = "";
                txtAccNumber.Focus();
            }
            else
            {
                bool isACustomer = false;
                string currentCustomer = GlobalData.AWBank.findCustomerRecord(accountNumber, ref isACustomer);
                if(isACustomer)
                {
                    GlobalData.PinEntryForm.Show();
                    GlobalData.customer.createCustomer(currentCustomer);
                }
                else
                {
                    GlobalData.currentTries--;
                    MessageBox.Show("Account not found. \n" +
                        "You have " + GlobalData.currentTries + " attempts left.");
                    txtAccNumber.Text = "";
                    txtAccNumber.Focus();
                }   //end of if
            }   //end of if
            if (GlobalData.currentTries == 0)
            {
                MessageBox.Show("You are out of attempts. Please contact a manager.", "Maxium Attempts Reached.");
                txtAccNumber.Enabled = false;
                btnFindMe.Enabled = false;
                btnFindMe.BackColor = Color.Gray;
                GlobalData.WelcomeForm.Close();
            }   //end if
        }   //end btnFindMe_click
    }   //end frmWelcome
}   //end namespace
