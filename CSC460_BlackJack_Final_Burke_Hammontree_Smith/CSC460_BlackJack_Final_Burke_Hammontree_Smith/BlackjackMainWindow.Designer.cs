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
            this.btnStand = new System.Windows.Forms.Button();
            this.btnDoubleDown = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(816, 673);
            this.btnHit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(100, 28);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lblDealerHandValue
            // 
            this.lblDealerHandValue.AutoSize = true;
            this.lblDealerHandValue.Location = new System.Drawing.Point(72, 762);
            this.lblDealerHandValue.Name = "lblDealerHandValue";
            this.lblDealerHandValue.Size = new System.Drawing.Size(76, 17);
            this.lblDealerHandValue.TabIndex = 1;
            this.lblDealerHandValue.Text = "handValue";
            // 
            // lblPlayerHandValue
            // 
            this.lblPlayerHandValue.AutoSize = true;
            this.lblPlayerHandValue.Location = new System.Drawing.Point(941, 673);
            this.lblPlayerHandValue.Name = "lblPlayerHandValue";
            this.lblPlayerHandValue.Size = new System.Drawing.Size(76, 17);
            this.lblPlayerHandValue.TabIndex = 2;
            this.lblPlayerHandValue.Text = "handValue";
            // 
            // betFiveBtn
            // 
            this.betFiveBtn.BackColor = System.Drawing.Color.White;
            this.betFiveBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Blue;
            this.betFiveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betFiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betFiveBtn.Location = new System.Drawing.Point(3, 625);
            this.betFiveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.betFiveBtn.Name = "betFiveBtn";
            this.betFiveBtn.Size = new System.Drawing.Size(133, 123);
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
            this.betTenBtn.Location = new System.Drawing.Point(135, 625);
            this.betTenBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.betTenBtn.Name = "betTenBtn";
            this.betTenBtn.Size = new System.Drawing.Size(133, 123);
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
            this.betFiftyBtn.Location = new System.Drawing.Point(267, 625);
            this.betFiftyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.betFiftyBtn.Name = "betFiftyBtn";
            this.betFiftyBtn.Size = new System.Drawing.Size(133, 123);
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
            this.betHundredBtn.Location = new System.Drawing.Point(399, 625);
            this.betHundredBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.betHundredBtn.Name = "betHundredBtn";
            this.betHundredBtn.Size = new System.Drawing.Size(133, 123);
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
            this.betFiveHundredBtn.Location = new System.Drawing.Point(531, 625);
            this.betFiveHundredBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.betFiveHundredBtn.Name = "betFiveHundredBtn";
            this.betFiveHundredBtn.Size = new System.Drawing.Size(133, 123);
            this.betFiveHundredBtn.TabIndex = 7;
            this.betFiveHundredBtn.Text = "$500";
            this.betFiveHundredBtn.UseVisualStyleBackColor = false;
            this.betFiveHundredBtn.Click += new System.EventHandler(this.betFiveHundredBtn_Click);
            // 
            // betThousandBtn
            // 
            this.betThousandBtn.BackColor = System.Drawing.Color.White;
            this.betThousandBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Black;
            this.betThousandBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betThousandBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betThousandBtn.ForeColor = System.Drawing.Color.White;
            this.betThousandBtn.Location = new System.Drawing.Point(663, 625);
            this.betThousandBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.betThousandBtn.Name = "betThousandBtn";
            this.betThousandBtn.Size = new System.Drawing.Size(133, 123);
            this.betThousandBtn.TabIndex = 8;
            this.betThousandBtn.Text = "$1000";
            this.betThousandBtn.UseVisualStyleBackColor = false;
            this.betThousandBtn.Click += new System.EventHandler(this.betThousandBtn_Click);
            // 
            // betAndSetBtn
            // 
            this.betAndSetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betAndSetBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.betAndSetBtn.Location = new System.Drawing.Point(328, 756);
            this.betAndSetBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.betAndSetBtn.Name = "betAndSetBtn";
            this.betAndSetBtn.Size = new System.Drawing.Size(133, 28);
            this.betAndSetBtn.TabIndex = 9;
            this.betAndSetBtn.Text = "Bet";
            this.betAndSetBtn.UseVisualStyleBackColor = true;
            this.betAndSetBtn.Click += new System.EventHandler(this.betAndSetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1116, 641);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lost: $";
            // 
            // valueLostLbl
            // 
            this.valueLostLbl.AutoSize = true;
            this.valueLostLbl.BackColor = System.Drawing.Color.Transparent;
            this.valueLostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLostLbl.Location = new System.Drawing.Point(1209, 641);
            this.valueLostLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueLostLbl.Name = "valueLostLbl";
            this.valueLostLbl.Size = new System.Drawing.Size(24, 25);
            this.valueLostLbl.TabIndex = 11;
            this.valueLostLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1125, 665);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bet: $";
            // 
            // valueBetLbl
            // 
            this.valueBetLbl.AutoSize = true;
            this.valueBetLbl.BackColor = System.Drawing.Color.Transparent;
            this.valueBetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueBetLbl.Location = new System.Drawing.Point(1209, 665);
            this.valueBetLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueBetLbl.Name = "valueBetLbl";
            this.valueBetLbl.Size = new System.Drawing.Size(24, 25);
            this.valueBetLbl.TabIndex = 13;
            this.valueBetLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1120, 615);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "You: $";
            // 
            // valuePlayerLbl
            // 
            this.valuePlayerLbl.AutoSize = true;
            this.valuePlayerLbl.BackColor = System.Drawing.Color.Transparent;
            this.valuePlayerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuePlayerLbl.Location = new System.Drawing.Point(1209, 591);
            this.valuePlayerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valuePlayerLbl.Name = "valuePlayerLbl";
            this.valuePlayerLbl.Size = new System.Drawing.Size(24, 25);
            this.valuePlayerLbl.TabIndex = 15;
            this.valuePlayerLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1035, 591);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Most Gained: $";
            // 
            // valueMostGainedLbl
            // 
            this.valueMostGainedLbl.AutoSize = true;
            this.valueMostGainedLbl.BackColor = System.Drawing.Color.Transparent;
            this.valueMostGainedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueMostGainedLbl.Location = new System.Drawing.Point(1209, 615);
            this.valueMostGainedLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueMostGainedLbl.Name = "valueMostGainedLbl";
            this.valueMostGainedLbl.Size = new System.Drawing.Size(24, 25);
            this.valueMostGainedLbl.TabIndex = 17;
            this.valueMostGainedLbl.Text = "0";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.CasinoMortambo;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Location = new System.Drawing.Point(16, 15);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1323, 572);
            this.pnlBackground.TabIndex = 18;
            // 
            // btnStand
            // 
            this.btnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(816, 638);
            this.btnStand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(100, 28);
            this.btnStand.TabIndex = 19;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnDoubleDown
            // 
            this.btnDoubleDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoubleDown.Location = new System.Drawing.Point(816, 708);
            this.btnDoubleDown.Name = "btnDoubleDown";
            this.btnDoubleDown.Size = new System.Drawing.Size(100, 28);
            this.btnDoubleDown.TabIndex = 20;
            this.btnDoubleDown.Text = "Double Down";
            this.btnDoubleDown.UseVisualStyleBackColor = true;
            this.btnDoubleDown.Click += new System.EventHandler(this.btnDoubleDown_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.Location = new System.Drawing.Point(816, 742);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(100, 28);
            this.btnSplit.TabIndex = 21;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // BlackjackMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1355, 794);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnDoubleDown);
            this.Controls.Add(this.lblPlayerHandValue);
            this.Controls.Add(this.btnStand);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BlackjackMainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.BlackjackMainWindow_Load);
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
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnDoubleDown;
        private System.Windows.Forms.Button btnSplit;


    }
}