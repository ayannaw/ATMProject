using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMBankProject.Classes
{
    public class GlobalData
    {
        //Application classes
        public static ATMBank AWBank = new ATMBank();
        public static Customer customer = new Customer();

        //Creating instances of all the forms
        public static Form TransactionCompleteForm = new frmTransactionComplete();
        public static Form TransactionEntryForm = new frmTransactionEntry();

        public static Form PinEntryForm = new frmPinEntry();
        public static Form WelcomeForm = new frmWelcome();

        //for communication between forms
        public static string FormsCode = "";

        //customer current tries
        public static int currentTries = AWBank.getMaxTry();


    }   //end Global Data class
}   //end namespace
