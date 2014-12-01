﻿using System;
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
        Hand playerHand1 , playerHand2, playerHand3;
        Hand dealerHand;
        double playerMoneyValue;// retrieve current player's money
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
            playerHand1 = new Hand();
            playerHand2 = new Hand();
            playerHand3 = new Hand();
            dealerHand = new Hand();

            valuePlayerLbl.Text = playerMoneyValue.ToString();
            if (activePlayer.Borrow != null)
            { playerDebt = (double)activePlayer.Borrow; } // retrieve how much player owes bank
            else
            { playerDebt = 0; }

            btnHit.Enabled = false;
            btnStand.Enabled = false;
        }

        private void DisplayPlayerCards(Hand hand)
        {
            //Displays all cards in hand
            for (int i = 1; i <= hand.CardsInHand().Count; i++)
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
                    newButton.BackgroundImage = ((PlayingCard)hand.CardsInHand()[i - 1]).CardImage();
                    newButton.BackgroundImageLayout = ImageLayout.Stretch;
                    this.Controls.Add(newButton);
                    this.Controls.SetChildIndex(newButton, hand.CardsInHand().Count - i);
                }
            }
        }

        private void DisplayDealerCards(Hand hand)
        {
            //Displays all cards in hand
            for (int i = 1; i <= hand.CardsInHand().Count; i++)
            {
                //if control does not already exist create and position it
                if (!this.Controls.ContainsKey("DealerCard" + i))
                {
                    if (dealerFirstDraw)
                    {
                        Button newButton = new Button();
                        newButton.Name = "DealerCard" + i;
                        newButton.Location = new Point(this.Size.Width / 2 + (35 * i), 100);
                        newButton.BackgroundImage = ((PlayingCard)hand.CardsInHand()[i - 1]).HiddenCardImage();
                        newButton.BackgroundImageLayout = ImageLayout.Stretch;
                        newButton.Size = new Size(100, 150);
                        this.Controls.Add(newButton);
                        this.Controls.SetChildIndex(newButton, hand.CardsInHand().Count - i);
                        dealerFirstDraw = false;
                    }
                    else
                    {
                        Button newButton = new Button();
                        newButton.Name = "DealerCard" + i;
                        newButton.Location = new Point(this.Size.Width / 2 + (35 * i), 100);
                        newButton.BackgroundImage = ((PlayingCard)hand.CardsInHand()[i - 1]).CardImage();
                        newButton.BackgroundImageLayout = ImageLayout.Stretch;
                        newButton.Size = new Size(100, 150);
                        this.Controls.Add(newButton);
                        this.Controls.SetChildIndex(newButton, hand.CardsInHand().Count - i);
                    }
                }
            }
        }

        

        private void DealerHit()
        {
            //if dealer isn't standing, give him a card and check for win
            while (!dealerStand)
            {
                if (GetTotalHandValue(dealerHand) >= 17)
                {
                    dealerStand = true;
                }
                else
                {
                    dealerHand.AddCardToHand(deck.DealCardFromPack());
                    lblDealerHandValue.Text = GetTotalHandValue(dealerHand).ToString();
                }
            }
        }

        //check for win condition, sends true if a win condition is met
        private bool CheckForBlackjack(Hand hand)
        {
            bool blackjack = false;

            if (GetTotalHandValue(hand) == 21)
            {
                blackjack = true;
            }

            return blackjack;
        }

        //check for hand greater than 21
        private bool CheckForBust(Hand hand)
        {
            bool bust = false;

            if (GetTotalHandValue(hand) > 21)
            { bust = true; }

            return bust;
        }

        private void Deal()
        {
            //delete all cards shown in player and dealer hands
            DeleteCards(playerHand1);
            DeleteCards(dealerHand);

            dealerFirstDraw = true;
            playerHand1 = new Hand();
            dealerHand = new Hand();

            playerHand1.AddCardToHand(deck.DealCardFromPack());
            playerHand1.AddCardToHand(deck.DealCardFromPack());
            lblPlayerHandValue.Text = GetTotalHandValue(playerHand1).ToString();

            dealerHand.AddCardToHand(deck.DealCardFromPack());
            dealerHand.AddCardToHand(deck.DealCardFromPack());
            lblDealerHandValue.Text = GetTotalHandValue(dealerHand).ToString();

            DisplayPlayerCards(playerHand1);
            DisplayDealerCards(dealerHand);

            //Check for initial win conditions
            if (CheckForBlackjack(playerHand1))
            {
                
                MessageBox.Show("You got blackjack! Great job! Here's your money.","Win!",MessageBoxButtons.OK);
            }
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

        private void DeleteCards(Hand hand)
        {
            //Deletes all cards shown
            for (int i = 1; i <= hand.CardsInHand().Count; i++)
            {
                if (this.Controls.ContainsKey("Card" + i))
                {
                    this.Controls.RemoveByKey("Card" + i);
                }

                if (this.Controls.ContainsKey("DealerCard" + i))
                {
                    this.Controls.RemoveByKey("DealerCard" + i);
                }
            }
        }

        //Reference for borrowing
        // borrow money if player is out of money
       /*     if (playerMoneyValue == 0)
            {
                DatabaseCall.UpdateBank(activePlayer, 0, true);
                playerDebt = (double)activePlayer.Borrow; // retrieve how much player owes bank
                playerMoneyValue = (double)activePlayer.Bank; // retrieve current player's money
                valuePlayerLbl.Text = playerMoneyValue.ToString();
            }*/

        // *BUTTONS AND STUFF*

        private void btnHit_Click(object sender, EventArgs e)
        {
            playerHand1.AddCardToHand(deck.DealCardFromPack());
            lblPlayerHandValue.Text = GetTotalHandValue(playerHand1).ToString();
            DisplayPlayerCards(playerHand1);
            //if no win condition is met, dealer hits
            //TODO: Add win conditions

        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            stand = true;
            ((Button)this.Controls["DealerCard1"]).BackgroundImage = ((PlayingCard)dealerHand.CardsInHand()[0]).CardImage();
            DealerHit();
            DisplayDealerCards(dealerHand);
            //TODO: Check for win conditions
        }

        //Double down
        private void btnDoubleDown_Click(object sender, EventArgs e)
        {

        }

        //Split hand
        private void btnSplit_Click(object sender, EventArgs e)
        {

        }
        private void betAndSetBtn_Click(object sender, EventArgs e)
        {
            playerMoneyValue = (double)activePlayer.Bank; // retrieve current player's money

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
                btnStand.Enabled = true;
                Deal();
            }
        }

        private void BettingMoneyGrabber(double amount)
        {
            //Grabs the money from the button to the betting table subtracting the player's money.
            playerMoneyValue = playerMoneyValue - amount;
            valuePlayerLbl.Text = playerMoneyValue.ToString();
            betMoneyValue = betMoneyValue + amount;
            valuePlayerLbl.Text = playerMoneyValue.ToString();
            valueBetLbl.Text = betMoneyValue.ToString();

            if (playerMoneyValue == 0)
            {
                betAndSetBtn.Text = "Bet";
                MoneyButtonVisiblity(false);
                betAndSetBtn.Enabled = false;
                btnHit.Enabled = true;
                Deal();
            }
        }
        private void PlayerMoneyControl()
        {
            MoneyButtonHandler(1000, betThousandBtn);
            MoneyButtonHandler(500, betFiveHundredBtn);
            MoneyButtonHandler(100, betHundredBtn);
            MoneyButtonHandler(50, betFiftyBtn);
            MoneyButtonHandler(10, betTenBtn);
            MoneyButtonHandler(5, betFiveBtn);
        }
        private void MoneyButtonHandler(double amount, Button moneyButton)
        {
            if (playerMoneyValue < amount)
            { moneyButton.Enabled = false; }
            else
            { moneyButton.Enabled = true; }
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
        
    }


}
