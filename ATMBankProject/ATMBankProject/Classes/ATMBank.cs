using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMBankProject.Classes
{
    public class ATMBank
    {
        //Bank parameters (Named constants defined by the bank)

        //The files the Bank Owns
        private static string currentFilePath = "CurrentATMBankFile.txt";
        private static string updatedFilePath = "UpdatedATMBankFile.txt";

        private CurrentFile currentFile = new CurrentFile(currentFilePath);
        private UpdatedFile updatedFile = new UpdatedFile(updatedFilePath);

        //Exact length of legal accounts for AW Federal Credit Union
        private int hiddenAccountLength = 5;

        //Number of attempts AW Federal Credit Union allows a user beore terminating ATM Session
        private int hiddenTryCountMax = 3;

        //Maximum withdrawal amount bank allows per day
        private decimal hiddenWDAmount = Convert.ToDecimal(300.0);



        //Constructor for the ATM Bank Class
        public ATMBank()
        {

        }

        //Find customer record given the entered account
        public string findCustomerRecord(string account, ref Boolean found)
        {
            string nextRecord;
            Boolean isEndOfFile = true;

            nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            found = false;


            while (!isEndOfFile)
            {
                if (GlobalData.customer.customerMatch(account, nextRecord))
                {
                    found = true;
                    return (nextRecord);

                }
                else
                {
                    updatedFile.putNextRecord(nextRecord);
                    nextRecord = currentFile.getNextRecord(ref isEndOfFile);
                }   //end if
            }   //end while
            return (nextRecord);
        }

        //returns the max count allowed
        public int getMaxTry()
        {
            return hiddenTryCountMax;
        }

        public int getAccountLength()
        {
            return hiddenAccountLength;
        }

        public decimal getMaxWD()
        {
            return hiddenWDAmount;
        }
        public void updateCustomerRecord(string newRecord)
        {
            updatedFile.putNextRecord(newRecord);
        }

        // Copies remaining records from currentFile to updatedFile.
        public void CopyRemainingRecords()
        {
            Boolean isEndOfFile = false;
            string nextRecord;

            nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                updatedFile.putNextRecord(nextRecord);
                nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            } // end While

            MessageBox.Show("End of program execution." + "\n"
                + "The number of records read is: " + currentFile.getRecordsReadCount().ToString() + "\n"
                + "The number of records written is: " + updatedFile.getRecordWriteCount().ToString());
        } // end CopyRemaingRecords


        public void rewindFiles()
        {
            currentFile.rewindFile();
            updatedFile.rewindFile();
        }  // end rewindFiles


        public void closeFiles()
        {
            currentFile.closeFile();
            updatedFile.closeFile();
        }  // end close files

    }
}
