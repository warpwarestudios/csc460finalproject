namespace CSC460_BlackJack_Final_Burke_Hammontree_Smith
{
    partial class BankWindow
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
            this.valueBorrowBank = new System.Windows.Forms.TextBox();
            this.okBankBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add an Amount that you want: $";
            // 
            // valueBorrowBank
            // 
            this.valueBorrowBank.Location = new System.Drawing.Point(177, 46);
            this.valueBorrowBank.Name = "valueBorrowBank";
            this.valueBorrowBank.Size = new System.Drawing.Size(100, 20);
            this.valueBorrowBank.TabIndex = 1;
            // 
            // okBankBtn
            // 
            this.okBankBtn.Location = new System.Drawing.Point(202, 82);
            this.okBankBtn.Name = "okBankBtn";
            this.okBankBtn.Size = new System.Drawing.Size(75, 23);
            this.okBankBtn.TabIndex = 2;
            this.okBankBtn.Text = "Ok";
            this.okBankBtn.UseVisualStyleBackColor = true;
            this.okBankBtn.Click += new System.EventHandler(this.okBankBtn_Click);
            // 
            // BankWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 117);
            this.Controls.Add(this.okBankBtn);
            this.Controls.Add(this.valueBorrowBank);
            this.Controls.Add(this.label1);
            this.Name = "BankWindow";
            this.Text = "Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueBorrowBank;
        private System.Windows.Forms.Button okBankBtn;
    }
}