using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBankProject.Classes
{
    public class Customer
    {
        string customer;
        private string accountNumber;
        private string pinNumber;
        private string name;
        private decimal chkBalance;
        private decimal savBalance;
        

        //constructor
        public Customer()
        {

        } //end constructor
        
        //
        public void createCustomer(string account)
        {
            this.customer = account;
            string[] customerInfo = customer.Split('*');
            accountNumber = customerInfo[0];
            name = customerInfo[1];
            pinNumber = customerInfo[2];
            chkBalance = Convert.ToDecimal(customerInfo[3].Replace("$", "").Replace(",", ""));
            savBalance = Convert.ToDecimal(customerInfo[4].Replace("$", "").Replace(",", ""));
        }
        public string getAccountNumber ()
        {
            return accountNumber;
        }

        public string getPinNumber()
        {
            return pinNumber;
        }

        public string getName()
        {
            return name;
        }

        public decimal getChkBalance()
        {
            return chkBalance;
        }
        public decimal getSavBalance()
        {
            return savBalance;
        }
        /*given a customer account (entered by the customer) and a customer record (read from the currentFile) checks to see if the user account matches the record account (the first field of the record).  Returns True or False.*/
        public bool customerMatch(string account, string nextRecord)
        {
            bool result;
            if (account.Split('*')[0] == nextRecord.Split('*')[0])  //if the account numbers match
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
        public bool verifyNameAndPin(string pin, string name) 
        {
            bool result;
            if (this.name.Equals(name, StringComparison.OrdinalIgnoreCase) && this.pinNumber.Equals(pin))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }//end verifyNameAndPin

        public void modifyRecord(int transactionCode, decimal amount) 
        {
            string updatedRecord = accountNumber + "*" + name + "*" + pinNumber;
            if (transactionCode == 1)   //savings deposit
            {
                savBalance = savBalance + amount;
                updatedRecord = updatedRecord + "*" + chkBalance.ToString("C") + "*" + savBalance.ToString("C");
            }
            else if (transactionCode == 2)  //checkings deposit
            {
                chkBalance = chkBalance + amount;
                updatedRecord = updatedRecord + "*" + chkBalance.ToString("C") + "*" + savBalance.ToString("C");
            }
            else if (transactionCode == 3)  //savings withdrawal
            {
                savBalance = savBalance - amount;
                updatedRecord = updatedRecord + "*" + chkBalance.ToString("C") + "*" + savBalance.ToString("C");
            }
            else if (transactionCode == 4)  //checkings withdrawal
            {
                chkBalance = chkBalance - amount;
                updatedRecord = updatedRecord + "*" + chkBalance.ToString("C") + "*" + savBalance.ToString("C");
            }
            else if (transactionCode == 5) //saving balance
            {
                updatedRecord = updatedRecord + "*" + chkBalance.ToString("C") + "*" + savBalance.ToString("C");
            }
            else if (transactionCode == 6)  //checking balance
            {
                updatedRecord = updatedRecord + "*" + chkBalance.ToString("C") + "*" + savBalance.ToString("C");
            }
            else if (transactionCode == 7)  //Transfer from saving to checking
            {
                savBalance = savBalance - amount;
                chkBalance = chkBalance + amount;
                updatedRecord = updatedRecord + "*" + chkBalance.ToString("C") + "*" + savBalance.ToString("C");
            }
            else if (transactionCode == 8)  //transfer from checkings to savings
            {
                savBalance = savBalance + amount;
                chkBalance = chkBalance - amount;
                updatedRecord = updatedRecord + "*" + chkBalance.ToString("C") + "*" + savBalance.ToString("C");
            }

            GlobalData.AWBank.updateCustomerRecord(updatedRecord);
        }   //end modifyRequest
        public string toString()
        {
            string printedString = "Name: " + name + "\n Checkings Balance: " + chkBalance.ToString("C") + "\n Savings Balance: " + savBalance.ToString("C");
            return printedString;
        }
    }   //end Customer
} //end namespace
