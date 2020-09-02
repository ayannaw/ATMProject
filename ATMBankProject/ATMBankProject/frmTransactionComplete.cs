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
    public partial class frmTransactionComplete : Form
    {
        public frmTransactionComplete()
        {
            InitializeComponent();
        }

        private void btnBalanceYes_Click(object sender, EventArgs e)
        {
            lblCurrentBalances.Visible = true;
            lblSavings.Visible = true;
            lblChecking.Visible = true;
            txtChecking.Visible = true;
            txtSavings.Visible = true;

            btnBalanceNo.Enabled = false;

            decimal savingBalance = GlobalData.customer.getSavBalance();
            txtSavings.Text = savingBalance.ToString("C");

            decimal chkBalance = GlobalData.customer.getChkBalance();
            txtChecking.Text = chkBalance.ToString("C");

            lblAnotherTransaction.Visible = true;
            btnTransactionYes.Visible = true;
            btnTransactionNo.Visible = true;

        }   //end btnBalanceYes_Click

        private void btnBalanceNo_Click(object sender, EventArgs e)
        {
            lblAnotherTransaction.Visible = true;
            btnTransactionYes.Visible = true;
            btnTransactionNo.Visible = true;
        }

        private void btnTransactionYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beginning another transaction........");
            GlobalData.TransactionEntryForm = new frmTransactionEntry();
            GlobalData.TransactionEntryForm.Show();
            this.Close();
        }

        private void btnTransactionNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting AW Federal Credit Union......");
            MessageBox.Show(GlobalData.customer.toString());
            GlobalData.AWBank.CopyRemainingRecords();
            GlobalData.AWBank.closeFiles();
            GlobalData.PinEntryForm.Close();
            GlobalData.WelcomeForm.Close();
            GlobalData.TransactionEntryForm.Close();
            this.Close();
        }
    }
}
