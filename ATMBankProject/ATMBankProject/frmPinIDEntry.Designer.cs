namespace ATMBankProject
{
    partial class frmPinEntry
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
            this.lblNameAndPin = new System.Windows.Forms.Label();
            this.lblEnterNameAndPin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblBankName.Location = new System.Drawing.Point(225, 25);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(419, 36);
            this.lblBankName.TabIndex = 0;
            this.lblBankName.Text = "AW Federal Credit Union";
            this.lblBankName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameAndPin
            // 
            this.lblNameAndPin.AutoSize = true;
            this.lblNameAndPin.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAndPin.Location = new System.Drawing.Point(295, 106);
            this.lblNameAndPin.Name = "lblNameAndPin";
            this.lblNameAndPin.Size = new System.Drawing.Size(301, 33);
            this.lblNameAndPin.TabIndex = 1;
            this.lblNameAndPin.Text = "Name and Pin Entry";
            // 
            // lblEnterNameAndPin
            // 
            this.lblEnterNameAndPin.AutoSize = true;
            this.lblEnterNameAndPin.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNameAndPin.Location = new System.Drawing.Point(63, 209);
            this.lblEnterNameAndPin.Name = "lblEnterNameAndPin";
            this.lblEnterNameAndPin.Size = new System.Drawing.Size(442, 27);
            this.lblEnterNameAndPin.TabIndex = 2;
            this.lblEnterNameAndPin.Text = "Enter Name and Pin and Press OK....";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(68, 274);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(68, 345);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(261, 24);
            this.lblPin.TabIndex = 4;
            this.lblPin.Text = "Pin (A 4 Digit Number):";
            this.lblPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(476, 268);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 30);
            this.txtName.TabIndex = 0;
            // 
            // txtPin
            // 
            this.txtPin.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(476, 339);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(205, 30);
            this.txtPin.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Lime;
            this.btnOK.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(430, 427);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmPinEntry
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEnterNameAndPin);
            this.Controls.Add(this.lblNameAndPin);
            this.Controls.Add(this.lblBankName);
            this.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPinEntry";
            this.Text = "Pin Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblNameAndPin;
        private System.Windows.Forms.Label lblEnterNameAndPin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnOK;
    }
}