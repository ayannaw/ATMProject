using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMBankProject.Classes
{
    public class UpdatedFile
    {
        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSW;
        private int recordWriteCount;

        public UpdatedFile(string filePath)
        {
            recordWriteCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file " + updatedFilePath + " Terminate Program.", "Output File Connection Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   //end try
        }   //end UpdatedFile

        public void putNextRecord(string nextRecord)
        {
            updatedFileSW.WriteLine(nextRecord);
            recordWriteCount++;
            /*if (nextRecord == null)
            {
                endOfFileFlag = true;
            }
            else
            {
                recordWriteCount++;
            }   //end if */
           // return (nextRecord);
        }   //end putNextRecord
        public int getRecordWriteCount()
        {
            return recordWriteCount;
        }   //end getsRecordsReadCount
        public void closeFile()
        {
            updatedFileSW.Close();
        }   //end Sub

        public void rewindFile()
        {
            recordWriteCount = 0;
            updatedFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        }   //end rewindFile
    }
}
