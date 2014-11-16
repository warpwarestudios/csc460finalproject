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
            this.SuspendLayout();
            // 
            // BlackjackMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources.Casino_Mortambo;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BlackjackMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.BlackjackMainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

    }
}