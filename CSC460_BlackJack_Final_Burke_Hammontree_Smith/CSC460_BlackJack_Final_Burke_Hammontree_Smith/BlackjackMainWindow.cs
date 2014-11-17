using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cards;
using System.Resources;

namespace CSC460_BlackJack_Final_Burke_Hammontree_Smith
{
    public partial class BlackjackMainWindow : Form
    {
        // Variables
        public static Player activePlayer;
        bool dealerFirstDraw = true;
        Pack deck;
        Hand playerHand;
        Hand dealerHand;
        double betMoneyValue = 0; //bettng value takes place
        double playerMoneyValue = 10000; //How much player has currently
        double lostMoneyValue = 0;  //How much you lost total from the dealer
        double mostGainedValue = 0; //if win black jack the most gained bet sets here
 

        public BlackjackMainWindow()
        {
            InitializeComponent();
            MoneyButtonVisiblity(false);
            valuePlayerLbl.Text = playerMoneyValue.ToString();
            valueLostLbl.Text = lostMoneyValue.ToString();
            valueMostGainedLbl.Text = mostGainedValue.ToString();
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
            
            //create decks, deal initial hands
            deck = new Pack();
            playerHand = new Hand();
            dealerHand = new Hand();

            playerHand.AddCardToHand(deck.DealCardFromPack());
            playerHand.AddCardToHand(deck.DealCardFromPack());
            lblPlayerHandValue.Text = GetTotalHandValue(playerHand).ToString();

            dealerHand.AddCardToHand(deck.DealCardFromPack());
            dealerHand.AddCardToHand(deck.DealCardFromPack());
            lblDealerHandValue.Text = GetTotalHandValue(dealerHand).ToString();

            DisplayPlayerCards();
            DisplayDealerCards();
        }


        private void betAndSetBtn_Click(object sender, EventArgs e)
        {
            if (betAndSetBtn.Text == "Bet")
            {
                betAndSetBtn.Text = "Deal";
                MoneyButtonVisiblity(true);
                
            }
            else if (betAndSetBtn.Text == "Deal")
            {
                betAndSetBtn.Text = "Bet";
                MoneyButtonVisiblity(false);
                betAndSetBtn.Enabled = false;
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
            label3.Text = betMoneyValue.ToString();
        }

        private void PlayerMoneyControl()
        {
            MoneyButtonHandler(1000, betThousandBtn);
            MoneyButtonHandler(500, betFiveHundredBtn);
            MoneyButtonHandler(100, betHundredBtn);
            MoneyButtonHandler(50, betFiftyBtn);
            MoneyButtonHandler(10, betTenBtn);
            MoneyButtonHandler(5, betFiveBtn);
            BankMoneyControl();
        }

        private void BankMoneyControl()
        {
            if (playerMoneyValue == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Your current money is now $0, would you like to borrow money from the bank?", "Bank", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Bank has given you $100.");
                    playerMoneyValue += 100;
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

        private void DisplayPlayerCards()
        {
            //Displays all cards in hand
            for (int i = 1; i <= playerHand.CardsInHand().Count; i++)
            {
                //if control does not already exist create and position it
                if (!this.Controls.ContainsKey("Card" + i))
                {
                    Button newButton = new Button();
                    newButton.Name = "Card" + i;
                    newButton.Location = new Point(this.Size.Width / 2 + (35 * i), this.Size.Height - 250);
                    newButton.BackgroundImage = ((PlayingCard)playerHand.CardsInHand()[i - 1]).CardImage();
                    newButton.BackgroundImageLayout = ImageLayout.Stretch;
                    newButton.Size = new Size(100, 150);
                    this.Controls.Add(newButton);
                    this.Controls.SetChildIndex(newButton, playerHand.CardsInHand().Count - i);
                }
            }
        }

        private void DisplayDealerCards()
        {
            //Displays all cards in hand
            for (int i = 1; i <= dealerHand.CardsInHand().Count; i++)
            {
                //if control does not already exist create and position it
                if (!this.Controls.ContainsKey("DealerCard" + i))
                {
                    if (dealerFirstDraw)
                    {
                        Button newButton = new Button();
                        newButton.Name = "DealerCard" + i;
                        newButton.Location = new Point(this.Size.Width / 2 + (35 * i), 300);
                        newButton.BackgroundImage = ((PlayingCard)dealerHand.CardsInHand()[i - 1]).HiddenCardImage();
                        newButton.BackgroundImageLayout = ImageLayout.Stretch;
                        newButton.Size = new Size(100, 150);
                        this.Controls.Add(newButton);
                        this.Controls.SetChildIndex(newButton, playerHand.CardsInHand().Count - i);
                        dealerFirstDraw = false;
                    }
                    else
                    {
                        Button newButton = new Button();
                        newButton.Name = "DealerCard" + i;
                        newButton.Location = new Point(this.Size.Width / 2 + (35 * i), 300);
                        newButton.BackgroundImage = ((PlayingCard)dealerHand.CardsInHand()[i - 1]).CardImage();
                        newButton.BackgroundImageLayout = ImageLayout.Stretch;
                        newButton.Size = new Size(100, 150);
                        this.Controls.Add(newButton);
                        this.Controls.SetChildIndex(newButton, playerHand.CardsInHand().Count - i);
                    }
                }
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            playerHand.AddCardToHand(deck.DealCardFromPack());
            lblPlayerHandValue.Text = GetTotalHandValue(playerHand).ToString();
            DisplayPlayerCards();
        }

        //intended to add everything up to make it easier to check for win conditions
        private int GetTotalHandValue(Hand hand)
        {
            int handValue = 0;

            foreach (PlayingCard card in hand.CardsInHand())
            {
                if (card.CardValue() > Value.Nine && card.CardValue() < Value.Ace)
                {
                    handValue += 10;
                    continue;
                }
                else if (card.CardValue() < Value.Ten)
                {
                    switch (card.CardValue())
                    {
                        case Value.Two:
                            handValue += 2;
                            break;
                        case Value.Three:
                            handValue += 3;
                            break;
                        case Value.Four:
                            handValue += 4;
                            break;
                        case Value.Five:
                            handValue += 5;
                            break;
                        case Value.Six:
                            handValue += 6;
                            break;
                        case Value.Seven:
                            handValue += 7;
                            break;
                        case Value.Eight:
                            handValue += 8;
                            break;
                        case Value.Nine:
                            handValue += 9;
                            break;
                    }
                    continue;
                }
                else if (card.CardValue() == Value.Ace)
                {
                    if (handValue + 11 > 21)
                    {
                        handValue += 1;
                    }
                    else
                    {
                        handValue += 11;
                    }
                }
            }
            return handValue;
        }



    }


}
