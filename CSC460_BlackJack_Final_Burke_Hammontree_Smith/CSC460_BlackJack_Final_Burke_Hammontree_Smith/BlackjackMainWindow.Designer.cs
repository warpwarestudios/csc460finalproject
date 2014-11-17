namespace CSC460_BlackJack_Final_Burke_Hammontree_Smith
{
    partial class BlackjackMainWindow
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
            this.betAndDealBtn = new System.Windows.Forms.Button();
            this.betFiveBtn = new System.Windows.Forms.Button();
            this.betTenBtn = new System.Windows.Forms.Button();
            this.betFiftyBtn = new System.Windows.Forms.Button();
            this.betHundredBtn = new System.Windows.Forms.Button();
            this.betFiveHundredBtn = new System.Windows.Forms.Button();
            this.betThousandBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valuePlayerLbl = new System.Windows.Forms.Label();
            this.valueDealerLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valueBetLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // betAndDealBtn
            // 
            this.betAndDealBtn.Location = new System.Drawing.Point(665, 716);
            this.betAndDealBtn.Name = "betAndDealBtn";
            this.betAndDealBtn.Size = new System.Drawing.Size(75, 23);
            this.betAndDealBtn.TabIndex = 0;
            this.betAndDealBtn.Text = "Bet";
            this.betAndDealBtn.UseVisualStyleBackColor = true;
            this.betAndDealBtn.Click += new System.EventHandler(this.betAndDealBtn_Click);
            // 
            // betFiveBtn
            // 
            this.betFiveBtn.Location = new System.Drawing.Point(458, 687);
            this.betFiveBtn.Name = "betFiveBtn";
            this.betFiveBtn.Size = new System.Drawing.Size(75, 23);
            this.betFiveBtn.TabIndex = 1;
            this.betFiveBtn.Text = "$5";
            this.betFiveBtn.UseVisualStyleBackColor = true;
            this.betFiveBtn.Click += new System.EventHandler(this.betFiveBtn_Click);
            // 
            // betTenBtn
            // 
            this.betTenBtn.Location = new System.Drawing.Point(539, 687);
            this.betTenBtn.Name = "betTenBtn";
            this.betTenBtn.Size = new System.Drawing.Size(75, 23);
            this.betTenBtn.TabIndex = 2;
            this.betTenBtn.Text = "$10";
            this.betTenBtn.UseVisualStyleBackColor = true;
            this.betTenBtn.Click += new System.EventHandler(this.betTenBtn_Click);
            // 
            // betFiftyBtn
            // 
            this.betFiftyBtn.Location = new System.Drawing.Point(620, 687);
            this.betFiftyBtn.Name = "betFiftyBtn";
            this.betFiftyBtn.Size = new System.Drawing.Size(75, 23);
            this.betFiftyBtn.TabIndex = 3;
            this.betFiftyBtn.Text = "$50";
            this.betFiftyBtn.UseVisualStyleBackColor = true;
            this.betFiftyBtn.Click += new System.EventHandler(this.betFiftyBtn_Click);
            // 
            // betHundredBtn
            // 
            this.betHundredBtn.Location = new System.Drawing.Point(701, 687);
            this.betHundredBtn.Name = "betHundredBtn";
            this.betHundredBtn.Size = new System.Drawing.Size(75, 23);
            this.betHundredBtn.TabIndex = 4;
            this.betHundredBtn.Text = "$100";
            this.betHundredBtn.UseVisualStyleBackColor = true;
            this.betHundredBtn.Click += new System.EventHandler(this.betHundredBtn_Click);
            // 
            // betFiveHundredBtn
            // 
            this.betFiveHundredBtn.Location = new System.Drawing.Point(782, 687);
            this.betFiveHundredBtn.Name = "betFiveHundredBtn";
            this.betFiveHundredBtn.Size = new System.Drawing.Size(75, 23);
            this.betFiveHundredBtn.TabIndex = 5;
            this.betFiveHundredBtn.Text = "$500";
            this.betFiveHundredBtn.UseVisualStyleBackColor = true;
            this.betFiveHundredBtn.Click += new System.EventHandler(this.betFiveHundredBtn_Click);
            // 
            // betThousandBtn
            // 
            this.betThousandBtn.Location = new System.Drawing.Point(863, 687);
            this.betThousandBtn.Name = "betThousandBtn";
            this.betThousandBtn.Size = new System.Drawing.Size(75, 23);
            this.betThousandBtn.TabIndex = 6;
            this.betThousandBtn.Text = "$1000";
            this.betThousandBtn.UseVisualStyleBackColor = true;
            this.betThousandBtn.Click += new System.EventHandler(this.betThousandBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dealer: $";
            // 
            // valuePlayerLbl
            // 
            this.valuePlayerLbl.AutoSize = true;
            this.valuePlayerLbl.BackColor = System.Drawing.Color.Transparent;
            this.valuePlayerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuePlayerLbl.Location = new System.Drawing.Point(526, 553);
            this.valuePlayerLbl.Name = "valuePlayerLbl";
            this.valuePlayerLbl.Size = new System.Drawing.Size(30, 31);
            this.valuePlayerLbl.TabIndex = 8;
            this.valuePlayerLbl.Text = "0";
            // 
            // valueDealerLbl
            // 
            this.valueDealerLbl.AutoSize = true;
            this.valueDealerLbl.BackColor = System.Drawing.Color.Transparent;
            this.valueDealerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueDealerLbl.Location = new System.Drawing.Point(525, 455);
            this.valueDealerLbl.Name = "valueDealerLbl";
            this.valueDealerLbl.Size = new System.Drawing.Size(30, 31);
            this.valueDealerLbl.TabIndex = 9;
            this.valueDealerLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "You: $";
            // 
            // valueBetLbl
            // 
            this.valueBetLbl.AutoSize = true;
            this.valueBetLbl.BackColor = System.Drawing.Color.Transparent;
            this.valueBetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueBetLbl.Location = new System.Drawing.Point(525, 507);
            this.valueBetLbl.Name = "valueBetLbl";
            this.valueBetLbl.Size = new System.Drawing.Size(30, 31);
            this.valueBetLbl.TabIndex = 12;
            this.valueBetLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bet: $";
            // 
            // BlackjackMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Casino_Mortambo;
            this.ClientSize = new System.Drawing.Size(1426, 841);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.valueBetLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valueDealerLbl);
            this.Controls.Add(this.valuePlayerLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betThousandBtn);
            this.Controls.Add(this.betFiveHundredBtn);
            this.Controls.Add(this.betHundredBtn);
            this.Controls.Add(this.betFiftyBtn);
            this.Controls.Add(this.betTenBtn);
            this.Controls.Add(this.betFiveBtn);
            this.Controls.Add(this.betAndDealBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BlackjackMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.BlackjackMainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button betAndDealBtn;
        private System.Windows.Forms.Button betFiveBtn;
        private System.Windows.Forms.Button betTenBtn;
        private System.Windows.Forms.Button betFiftyBtn;
        private System.Windows.Forms.Button betHundredBtn;
        private System.Windows.Forms.Button betFiveHundredBtn;
        private System.Windows.Forms.Button betThousandBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label valuePlayerLbl;
        private System.Windows.Forms.Label valueDealerLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label valueBetLbl;
        private System.Windows.Forms.Label label7;

    }
}