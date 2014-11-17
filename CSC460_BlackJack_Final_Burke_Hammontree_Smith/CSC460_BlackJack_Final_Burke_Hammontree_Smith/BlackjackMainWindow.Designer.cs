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
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(560, 672);
            this.btnHit.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblDealerHandValue.Location = new System.Drawing.Point(634, 281);
            this.lblDealerHandValue.Name = "lblDealerHandValue";
            this.lblDealerHandValue.Size = new System.Drawing.Size(76, 17);
            this.lblDealerHandValue.TabIndex = 1;
            this.lblDealerHandValue.Text = "handValue";
            // 
            // lblPlayerHandValue
            // 
            this.lblPlayerHandValue.AutoSize = true;
            this.lblPlayerHandValue.Location = new System.Drawing.Point(557, 717);
            this.lblPlayerHandValue.Name = "lblPlayerHandValue";
            this.lblPlayerHandValue.Size = new System.Drawing.Size(76, 17);
            this.lblPlayerHandValue.TabIndex = 2;
            this.lblPlayerHandValue.Text = "handValue";
            // 
            // BlackjackMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.CasinoMortambo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 937);
            this.Controls.Add(this.lblPlayerHandValue);
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


    }
}