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
    public partial class frmTransactionEntry : Form
    {
        public frmTransactionEntry()
        {
            InitializeComponent();
        }
        private int buttonID;
        private decimal transactionAmount;
        private void frmTransactionEntry_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Your current savings balance is " + GlobalData.customer.getSavBalance().ToString("C") + " and your current checkings balance is " + GlobalData.customer.getChkBalance().ToString("C"), "Current Balances");
            resetButtons();
        }

        private void btnSavDeposit_Click(object sender, EventArgs e)
        {
            buttonID = 1;
            btnSavBalance.BackColor = Color.Salmon;
            btnSavBalance.Enabled = false;
            disableAllTransactionButtons();
            showDollarAmount();
        }   //end btnSavBalance_click

        private void btnChkDeposit_Click(object sender, EventArgs e)
        {
            buttonID = 2;
            btnChkDeposit.BackColor = Color.Salmon;
            btnChkDeposit.Enabled = false;
            disableAllTransactionButtons();
            showDollarAmount();
        }   //end btnChkDeposit_Click

        private void btnSavWithdrawal_Click(object sender, EventArgs e)
        {
            buttonID = 3;
            btnSavWithdrawal.BackColor = Color.Salmon;
            btnSavWithdrawal.Enabled = false;
            disableAllTransactionButtons();
            showDollarAmount();
        }   //end btnSavWithdrawal_Click

        private void btnChkWithdrawal_Click(object sender, EventArgs e)
        {
            buttonID = 4;
            btnChkWithdrawal.BackColor = Color.Salmon;
            btnChkWithdrawal.Enabled = false;
            disableAllTransactionButtons();
            showDollarAmount();
        }   //end btnChkWithdrawal_Click

        private void btnSavBalance_Click(object sender, EventArgs e)
        {
            buttonID = 5;
            btnSavBalance.BackColor = Color.Salmon;
            btnSavBalance.Enabled = false;
            disableAllTransactionButtons();
            lblBalanceOnly.Visible = true;
            btnYes.Visible = true;
            btnNo.Visible = true;
        }   //end btnSavBalance_Click

        private void btnChkBalance_Click(object sender, EventArgs e)
        {
            buttonID = 6;
            btnChkBalance.BackColor = Color.Salmon;
            btnChkBalance.Enabled = false;
            disableAllTransactionButtons();
            lblBalanceOnly.Visible = true;
            btnYes.Visible = true;
            btnNo.Visible = true;
        }   //end btnChkBalance_Click

        private void btnTransferSavChk_Click(object sender, EventArgs e)
        {
            buttonID = 7;
            btnTransferSavChk.BackColor = Color.Salmon;
            btnTransferSavChk.Enabled = false;
            disableAllTransactionButtons();
            showDollarAmount();
        }   //end btnTransferSavChk_Click

        private void btnTransferChkSav_Click(object sender, EventArgs e)
        {
            buttonID = 8;
            btnTransferChkSav.BackColor = Color.Salmon;
            btnTransferChkSav.Enabled = false;
            disableAllTransactionButtons();
            showDollarAmount();
        }   //end btnTransferChkSav_Click

        //shows the options for inserting the dollar amount
        private void showDollarAmount()
        {
            lblDollarAmount.Visible = true;
            txtDollarAmount.Visible = true;
            btnOK.Visible = true;
        }   //end showDollarAmount

        //disables all buttons
        private void disableAllTransactionButtons()
        {
            btnSavDeposit.Enabled = false;
            btnSavBalance.Enabled = false;
            btnSavWithdrawal.Enabled = false;
            btnTransferSavChk.Enabled = false;

            btnChkDeposit.Enabled = false;
            btnChkBalance.Enabled = false;
            btnChkWithdrawal.Enabled = false;
            btnTransferChkSav.Enabled = false;
        }   //end disableAllTransactionButtons
        //enables and resets all buttons for the select again option
        private void resetButtons()
        {
            btnSavBalance.BackColor = Color.Gainsboro;
            btnSavBalance.Enabled = true;

            btnSavDeposit.BackColor = Color.Gainsboro;
            btnSavDeposit.Enabled = true;

            btnSavWithdrawal.BackColor = Color.Gainsboro;
            btnSavWithdrawal.Enabled = true;

            btnTransferSavChk.BackColor = Color.Gainsboro;
            btnTransferSavChk.Enabled = true;

            btnChkBalance.BackColor = Color.Gainsboro;
            btnChkBalance.Enabled = true;

            btnChkDeposit.BackColor = Color.Gainsboro;
            btnChkDeposit.Enabled = true;

            btnChkWithdrawal.BackColor = Color.Gainsboro;
            btnChkWithdrawal.Enabled = true;

            btnTransferChkSav.BackColor = Color.Gainsboro;
            btnTransferChkSav.Enabled = true;

            lblDollarAmount.Visible = false;
            txtDollarAmount.Visible = false;
            txtDollarAmount.Text = "";
            btnOK.Visible = false;

            lblBalanceOnly.Visible = false;
            txtSelection.Visible = false;

            btnYes.Visible = false;
            btnNo.Visible = false;
        }   //end resetButtons

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (txtDollarAmount.Text == "")
            {
                MessageBox.Show("Dollar Amount cannot be blank.", "Blank Entry");
                txtDollarAmount.Focus();
            }   //end if (txtDollarAmount.Text == "")
            else
            {
                transactionAmount = Convert.ToDecimal(txtDollarAmount.Text.Replace("$","").Replace("$",""));
                string selectionText = "You selected " + transactionAmount.ToString("C") + " and the marked transaction. Is this correct?";
                if (buttonID == 3 /*savings withdrawal*/ || buttonID == 4 /*checkings withdrawal*/)
                {
                    if (transactionAmount > GlobalData.AWBank.getMaxWD())    //checks to see if the withdrawal amount exceeds the daily withdrawal amount
                    {
                        MessageBox.Show("You cannot withdraw more than " + GlobalData.AWBank.getMaxWD(), "Daily withdrawal amount exceeded");
                        txtDollarAmount.Text = "";
                        txtDollarAmount.Focus();
                    } //end if (dollarAmount > GlobalData.AWBank.getMaxWD())
                    else if (buttonID == 3 && (transactionAmount > GlobalData.customer.getSavBalance())) //checks to see if the withdrawal amount isn't more than the savings balance
                    {
                        MessageBox.Show("Withdrawal amount exceeds current savings balance.", "Invalid Entry");
                        txtDollarAmount.Text = "";
                        txtDollarAmount.Focus();
                    }   //end else if (buttonID == 3 && (dollarAmount > GlobalData.customer.getSavBalance()) )
                    else if (buttonID == 4 && (transactionAmount > GlobalData.customer.getChkBalance())) //checks to see if the withdrawal amount isn't more than the checkings balance
                    {
                        MessageBox.Show("Withdrawal amount exceeds current checkings balance.", "Invalid Entry");
                        txtDollarAmount.Text = "";
                        txtDollarAmount.Focus();
                    }   //end else if (buttonID == 4 && (dollarAmount > GlobalData.customer.getChkBalance()))
                    else
                    {
                        txtSelection.Text = selectionText;
                        txtSelection.Visible = true;
                        btnYes.Visible = true;
                        btnNo.Visible = true;
                    }   //end else
                }   //end if(buttonID == 3 || buttonID == 4)
                else if (buttonID == 7 /*tranfer from sav to chk*/ || buttonID == 8 /*transer from chk to sav*/)
                {
                    if(buttonID == 7 && (transactionAmount > GlobalData.customer.getSavBalance()))   //checks if the transfer amount from savings does not exceed savings balance
                    {
                        MessageBox.Show("Transfer amount exceeds current savings balance.", "Invalid Entry");
                        txtDollarAmount.Text = "";
                        txtDollarAmount.Focus();
                    }   //end if (dollarAmount > GlobalData.customer.getSavBalance() && (dollarAmount > GlobalData.customer.getSavBalance()))
                    else if (buttonID == 8 && (transactionAmount > GlobalData.customer.getChkBalance())) //checks if the transfer amount from checkings to savings does not exceed checkings balance amount
                    {
                        MessageBox.Show("Transfer amount exceeds current checkings balance.", "Invalid Entry");
                        txtDollarAmount.Text = "";
                        txtDollarAmount.Focus();
                    }   //end else if (buttonID == 8 && (dollarAmount > GlobalData.customer.getChkBalance()))
                    else
                    {
                        txtSelection.Text = selectionText;
                        txtSelection.Visible = true;
                        btnYes.Visible = true;
                        btnNo.Visible = true;
                    }   //end else
                }   //end else if (buttonID == 7 || buttonID == 8)
                else
                {
                    txtSelection.Text = selectionText;
                    txtSelection.Visible = true;
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                }   //end else
            }   //end else
        }   //end btnOK_Click

        private void btnYes_Click(object sender, EventArgs e)
        {
            GlobalData.customer.modifyRecord(buttonID, transactionAmount);
            GlobalData.TransactionCompleteForm = new frmTransactionComplete();
            GlobalData.TransactionCompleteForm.Show();
        }   //end btnYes_Click

        private void btnNo_Click(object sender, EventArgs e)
        {
            resetButtons();
        }
    }   //end frmTransactionEntry
}   //end namespace
