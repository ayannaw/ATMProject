namespace ATMBankProject
{
    partial class frmTransactionComplete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblTransactionCompleteForm = new System.Windows.Forms.Label();
            this.lblTransactionComplete = new System.Windows.Forms.Label();
            this.lblSeeBalances = new System.Windows.Forms.Label();
            this.btnBalanceYes = new System.Windows.Forms.Button();
            this.btnBalanceNo = new System.Windows.Forms.Button();
            this.lblCurrentBalances = new System.Windows.Forms.Label();
            this.lblChecking = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.txtChecking = new System.Windows.Forms.TextBox();
            this.txtSavings = new System.Windows.Forms.TextBox();
            this.lblAnotherTransaction = new System.Windows.Forms.Label();
            this.btnTransactionYes = new System.Windows.Forms.Button();
            this.btnTransactionNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.ForeColor = System.Drawing.Color.Salmon;
            this.lblBankName.Location = new System.Drawing.Point(204, 9);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(310, 27);
            this.lblBankName.TabIndex = 0;
            this.lblBankName.Text = "AW Federal Credit Union";
            this.lblBankName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransactionCompleteForm
            // 
            this.lblTransactionCompleteForm.AutoSize = true;
            this.lblTransactionCompleteForm.Location = new System.Drawing.Point(249, 50);
            this.lblTransactionCompleteForm.Name = "lblTransactionCompleteForm";
            this.lblTransactionCompleteForm.Size = new System.Drawing.Size(230, 18);
            this.lblTransactionCompleteForm.TabIndex = 1;
            this.lblTransactionCompleteForm.Text = "Transaction Complete Form";
            this.lblTransactionCompleteForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransactionComplete
            // 
            this.lblTransactionComplete.AutoSize = true;
            this.lblTransactionComplete.Location = new System.Drawing.Point(50, 105);
            this.lblTransactionComplete.Name = "lblTransactionComplete";
            this.lblTransactionComplete.Size = new System.Drawing.Size(252, 18);
            this.lblTransactionComplete.TabIndex = 2;
            this.lblTransactionComplete.Text = "Your transactions is complete!";
            this.lblTransactionComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeeBalances
            // 
            this.lblSeeBalances.AutoSize = true;
            this.lblSeeBalances.Location = new System.Drawing.Point(50, 150);
            this.lblSeeBalances.Name = "lblSeeBalances";
            this.lblSeeBalances.Size = new System.Drawing.Size(311, 18);
            this.lblSeeBalances.TabIndex = 3;
            this.lblSeeBalances.Text = "Would you like to see your balances?";
            this.lblSeeBalances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBalanceYes
            // 
            this.btnBalanceYes.ForeColor = System.Drawing.Color.Firebrick;
            this.btnBalanceYes.Location = new System.Drawing.Point(439, 145);
            this.btnBalanceYes.Name = "btnBalanceYes";
            this.btnBalanceYes.Size = new System.Drawing.Size(75, 26);
            this.btnBalanceYes.TabIndex = 0;
            this.btnBalanceYes.Text = "Yes";
            this.btnBalanceYes.UseVisualStyleBackColor = true;
            this.btnBalanceYes.Click += new System.EventHandler(this.btnBalanceYes_Click);
            // 
            // btnBalanceNo
            // 
            this.btnBalanceNo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnBalanceNo.Location = new System.Drawing.Point(549, 145);
            this.btnBalanceNo.Name = "btnBalanceNo";
            this.btnBalanceNo.Size = new System.Drawing.Size(75, 26);
            this.btnBalanceNo.TabIndex = 1;
            this.btnBalanceNo.Text = "No";
            this.btnBalanceNo.UseVisualStyleBackColor = true;
            this.btnBalanceNo.Click += new System.EventHandler(this.btnBalanceNo_Click);
            // 
            // lblCurrentBalances
            // 
            this.lblCurrentBalances.AutoSize = true;
            this.lblCurrentBalances.Location = new System.Drawing.Point(50, 239);
            this.lblCurrentBalances.Name = "lblCurrentBalances";
            this.lblCurrentBalances.Size = new System.Drawing.Size(239, 18);
            this.lblCurrentBalances.TabIndex = 6;
            this.lblCurrentBalances.Text = "Your bank balances are now:";
            this.lblCurrentBalances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentBalances.Visible = false;
            // 
            // lblChecking
            // 
            this.lblChecking.AutoSize = true;
            this.lblChecking.ForeColor = System.Drawing.Color.Firebrick;
            this.lblChecking.Location = new System.Drawing.Point(358, 205);
            this.lblChecking.Name = "lblChecking";
            this.lblChecking.Size = new System.Drawing.Size(81, 18);
            this.lblChecking.TabIndex = 7;
            this.lblChecking.Text = "Checking";
            this.lblChecking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChecking.Visible = false;
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSavings.Location = new System.Drawing.Point(548, 205);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(68, 18);
            this.lblSavings.TabIndex = 9;
            this.lblSavings.Text = "Savings";
            this.lblSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSavings.Visible = false;
            // 
            // txtChecking
            // 
            this.txtChecking.Location = new System.Drawing.Point(361, 231);
            this.txtChecking.Name = "txtChecking";
            this.txtChecking.ReadOnly = true;
            this.txtChecking.Size = new System.Drawing.Size(100, 26);
            this.txtChecking.TabIndex = 2;
            this.txtChecking.Visible = false;
            // 
            // txtSavings
            // 
            this.txtSavings.Location = new System.Drawing.Point(551, 234);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.ReadOnly = true;
            this.txtSavings.Size = new System.Drawing.Size(100, 26);
            this.txtSavings.TabIndex = 3;
            this.txtSavings.Visible = false;
            // 
            // lblAnotherTransaction
            // 
            this.lblAnotherTransaction.AutoSize = true;
            this.lblAnotherTransaction.Location = new System.Drawing.Point(50, 345);
            this.lblAnotherTransaction.Name = "lblAnotherTransaction";
            this.lblAnotherTransaction.Size = new System.Drawing.Size(296, 18);
            this.lblAnotherTransaction.TabIndex = 12;
            this.lblAnotherTransaction.Text = "Would you like another transaction?";
            this.lblAnotherTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnotherTransaction.Visible = false;
            // 
            // btnTransactionYes
            // 
            this.btnTransactionYes.BackColor = System.Drawing.Color.Green;
            this.btnTransactionYes.ForeColor = System.Drawing.Color.White;
            this.btnTransactionYes.Location = new System.Drawing.Point(439, 345);
            this.btnTransactionYes.Name = "btnTransactionYes";
            this.btnTransactionYes.Size = new System.Drawing.Size(75, 26);
            this.btnTransactionYes.TabIndex = 4;
            this.btnTransactionYes.Text = "Yes";
            this.btnTransactionYes.UseVisualStyleBackColor = false;
            this.btnTransactionYes.Visible = false;
            this.btnTransactionYes.Click += new System.EventHandler(this.btnTransactionYes_Click);
            // 
            // btnTransactionNo
            // 
            this.btnTransactionNo.BackColor = System.Drawing.Color.Red;
            this.btnTransactionNo.ForeColor = System.Drawing.Color.White;
            this.btnTransactionNo.Location = new System.Drawing.Point(549, 348);
            this.btnTransactionNo.Name = "btnTransactionNo";
            this.btnTransactionNo.Size = new System.Drawing.Size(75, 26);
            this.btnTransactionNo.TabIndex = 5;
            this.btnTransactionNo.Text = "No";
            this.btnTransactionNo.UseVisualStyleBackColor = false;
            this.btnTransactionNo.Visible = false;
            this.btnTransactionNo.Click += new System.EventHandler(this.btnTransactionNo_Click);
            // 
            // frmTransactionComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 481);
            this.Controls.Add(this.btnTransactionNo);
            this.Controls.Add(this.btnTransactionYes);
            this.Controls.Add(this.lblAnotherTransaction);
            this.Controls.Add(this.txtSavings);
            this.Controls.Add(this.txtChecking);
            this.Controls.Add(this.lblSavings);
            this.Controls.Add(this.lblChecking);
            this.Controls.Add(this.lblCurrentBalances);
            this.Controls.Add(this.btnBalanceNo);
            this.Controls.Add(this.btnBalanceYes);
            this.Controls.Add(this.lblSeeBalances);
            this.Controls.Add(this.lblTransactionComplete);
            this.Controls.Add(this.lblTransactionCompleteForm);
            this.Controls.Add(this.lblBankName);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTransactionComplete";
            this.Text = "Transaction Complete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblTransactionCompleteForm;
        private System.Windows.Forms.Label lblTransactionComplete;
        private System.Windows.Forms.Label lblSeeBalances;
        private System.Windows.Forms.Button btnBalanceYes;
        private System.Windows.Forms.Button btnBalanceNo;
        private System.Windows.Forms.Label lblCurrentBalances;
        private System.Windows.Forms.Label lblChecking;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.TextBox txtChecking;
        private System.Windows.Forms.TextBox txtSavings;
        private System.Windows.Forms.Label lblAnotherTransaction;
        private System.Windows.Forms.Button btnTransactionYes;
        private System.Windows.Forms.Button btnTransactionNo;
    }
}