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
            this.btnHit = new System.Windows.Forms.Button();
            this.lblDealerHandValue = new System.Windows.Forms.Label();
            this.lblPlayerHandValue = new System.Windows.Forms.Label();
            this.betFiveBtn = new System.Windows.Forms.Button();
            this.betTenBtn = new System.Windows.Forms.Button();
            this.betFiftyBtn = new System.Windows.Forms.Button();
            this.betHundredBtn = new System.Windows.Forms.Button();
            this.betFiveHundredBtn = new System.Windows.Forms.Button();
            this.betThousandBtn = new System.Windows.Forms.Button();
            this.betAndSetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valueLostLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valueBetLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.valuePlayerLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.valueMostGainedLbl = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(612, 547);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lblDealerHandValue
            // 
            this.lblDealerHandValue.AutoSize = true;
            this.lblDealerHandValue.Location = new System.Drawing.Point(476, 228);
            this.lblDealerHandValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealerHandValue.Name = "lblDealerHandValue";
            this.lblDealerHandValue.Size = new System.Drawing.Size(58, 13);
            this.lblDealerHandValue.TabIndex = 1;
            this.lblDealerHandValue.Text = "handValue";
            // 
            // lblPlayerHandValue
            // 
            this.lblPlayerHandValue.AutoSize = true;
            this.lblPlayerHandValue.Location = new System.Drawing.Point(477, 483);
            this.lblPlayerHandValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerHandValue.Name = "lblPlayerHandValue";
            this.lblPlayerHandValue.Size = new System.Drawing.Size(58, 13);
            this.lblPlayerHandValue.TabIndex = 2;
            this.lblPlayerHandValue.Text = "handValue";
            // 
            // betFiveBtn
            // 
            this.betFiveBtn.BackColor = System.Drawing.Color.White;
            this.betFiveBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Blue;
            this.betFiveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betFiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betFiveBtn.Location = new System.Drawing.Point(-1, 508);
            this.betFiveBtn.Name = "betFiveBtn";
            this.betFiveBtn.Size = new System.Drawing.Size(100, 100);
            this.betFiveBtn.TabIndex = 3;
            this.betFiveBtn.Text = "$5";
            this.betFiveBtn.UseVisualStyleBackColor = false;
            this.betFiveBtn.Click += new System.EventHandler(this.betFiveBtn_Click);
            // 
            // betTenBtn
            // 
            this.betTenBtn.BackColor = System.Drawing.Color.White;
            this.betTenBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Green;
            this.betTenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betTenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betTenBtn.Location = new System.Drawing.Point(98, 508);
            this.betTenBtn.Name = "betTenBtn";
            this.betTenBtn.Size = new System.Drawing.Size(100, 100);
            this.betTenBtn.TabIndex = 4;
            this.betTenBtn.Text = "$10";
            this.betTenBtn.UseVisualStyleBackColor = false;
            this.betTenBtn.Click += new System.EventHandler(this.betTenBtn_Click);
            // 
            // betFiftyBtn
            // 
            this.betFiftyBtn.BackColor = System.Drawing.Color.White;
            this.betFiftyBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Orange;
            this.betFiftyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betFiftyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betFiftyBtn.Location = new System.Drawing.Point(197, 508);
            this.betFiftyBtn.Name = "betFiftyBtn";
            this.betFiftyBtn.Size = new System.Drawing.Size(100, 100);
            this.betFiftyBtn.TabIndex = 5;
            this.betFiftyBtn.Text = "$50";
            this.betFiftyBtn.UseVisualStyleBackColor = false;
            this.betFiftyBtn.Click += new System.EventHandler(this.betFiftyBtn_Click);
            // 
            // betHundredBtn
            // 
            this.betHundredBtn.BackColor = System.Drawing.Color.White;
            this.betHundredBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Red;
            this.betHundredBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betHundredBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betHundredBtn.Location = new System.Drawing.Point(296, 508);
            this.betHundredBtn.Name = "betHundredBtn";
            this.betHundredBtn.Size = new System.Drawing.Size(100, 100);
            this.betHundredBtn.TabIndex = 6;
            this.betHundredBtn.Text = "$100";
            this.betHundredBtn.UseVisualStyleBackColor = false;
            this.betHundredBtn.Click += new System.EventHandler(this.betHundredBtn_Click);
            // 
            // betFiveHundredBtn
            // 
            this.betFiveHundredBtn.BackColor = System.Drawing.Color.White;
            this.betFiveHundredBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Purple;
            this.betFiveHundredBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betFiveHundredBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betFiveHundredBtn.Location = new System.Drawing.Point(395, 508);
            this.betFiveHundredBtn.Name = "betFiveHundredBtn";
            this.betFiveHundredBtn.Size = new System.Drawing.Size(100, 100);
            this.betFiveHundredBtn.TabIndex = 7;
            this.betFiveHundredBtn.Text = "$500";
            this.betFiveHundredBtn.UseVisualStyleBackColor = false;
            this.betFiveHundredBtn.Click += new System.EventHandler(this.betFiveHundredBtn_Click);
            // 
            // betThousandBtn
            // 
            this.betThousandBtn.BackColor = System.Drawing.Color.Transparent;
            this.betThousandBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Black;
            this.betThousandBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betThousandBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betThousandBtn.ForeColor = System.Drawing.Color.White;
            this.betThousandBtn.Location = new System.Drawing.Point(494, 508);
            this.betThousandBtn.Name = "betThousandBtn";
            this.betThousandBtn.Size = new System.Drawing.Size(100, 100);
            this.betThousandBtn.TabIndex = 8;
            this.betThousandBtn.Text = "$1000";
            this.betThousandBtn.UseVisualStyleBackColor = false;
            this.betThousandBtn.Click += new System.EventHandler(this.betThousandBtn_Click);
            // 
            // betAndSetBtn
            // 
            this.betAndSetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betAndSetBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.betAndSetBtn.Location = new System.Drawing.Point(246, 614);
            this.betAndSetBtn.Name = "betAndSetBtn";
            this.betAndSetBtn.Size = new System.Drawing.Size(100, 23);
            this.betAndSetBtn.TabIndex = 9;
            this.betAndSetBtn.Text = "Bet";
            this.betAndSetBtn.UseVisualStyleBackColor = true;
            this.betAndSetBtn.Click += new System.EventHandler(this.betAndSetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(855, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lost: $";
            // 
            // valueLostLbl
            // 
            this.valueLostLbl.AutoSize = true;
            this.valueLostLbl.BackColor = System.Drawing.Color.Transparent;
            this.valueLostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLostLbl.Location = new System.Drawing.Point(951, 577);
            this.valueLostLbl.Name = "valueLostLbl";
            this.valueLostLbl.Size = new System.Drawing.Size(30, 31);
            this.valueLostLbl.TabIndex = 11;
            this.valueLostLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(867, 619);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bet: $";
            // 
            // valueBetLbl
            // 
            this.valueBetLbl.AutoSize = true;
            this.valueBetLbl.BackColor = System.Drawing.Color.Transparent;
            this.valueBetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueBetLbl.Location = new System.Drawing.Point(951, 619);
            this.valueBetLbl.Name = "valueBetLbl";
            this.valueBetLbl.Size = new System.Drawing.Size(30, 31);
            this.valueBetLbl.TabIndex = 13;
            this.valueBetLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(654, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "You: $";
            // 
            // valuePlayerLbl
            // 
            this.valuePlayerLbl.AutoSize = true;
            this.valuePlayerLbl.BackColor = System.Drawing.Color.Transparent;
            this.valuePlayerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuePlayerLbl.Location = new System.Drawing.Point(745, 577);
            this.valuePlayerLbl.Name = "valuePlayerLbl";
            this.valuePlayerLbl.Size = new System.Drawing.Size(30, 31);
            this.valuePlayerLbl.TabIndex = 15;
            this.valuePlayerLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 617);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "Most Gained: $";
            // 
            // valueMostGainedLbl
            // 
            this.valueMostGainedLbl.AutoSize = true;
            this.valueMostGainedLbl.BackColor = System.Drawing.Color.Transparent;
            this.valueMostGainedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueMostGainedLbl.Location = new System.Drawing.Point(745, 617);
            this.valueMostGainedLbl.Name = "valueMostGainedLbl";
            this.valueMostGainedLbl.Size = new System.Drawing.Size(30, 31);
            this.valueMostGainedLbl.TabIndex = 17;
            this.valueMostGainedLbl.Text = "0";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.CasinoMortambo;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.lblPlayerHandValue);
            this.pnlBackground.Location = new System.Drawing.Point(12, 12);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(992, 455);
            this.pnlBackground.TabIndex = 18;
            // 
            // BlackjackMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 645);
            this.Controls.Add(this.betFiftyBtn);
            this.Controls.Add(this.betFiveBtn);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.valueMostGainedLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.valuePlayerLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valueBetLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valueLostLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betAndSetBtn);
            this.Controls.Add(this.betThousandBtn);
            this.Controls.Add(this.betFiveHundredBtn);
            this.Controls.Add(this.betHundredBtn);
            this.Controls.Add(this.betTenBtn);
            this.Controls.Add(this.lblDealerHandValue);
            this.Controls.Add(this.btnHit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BlackjackMainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.BlackjackMainWindow_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Label lblDealerHandValue;
        private System.Windows.Forms.Label lblPlayerHandValue;
        private System.Windows.Forms.Button betFiveBtn;
        private System.Windows.Forms.Button betTenBtn;
        private System.Windows.Forms.Button betFiftyBtn;
        private System.Windows.Forms.Button betHundredBtn;
        private System.Windows.Forms.Button betFiveHundredBtn;
        private System.Windows.Forms.Button betThousandBtn;
        private System.Windows.Forms.Button betAndSetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label valueLostLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valueBetLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label valuePlayerLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label valueMostGainedLbl;
        private System.Windows.Forms.Panel pnlBackground;


    }
}