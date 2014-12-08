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
            this.betAndSetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMostGained = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valueBetLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.valuePlayerLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalLost = new System.Windows.Forms.Label();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnDoubleDown = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.betFiftyBtn = new System.Windows.Forms.Button();
            this.betFiveBtn = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.betThousandBtn = new System.Windows.Forms.Button();
            this.betFiveHundredBtn = new System.Windows.Forms.Button();
            this.betHundredBtn = new System.Windows.Forms.Button();
            this.betTenBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalGained = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMostLost = new System.Windows.Forms.Label();
            this.lbltotalWin = new System.Windows.Forms.Label();
            this.lbltotalWinCount = new System.Windows.Forms.Label();
            this.btnSurrender = new System.Windows.Forms.Button();
            this.DownArrow1 = new System.Windows.Forms.Panel();
            this.DownArrow2 = new System.Windows.Forms.Panel();
            this.pnlBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.ForeColor = System.Drawing.Color.Gold;
            this.btnHit.Location = new System.Drawing.Point(621, 86);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(100, 50);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // betAndSetBtn
            // 
            this.betAndSetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.betAndSetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.betAndSetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betAndSetBtn.ForeColor = System.Drawing.Color.Gold;
            this.betAndSetBtn.Location = new System.Drawing.Point(269, 112);
            this.betAndSetBtn.Name = "betAndSetBtn";
            this.betAndSetBtn.Size = new System.Drawing.Size(100, 50);
            this.betAndSetBtn.TabIndex = 9;
            this.betAndSetBtn.Text = "Bet";
            this.betAndSetBtn.UseVisualStyleBackColor = false;
            this.betAndSetBtn.Click += new System.EventHandler(this.betAndSetBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(748, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Lost: $";
            // 
            // lblMostGained
            // 
            this.lblMostGained.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMostGained.AutoSize = true;
            this.lblMostGained.BackColor = System.Drawing.Color.Transparent;
            this.lblMostGained.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostGained.ForeColor = System.Drawing.Color.Gold;
            this.lblMostGained.Location = new System.Drawing.Point(854, 25);
            this.lblMostGained.Name = "lblMostGained";
            this.lblMostGained.Size = new System.Drawing.Size(16, 16);
            this.lblMostGained.TabIndex = 11;
            this.lblMostGained.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bet: $";
            // 
            // valueBetLbl
            // 
            this.valueBetLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.valueBetLbl.AutoSize = true;
            this.valueBetLbl.BackColor = System.Drawing.Color.Transparent;
            this.valueBetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueBetLbl.ForeColor = System.Drawing.Color.Gold;
            this.valueBetLbl.Location = new System.Drawing.Point(107, 121);
            this.valueBetLbl.Name = "valueBetLbl";
            this.valueBetLbl.Size = new System.Drawing.Size(30, 31);
            this.valueBetLbl.TabIndex = 13;
            this.valueBetLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(736, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Your Money: $";
            // 
            // valuePlayerLbl
            // 
            this.valuePlayerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.valuePlayerLbl.AutoSize = true;
            this.valuePlayerLbl.BackColor = System.Drawing.Color.Transparent;
            this.valuePlayerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuePlayerLbl.ForeColor = System.Drawing.Color.Gold;
            this.valuePlayerLbl.Location = new System.Drawing.Point(854, 12);
            this.valuePlayerLbl.Name = "valuePlayerLbl";
            this.valuePlayerLbl.Size = new System.Drawing.Size(16, 16);
            this.valuePlayerLbl.TabIndex = 15;
            this.valuePlayerLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(730, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Most Gained: $";
            // 
            // lblTotalLost
            // 
            this.lblTotalLost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalLost.AutoSize = true;
            this.lblTotalLost.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLost.ForeColor = System.Drawing.Color.Gold;
            this.lblTotalLost.Location = new System.Drawing.Point(854, 69);
            this.lblTotalLost.Name = "lblTotalLost";
            this.lblTotalLost.Size = new System.Drawing.Size(16, 16);
            this.lblTotalLost.TabIndex = 17;
            this.lblTotalLost.Text = "0";
            // 
            // btnStand
            // 
            this.btnStand.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.btnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.ForeColor = System.Drawing.Color.Gold;
            this.btnStand.Location = new System.Drawing.Point(621, 21);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(100, 50);
            this.btnStand.TabIndex = 19;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnDoubleDown
            // 
            this.btnDoubleDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDoubleDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.btnDoubleDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoubleDown.ForeColor = System.Drawing.Color.Gold;
            this.btnDoubleDown.Location = new System.Drawing.Point(829, 104);
            this.btnDoubleDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoubleDown.Name = "btnDoubleDown";
            this.btnDoubleDown.Size = new System.Drawing.Size(100, 50);
            this.btnDoubleDown.TabIndex = 20;
            this.btnDoubleDown.Text = "Double Down";
            this.btnDoubleDown.UseVisualStyleBackColor = false;
            this.btnDoubleDown.Click += new System.EventHandler(this.btnDoubleDown_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.ForeColor = System.Drawing.Color.Gold;
            this.btnSplit.Location = new System.Drawing.Point(726, 104);
            this.btnSplit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(100, 50);
            this.btnSplit.TabIndex = 21;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // betFiftyBtn
            // 
            this.betFiftyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.betFiftyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.betFiftyBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Orange;
            this.betFiftyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betFiftyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betFiftyBtn.Location = new System.Drawing.Point(221, 11);
            this.betFiftyBtn.Name = "betFiftyBtn";
            this.betFiftyBtn.Size = new System.Drawing.Size(100, 100);
            this.betFiftyBtn.TabIndex = 5;
            this.betFiftyBtn.Text = "$50";
            this.betFiftyBtn.UseVisualStyleBackColor = false;
            this.betFiftyBtn.Click += new System.EventHandler(this.betFiftyBtn_Click);
            // 
            // betFiveBtn
            // 
            this.betFiveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.betFiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.betFiveBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Blue;
            this.betFiveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betFiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betFiveBtn.Location = new System.Drawing.Point(25, 11);
            this.betFiveBtn.Name = "betFiveBtn";
            this.betFiveBtn.Size = new System.Drawing.Size(100, 100);
            this.betFiveBtn.TabIndex = 3;
            this.betFiveBtn.Text = "$5";
            this.betFiveBtn.UseVisualStyleBackColor = false;
            this.betFiveBtn.Click += new System.EventHandler(this.betFiveBtn_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.AutoSize = true;
            this.pnlBackground.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.CasinoMortambo;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.DownArrow2);
            this.pnlBackground.Controls.Add(this.DownArrow1);
            this.pnlBackground.Location = new System.Drawing.Point(12, 12);
            this.pnlBackground.MinimumSize = new System.Drawing.Size(10, 10);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1068, 377);
            this.pnlBackground.TabIndex = 18;
            // 
            // betThousandBtn
            // 
            this.betThousandBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.betThousandBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.betThousandBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Black;
            this.betThousandBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betThousandBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betThousandBtn.ForeColor = System.Drawing.Color.White;
            this.betThousandBtn.Location = new System.Drawing.Point(515, 11);
            this.betThousandBtn.Name = "betThousandBtn";
            this.betThousandBtn.Size = new System.Drawing.Size(100, 100);
            this.betThousandBtn.TabIndex = 8;
            this.betThousandBtn.Text = "$1000";
            this.betThousandBtn.UseVisualStyleBackColor = false;
            this.betThousandBtn.Click += new System.EventHandler(this.betThousandBtn_Click);
            // 
            // betFiveHundredBtn
            // 
            this.betFiveHundredBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.betFiveHundredBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.betFiveHundredBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Purple;
            this.betFiveHundredBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betFiveHundredBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betFiveHundredBtn.Location = new System.Drawing.Point(417, 11);
            this.betFiveHundredBtn.Name = "betFiveHundredBtn";
            this.betFiveHundredBtn.Size = new System.Drawing.Size(100, 100);
            this.betFiveHundredBtn.TabIndex = 7;
            this.betFiveHundredBtn.Text = "$500";
            this.betFiveHundredBtn.UseVisualStyleBackColor = false;
            this.betFiveHundredBtn.Click += new System.EventHandler(this.betFiveHundredBtn_Click);
            // 
            // betHundredBtn
            // 
            this.betHundredBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.betHundredBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.betHundredBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Red;
            this.betHundredBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betHundredBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betHundredBtn.Location = new System.Drawing.Point(319, 11);
            this.betHundredBtn.Name = "betHundredBtn";
            this.betHundredBtn.Size = new System.Drawing.Size(100, 100);
            this.betHundredBtn.TabIndex = 6;
            this.betHundredBtn.Text = "$100";
            this.betHundredBtn.UseVisualStyleBackColor = false;
            this.betHundredBtn.Click += new System.EventHandler(this.betHundredBtn_Click);
            // 
            // betTenBtn
            // 
            this.betTenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.betTenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.betTenBtn.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Chip_Green;
            this.betTenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.betTenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betTenBtn.Location = new System.Drawing.Point(123, 11);
            this.betTenBtn.Name = "betTenBtn";
            this.betTenBtn.Size = new System.Drawing.Size(100, 100);
            this.betTenBtn.TabIndex = 4;
            this.betTenBtn.Text = "$10";
            this.betTenBtn.UseVisualStyleBackColor = false;
            this.betTenBtn.Click += new System.EventHandler(this.betTenBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.BackgroundLayout;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTotalGained);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblMostLost);
            this.panel1.Controls.Add(this.lbltotalWin);
            this.panel1.Controls.Add(this.lbltotalWinCount);
            this.panel1.Controls.Add(this.btnSurrender);
            this.panel1.Controls.Add(this.btnSplit);
            this.panel1.Controls.Add(this.betThousandBtn);
            this.panel1.Controls.Add(this.betHundredBtn);
            this.panel1.Controls.Add(this.valueBetLbl);
            this.panel1.Controls.Add(this.btnDoubleDown);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnHit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.betTenBtn);
            this.panel1.Controls.Add(this.valuePlayerLbl);
            this.panel1.Controls.Add(this.btnStand);
            this.panel1.Controls.Add(this.lblMostGained);
            this.panel1.Controls.Add(this.betFiveHundredBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.betFiftyBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTotalLost);
            this.panel1.Controls.Add(this.betFiveBtn);
            this.panel1.Controls.Add(this.betAndSetBtn);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 169);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(729, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Total Gained: $";
            // 
            // lblTotalGained
            // 
            this.lblTotalGained.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalGained.AutoSize = true;
            this.lblTotalGained.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalGained.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGained.ForeColor = System.Drawing.Color.Gold;
            this.lblTotalGained.Location = new System.Drawing.Point(854, 39);
            this.lblTotalGained.Name = "lblTotalGained";
            this.lblTotalGained.Size = new System.Drawing.Size(16, 16);
            this.lblTotalGained.TabIndex = 28;
            this.lblTotalGained.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(750, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Most Lost: $";
            // 
            // lblMostLost
            // 
            this.lblMostLost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMostLost.AutoSize = true;
            this.lblMostLost.BackColor = System.Drawing.Color.Transparent;
            this.lblMostLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostLost.ForeColor = System.Drawing.Color.Gold;
            this.lblMostLost.Location = new System.Drawing.Point(854, 54);
            this.lblMostLost.Name = "lblMostLost";
            this.lblMostLost.Size = new System.Drawing.Size(16, 16);
            this.lblMostLost.TabIndex = 26;
            this.lblMostLost.Text = "0";
            // 
            // lbltotalWin
            // 
            this.lbltotalWin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalWin.AutoSize = true;
            this.lbltotalWin.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalWin.ForeColor = System.Drawing.Color.Gold;
            this.lbltotalWin.Location = new System.Drawing.Point(779, 84);
            this.lbltotalWin.Name = "lbltotalWin";
            this.lbltotalWin.Size = new System.Drawing.Size(46, 16);
            this.lbltotalWin.TabIndex = 23;
            this.lbltotalWin.Text = "Wins:";
            // 
            // lbltotalWinCount
            // 
            this.lbltotalWinCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalWinCount.AutoSize = true;
            this.lbltotalWinCount.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalWinCount.ForeColor = System.Drawing.Color.Gold;
            this.lbltotalWinCount.Location = new System.Drawing.Point(847, 87);
            this.lbltotalWinCount.Name = "lbltotalWinCount";
            this.lbltotalWinCount.Size = new System.Drawing.Size(29, 16);
            this.lbltotalWinCount.TabIndex = 24;
            this.lbltotalWinCount.Text = "0/0";
            // 
            // btnSurrender
            // 
            this.btnSurrender.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSurrender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.btnSurrender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurrender.ForeColor = System.Drawing.Color.Gold;
            this.btnSurrender.Location = new System.Drawing.Point(933, 104);
            this.btnSurrender.Margin = new System.Windows.Forms.Padding(2);
            this.btnSurrender.Name = "btnSurrender";
            this.btnSurrender.Size = new System.Drawing.Size(100, 50);
            this.btnSurrender.TabIndex = 22;
            this.btnSurrender.Text = "Surrender";
            this.btnSurrender.UseVisualStyleBackColor = false;
            this.btnSurrender.Click += new System.EventHandler(this.btnSurrender_Click);
            // 
            // DownArrow1
            // 
            this.DownArrow1.BackColor = System.Drawing.Color.Transparent;
            this.DownArrow1.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.downarrow;
            this.DownArrow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownArrow1.Location = new System.Drawing.Point(221, 150);
            this.DownArrow1.Name = "DownArrow1";
            this.DownArrow1.Size = new System.Drawing.Size(78, 72);
            this.DownArrow1.TabIndex = 2;
            // 
            // DownArrow2
            // 
            this.DownArrow2.BackColor = System.Drawing.Color.Transparent;
            this.DownArrow2.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.downarrow;
            this.DownArrow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownArrow2.Location = new System.Drawing.Point(732, 150);
            this.DownArrow2.Name = "DownArrow2";
            this.DownArrow2.Size = new System.Drawing.Size(78, 72);
            this.DownArrow2.TabIndex = 3;
            // 
            // BlackjackMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBackground);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BlackjackMainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.BlackjackMainWindow_Load);
            this.pnlBackground.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button betFiveBtn;
        private System.Windows.Forms.Button betTenBtn;
        private System.Windows.Forms.Button betFiftyBtn;
        private System.Windows.Forms.Button betHundredBtn;
        private System.Windows.Forms.Button betFiveHundredBtn;
        private System.Windows.Forms.Button betThousandBtn;
        private System.Windows.Forms.Button betAndSetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMostGained;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valueBetLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label valuePlayerLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalLost;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnDoubleDown;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSurrender;
        private System.Windows.Forms.Label lbltotalWin;
        private System.Windows.Forms.Label lbltotalWinCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMostLost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalGained;
        private System.Windows.Forms.Panel DownArrow2;
        private System.Windows.Forms.Panel DownArrow1;


    }
}