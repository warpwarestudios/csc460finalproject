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
            this.btnPlayerHandOne = new System.Windows.Forms.Button();
            this.btnPlayerHandTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(513, 617);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            // 
            // btnPlayerHandOne
            // 
            this.btnPlayerHandOne.Location = new System.Drawing.Point(639, 606);
            this.btnPlayerHandOne.Name = "btnPlayerHandOne";
            this.btnPlayerHandOne.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerHandOne.TabIndex = 1;
            this.btnPlayerHandOne.UseVisualStyleBackColor = true;
            // 
            // btnPlayerHandTwo
            // 
            this.btnPlayerHandTwo.Location = new System.Drawing.Point(730, 606);
            this.btnPlayerHandTwo.Name = "btnPlayerHandTwo";
            this.btnPlayerHandTwo.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerHandTwo.TabIndex = 2;
            this.btnPlayerHandTwo.UseVisualStyleBackColor = true;
            // 
            // BlackjackMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Casino_Mortambo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1426, 841);
            this.Controls.Add(this.btnPlayerHandTwo);
            this.Controls.Add(this.btnPlayerHandOne);
            this.Controls.Add(this.btnHit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BlackjackMainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.BlackjackMainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnPlayerHandOne;
        private System.Windows.Forms.Button btnPlayerHandTwo;


    }
}