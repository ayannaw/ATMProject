namespace ATMBankProject
{
    partial class frmTransactionEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTransactionPage = new System.Windows.Forms.Label();
            this.lblSelectTransaction = new System.Windows.Forms.Label();
            this.btnSavDeposit = new System.Windows.Forms.Button();
            this.btnSavWithdrawal = new System.Windows.Forms.Button();
            this.btnSavBalance = new System.Windows.Forms.Button();
            this.btnTransferSavChk = new System.Windows.Forms.Button();
            this.btnTransferChkSav = new System.Windows.Forms.Button();
            this.btnChkBalance = new System.Windows.Forms.Button();
            this.btnChkWithdrawal = new System.Windows.Forms.Button();
            this.btnChkDeposit = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblDollarAmount = new System.Windows.Forms.Label();
            this.txtDollarAmount = new System.Windows.Forms.TextBox();
            this.lblBalanceOnly = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "AW Federal Credit Union";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransactionPage
            // 
            this.lblTransactionPage.AutoSize = true;
            this.lblTransactionPage.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionPage.Location = new System.Drawing.Point(383, 54);
            this.lblTransactionPage.Name = "lblTransactionPage";
            this.lblTransactionPage.Size = new System.Drawing.Size(197, 24);
            this.lblTransactionPage.TabIndex = 1;
            this.lblTransactionPage.Text = "Transaction Page";
            this.lblTransactionPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectTransaction
            // 
            this.lblSelectTransaction.AutoSize = true;
            this.lblSelectTransaction.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTransaction.Location = new System.Drawing.Point(30, 94);
            this.lblSelectTransaction.Name = "lblSelectTransaction";
            this.lblSelectTransaction.Size = new System.Drawing.Size(249, 24);
            this.lblSelectTransaction.TabIndex = 2;
            this.lblSelectTransaction.Text = "Select a Transaction...";
            this.lblSelectTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSavDeposit
            // 
            this.btnSavDeposit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSavDeposit.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavDeposit.Location = new System.Drawing.Point(34, 141);
            this.btnSavDeposit.Name = "btnSavDeposit";
            this.btnSavDeposit.Size = new System.Drawing.Size(172, 35);
            this.btnSavDeposit.TabIndex = 0;
            this.btnSavDeposit.Text = "Savings Deposit";
            this.btnSavDeposit.UseVisualStyleBackColor = false;
            this.btnSavDeposit.Click += new System.EventHandler(this.btnSavDeposit_Click);
            // 
            // btnSavWithdrawal
            // 
            this.btnSavWithdrawal.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSavWithdrawal.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavWithdrawal.Location = new System.Drawing.Point(34, 220);
            this.btnSavWithdrawal.Name = "btnSavWithdrawal";
            this.btnSavWithdrawal.Size = new System.Drawing.Size(172, 35);
            this.btnSavWithdrawal.TabIndex = 2;
            this.btnSavWithdrawal.Text = "Savings Withdrawal";
            this.btnSavWithdrawal.UseVisualStyleBackColor = false;
            this.btnSavWithdrawal.Click += new System.EventHandler(this.btnSavWithdrawal_Click);
            // 
            // btnSavBalance
            // 
            this.btnSavBalance.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSavBalance.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavBalance.Location = new System.Drawing.Point(34, 299);
            this.btnSavBalance.Name = "btnSavBalance";
            this.btnSavBalance.Size = new System.Drawing.Size(172, 35);
            this.btnSavBalance.TabIndex = 4;
            this.btnSavBalance.Text = "Savings Balance";
            this.btnSavBalance.UseVisualStyleBackColor = false;
            this.btnSavBalance.Click += new System.EventHandler(this.btnSavBalance_Click);
            // 
            // btnTransferSavChk
            // 
            this.btnTransferSavChk.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTransferSavChk.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferSavChk.Location = new System.Drawing.Point(34, 368);
            this.btnTransferSavChk.Name = "btnTransferSavChk";
            this.btnTransferSavChk.Size = new System.Drawing.Size(216, 35);
            this.btnTransferSavChk.TabIndex = 6;
            this.btnTransferSavChk.Text = "Transfer SAV --> CHK";
            this.btnTransferSavChk.UseVisualStyleBackColor = false;
            this.btnTransferSavChk.Click += new System.EventHandler(this.btnTransferSavChk_Click);
            // 
            // btnTransferChkSav
            // 
            this.btnTransferChkSav.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTransferChkSav.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferChkSav.Location = new System.Drawing.Point(419, 368);
            this.btnTransferChkSav.Name = "btnTransferChkSav";
            this.btnTransferChkSav.Size = new System.Drawing.Size(227, 35);
            this.btnTransferChkSav.TabIndex = 7;
            this.btnTransferChkSav.Text = "Transfer CHK --> SAV";
            this.btnTransferChkSav.UseVisualStyleBackColor = false;
            this.btnTransferChkSav.Click += new System.EventHandler(this.btnTransferChkSav_Click);
            // 
            // btnChkBalance
            // 
            this.btnChkBalance.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChkBalance.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkBalance.Location = new System.Drawing.Point(419, 299);
            this.btnChkBalance.Name = "btnChkBalance";
            this.btnChkBalance.Size = new System.Drawing.Size(172, 35);
            this.btnChkBalance.TabIndex = 5;
            this.btnChkBalance.Text = "Checking Balance";
            this.btnChkBalance.UseVisualStyleBackColor = false;
            this.btnChkBalance.Click += new System.EventHandler(this.btnChkBalance_Click);
            // 
            // btnChkWithdrawal
            // 
            this.btnChkWithdrawal.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChkWithdrawal.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkWithdrawal.Location = new System.Drawing.Point(419, 220);
            this.btnChkWithdrawal.Name = "btnChkWithdrawal";
            this.btnChkWithdrawal.Size = new System.Drawing.Size(191, 35);
            this.btnChkWithdrawal.TabIndex = 3;
            this.btnChkWithdrawal.Text = "Checking Withdrawal";
            this.btnChkWithdrawal.UseVisualStyleBackColor = false;
            this.btnChkWithdrawal.Click += new System.EventHandler(this.btnChkWithdrawal_Click);
            // 
            // btnChkDeposit
            // 
            this.btnChkDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChkDeposit.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkDeposit.Location = new System.Drawing.Point(419, 141);
            this.btnChkDeposit.Name = "btnChkDeposit";
            this.btnChkDeposit.Size = new System.Drawing.Size(172, 35);
            this.btnChkDeposit.TabIndex = 1;
            this.btnChkDeposit.Text = "Checking Deposit";
            this.btnChkDeposit.UseVisualStyleBackColor = false;
            this.btnChkDeposit.Click += new System.EventHandler(this.btnChkDeposit_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Green;
            this.btnYes.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(34, 489);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(227, 35);
            this.btnYes.TabIndex = 8;
            this.btnYes.Text = "YES -- Process Request";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Red;
            this.btnNo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(419, 489);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(227, 35);
            this.btnNo.TabIndex = 9;
            this.btnNo.Text = "NO -- Select Again";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblDollarAmount
            // 
            this.lblDollarAmount.AutoSize = true;
            this.lblDollarAmount.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollarAmount.Location = new System.Drawing.Point(34, 425);
            this.lblDollarAmount.Name = "lblDollarAmount";
            this.lblDollarAmount.Size = new System.Drawing.Size(318, 15);
            this.lblDollarAmount.TabIndex = 10;
            this.lblDollarAmount.Text = "Select an amount in Dollars (NO PUNCTATION)";
            this.lblDollarAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDollarAmount.Visible = false;
            // 
            // txtDollarAmount
            // 
            this.txtDollarAmount.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDollarAmount.Location = new System.Drawing.Point(419, 419);
            this.txtDollarAmount.Name = "txtDollarAmount";
            this.txtDollarAmount.Size = new System.Drawing.Size(172, 22);
            this.txtDollarAmount.TabIndex = 11;
            this.txtDollarAmount.Visible = false;
            // 
            // lblBalanceOnly
            // 
            this.lblBalanceOnly.AutoSize = true;
            this.lblBalanceOnly.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceOnly.Location = new System.Drawing.Point(34, 450);
            this.lblBalanceOnly.Name = "lblBalanceOnly";
            this.lblBalanceOnly.Size = new System.Drawing.Size(331, 15);
            this.lblBalanceOnly.TabIndex = 12;
            this.lblBalanceOnly.Text = "You selected a balance only. IS THIS CORRECT?";
            this.lblBalanceOnly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBalanceOnly.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOK.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(677, 419);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(54, 22);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSelection
            // 
            this.txtSelection.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelection.Location = new System.Drawing.Point(37, 468);
            this.txtSelection.Multiline = true;
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.ReadOnly = true;
            this.txtSelection.Size = new System.Drawing.Size(554, 20);
            this.txtSelection.TabIndex = 14;
            this.txtSelection.Visible = false;
            // 
            // frmTransactionEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 550);
            this.Controls.Add(this.txtSelection);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblBalanceOnly);
            this.Controls.Add(this.txtDollarAmount);
            this.Controls.Add(this.lblDollarAmount);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnChkDeposit);
            this.Controls.Add(this.btnChkWithdrawal);
            this.Controls.Add(this.btnChkBalance);
            this.Controls.Add(this.btnTransferChkSav);
            this.Controls.Add(this.btnTransferSavChk);
            this.Controls.Add(this.btnSavBalance);
            this.Controls.Add(this.btnSavWithdrawal);
            this.Controls.Add(this.btnSavDeposit);
            this.Controls.Add(this.lblSelectTransaction);
            this.Controls.Add(this.lblTransactionPage);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTransactionEntry";
            this.Text = "Transaction Entry";
            this.Load += new System.EventHandler(this.frmTransactionEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTransactionPage;
        private System.Windows.Forms.Label lblSelectTransaction;
        private System.Windows.Forms.Button btnSavDeposit;
        private System.Windows.Forms.Button btnSavWithdrawal;
        private System.Windows.Forms.Button btnSavBalance;
        private System.Windows.Forms.Button btnTransferSavChk;
        private System.Windows.Forms.Button btnTransferChkSav;
        private System.Windows.Forms.Button btnChkBalance;
        private System.Windows.Forms.Button btnChkWithdrawal;
        private System.Windows.Forms.Button btnChkDeposit;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblDollarAmount;
        private System.Windows.Forms.TextBox txtDollarAmount;
        private System.Windows.Forms.Label lblBalanceOnly;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtSelection;
    }
}