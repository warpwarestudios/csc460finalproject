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
        bool stand = false;
        bool dealerStand = false;
        Pack deck;
        Hand playerHand;
        Hand dealerHand;
        double playerMoneyValue; // How much player has currently
        double playerDebt; // How much player owes bank
        double betMoneyValue = 0; // bettng value takes place
        double lostMoneyValue = 0;  // How much you lost total from the dealer
        double mostGainedValue = 0; // if win black jack the most gained bet sets here
 

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
            
            //create decks and hands
            deck = new Pack();
            playerHand = new Hand();
            dealerHand = new Hand();

            double playerMoneyValue = (double)activePlayer.Bank; // retrieve current player's money
            valuePlayerLbl.Text = playerMoneyValue.ToString();
            if (activePlayer.Borrow != null)
            {
                playerDebt = (double)activePlayer.Borrow; // retrieve how much player owes bank
            }
            else
            {
                playerDebt = 0;
            }
        }


        private void betAndSetBtn_Click(object sender, EventArgs e)
        {
            if (betAndSetBtn.Text == "Bet")
            {
                betAndSetBtn.Text = "Deal";
                btnHit.Enabled = false;
                BettingMoneyGrabber(5);
                MoneyButtonVisiblity(true);
                
            }
            else if (betAndSetBtn.Text == "Deal")
            {
                betAndSetBtn.Text = "Bet";
                MoneyButtonVisiblity(false);
                betAndSetBtn.Enabled = false;
                btnHit.Enabled = true;
                Deal();
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
                betAndSetBtn.Text = "Bet";
                MoneyButtonVisiblity(false);
                betAndSetBtn.Enabled = false;
                btnHit.Enabled = true;
                Deal();
            }
        } 

        private void MoneyButtonHandler(double amount, Button moneyButton)
        {
            if (playerMoneyValue < amount)
            { moneyButton.Enabled = false; }
            else
            { moneyButton.Enabled = true; }
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
                    newButton.Parent = pnlBackground;
                    newButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                    newButton.Size = new Size(100, 150);
                    newButton.Location = new Point(newButton.Parent.Size.Width / 2 + (35 * i), newButton.Parent.Size.Height - newButton.Size.Height - 50);
                    newButton.BackgroundImage = ((PlayingCard)playerHand.CardsInHand()[i - 1]).CardImage();
                    newButton.BackgroundImageLayout = ImageLayout.Stretch;
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
                        newButton.Location = new Point(this.Size.Width / 2 + (35 * i), 100);
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
                        newButton.Location = new Point(this.Size.Width / 2 + (35 * i), 100);
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
            //if no win condition is met, dealer hits
            if (!CheckForWin())
            {
                DealerHit();
            }

        }

        private void DealerHit()
        {
            //if dealer isn't standing, give him a card and check for win
            if (!dealerStand)
            {
                dealerHand.AddCardToHand(deck.DealCardFromPack());
                lblDealerHandValue.Text = GetTotalHandValue(dealerHand).ToString();
                DisplayDealerCards();
                CheckForWin();
            }
            if (GetTotalHandValue(dealerHand) >= 17)
            {
                dealerStand = true;
            }
        }

        //check for win condition, sends true if a win condition is met
        private bool CheckForWin()
        {
            bool win = false;

            //dealer has 21, dealer wins 
            if (GetTotalHandValue(dealerHand) == 21)
            {
                //check for tie, otherwise dealer wins
                if (GetTotalHandValue(dealerHand) == GetTotalHandValue(playerHand))
                {
                    playerMoneyValue = (double)activePlayer.Bank; // retrieve current player's money
                    valuePlayerLbl.Text = playerMoneyValue.ToString();
                    betMoneyValue = 0;
                    valueBetLbl.Text = betMoneyValue.ToString();
                    DialogResult dialogResult = MessageBox.Show("We tied! Here's your bet back.", "Tied!", MessageBoxButtons.OK);
                    betAndSetBtn.Enabled = true;
                }
                else
                {
                    DatabaseCall.UpdateBank(activePlayer, (decimal)(-betMoneyValue), false);
                    playerMoneyValue = (double)activePlayer.Bank; // retrieve current player's money
                    betMoneyValue = 0;
                    valueBetLbl.Text = betMoneyValue.ToString();
                    DialogResult dialogResult = MessageBox.Show("I got Blackjack! You lose your bet.", "Lose!", MessageBoxButtons.OK);
                    betAndSetBtn.Enabled = true;
                }
                btnHit.Enabled = false;
                win = true;
            }
            //player has 21, player wins
            else if (GetTotalHandValue(playerHand) == 21)
            {
                //if the player is dealt 21 in first deal, then they get 3 to 2 return on bet
                if (playerHand.CardsInHand().Count == 21)
                {
                    DatabaseCall.UpdateBank(activePlayer, (decimal)(betMoneyValue * 2.5), false);
                    playerMoneyValue = (double)activePlayer.Bank; // retrieve current player's money
                }
                else
                {
                    DatabaseCall.UpdateBank(activePlayer, (decimal)(betMoneyValue * 2), false);
                    playerMoneyValue = (double)activePlayer.Bank; // retrieve current player's money
                }
                playerMoneyValue = (double)activePlayer.Bank; // retrieve current player's money
                valuePlayerLbl.Text = playerMoneyValue.ToString();
                betMoneyValue = 0;
                valueBetLbl.Text = betMoneyValue.ToString();
                DialogResult dialogResult = MessageBox.Show("You got Blackjack! Great job! Here's your money.", "Win!", MessageBoxButtons.OK);
                betAndSetBtn.Enabled = true;
                btnHit.Enabled = false;
                win = true;
            }
            //player busts
            else if (CheckForBust(playerHand))
            {
                DatabaseCall.UpdateBank(activePlayer, (decimal)(-betMoneyValue), false);
                playerMoneyValue = (double)activePlayer.Bank; // retrieve current player's money
                betMoneyValue = 0;
                valueBetLbl.Text = betMoneyValue.ToString();
                DialogResult dialogResult = MessageBox.Show("You busted! You lose your bet.", "Lose!", MessageBoxButtons.OK);
                betAndSetBtn.Enabled = true;
                btnHit.Enabled = false;
                win = true;
            }
            //dealer busts
            else if (CheckForBust(dealerHand))
            {
                DatabaseCall.UpdateBank(activePlayer, (decimal)(betMoneyValue * 2), false);
                playerMoneyValue = (double)activePlayer.Bank; // retrieve current player's money
                valuePlayerLbl.Text = playerMoneyValue.ToString();
                betMoneyValue = 0;
                valueBetLbl.Text = betMoneyValue.ToString();
                DialogResult dialogResult = MessageBox.Show("I busted! Here's your money.", "Win!", MessageBoxButtons.OK);
                betAndSetBtn.Enabled = true;
                btnHit.Enabled = false;
                win = true;
            }
            //dealer and player hands are tied
            else if (GetTotalHandValue(dealerHand) == GetTotalHandValue(playerHand))
            {
                playerMoneyValue = (double)activePlayer.Bank; // retrieve current player's money
                valuePlayerLbl.Text = playerMoneyValue.ToString();
                valueBetLbl.Text = betMoneyValue.ToString();
                DialogResult dialogResult = MessageBox.Show("We tied! Here's your bet back.", "Tied!", MessageBoxButtons.OK);
                betAndSetBtn.Enabled = true;
                btnHit.Enabled = false;
                win = true;
            }

            // borrow money if player is out of money
            if (playerMoneyValue == 0)
            {
                DatabaseCall.UpdateBank(activePlayer, 0, true);
                playerDebt = (double)activePlayer.Borrow; // retrieve how much player owes bank
                playerMoneyValue = (double)activePlayer.Bank; // retrieve current player's money
                valuePlayerLbl.Text = playerMoneyValue.ToString();
            }

            return win;
        }
        //check for hand greater than 21
        private bool CheckForBust(Hand hand)
        {
            bool bust = false;

            if (GetTotalHandValue(hand) > 21)
            { bust = true; }

            return bust;
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
                    { handValue += 1; }
                    else
                    { handValue += 11; }
                }
            }
            return handValue;
        }


        private void Deal()
        {

            //delete all cards shown in player and dealer hands
            DeletePlayerCards();
            DeleteDealerCards();

            dealerFirstDraw = true;
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

            CheckForWin();
        }

        private void DeletePlayerCards()
        {
            //Deletes all cards shown
            for (int i = 1; i <= playerHand.CardsInHand().Count; i++)
            {
                if (this.Controls.ContainsKey("Card" + i))
                {
                    this.Controls.RemoveByKey("Card" + i);
                }
            }
        }
        private void DeleteDealerCards()
        {
            //Deletes all cards shown
            for (int i = 1; i <= playerHand.CardsInHand().Count; i++)
            {
                if (this.Controls.ContainsKey("DealerCard" + i))
                {
                    this.Controls.RemoveByKey("DealerCard" + i);
                }
            }
        }
    }


}
