using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSC460_BlackJack_Final_Burke_Hammontree_Smith
{
    public partial class BlackjackMainWindow : Form
    {
        // Variables
        public static Player activePlayer;

        double betMoneyValue = 0;
        double playerMoneyValue = 10000;
        double dealerMoneyValue = 10000000;
 
        public BlackjackMainWindow()
        {
            InitializeComponent();
           
            MoneyButtonVisiblity(false);
            valuePlayerLbl.Text = playerMoneyValue.ToString();
            valueDealerLbl.Text = dealerMoneyValue.ToString();
           
        }

        private void playerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void BlackjackMainWindow_Load(object sender, EventArgs e)
        {
            LogInWindow login = new LogInWindow();
            login.ShowDialog(this);

            // if player closed login window without logging in
            // close this window to finish complete program shutdown
            if (activePlayer == null)
            { this.Close(); }
        }


        private void betAndDealBtn_Click(object sender, EventArgs e)
        {
            if (betAndDealBtn.Text == "Bet")
            {
                betAndDealBtn.Text = "Deal";
                MoneyButtonVisiblity(true);
                
            }
            else if (betAndDealBtn.Text == "Deal")
            {
                betAndDealBtn.Text = "Bet";
                MoneyButtonVisiblity(false);
                betAndDealBtn.Enabled = false;
            }
        }

        private void MoneyButtonVisiblity(bool enable)
        {
            //sets the betting money buttons to false or true 
            betFiveBtn.Visible = enable;
            betTenBtn.Visible = enable;
            betFiftyBtn.Visible = enable;
            betHundredBtn.Visible = enable;
            betFiveHundredBtn.Visible = enable;
            betThousandBtn.Visible = enable;

        }
        private void betFiveBtn_Click(object sender, EventArgs e)
        {
            PlayerMoneyControl();
            BettingMoneyGrabber(5);
            PlayerMoneyControl();
 
        }

        private void betTenBtn_Click(object sender, EventArgs e)
        {
            PlayerMoneyControl();
            BettingMoneyGrabber(10);
            PlayerMoneyControl();

        }

        private void betFiftyBtn_Click(object sender, EventArgs e)
        {
            PlayerMoneyControl();
            BettingMoneyGrabber(50);
            PlayerMoneyControl();

        }

        private void betHundredBtn_Click(object sender, EventArgs e)
        {
            PlayerMoneyControl();
            BettingMoneyGrabber(100);
            PlayerMoneyControl();
            
        }

        private void betFiveHundredBtn_Click(object sender, EventArgs e)
        {
            PlayerMoneyControl();
            BettingMoneyGrabber(500);
            PlayerMoneyControl();
            
        }

        private void betThousandBtn_Click(object sender, EventArgs e)
        {
            PlayerMoneyControl();
            BettingMoneyGrabber(1000);
            PlayerMoneyControl();
            
        }

        private void BettingMoneyGrabber(double amount)
        {
            
            //Grabs the money from the button to the betting table subtracting the player's money.
            playerMoneyValue = playerMoneyValue - amount;
            betMoneyValue = betMoneyValue + amount;
            valuePlayerLbl.Text = playerMoneyValue.ToString();
            valueBetLbl.Text = betMoneyValue.ToString();
        }

        private void PlayerMoneyControl()
        {
            MoneyButtonHandler(1000, betThousandBtn);
            MoneyButtonHandler(500, betFiveHundredBtn);
            MoneyButtonHandler(100, betHundredBtn);
            MoneyButtonHandler(50, betFiftyBtn);
            MoneyButtonHandler(10, betTenBtn);
            MoneyButtonHandler(5, betFiveBtn);
            if (playerMoneyValue == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Your current money is now $0, would you like to borrow money from the bank?", "Bank", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    BankWindow bankWindow = new BankWindow();
                    bankWindow.ShowDialog();
                    playerMoneyValue = bankWindow.amountBorrow;
                    valuePlayerLbl.Text = playerMoneyValue.ToString();
                    PlayerMoneyControl();
                }
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Insert the surrender here");
                    PlayerMoneyControl();
                }
            }
            

        }

        private void MoneyButtonHandler(double amount, Button moneyButton)
        {
            if (playerMoneyValue < amount)
            {
                moneyButton.Enabled = false;
            }
            else
            {
                moneyButton.Enabled = true;
            }

        }

    }


}
