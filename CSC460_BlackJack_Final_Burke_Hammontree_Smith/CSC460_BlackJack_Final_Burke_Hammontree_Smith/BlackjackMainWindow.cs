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
        bool stand1 = false, stand2 = false, stand3 = false;
        bool dealerStand = false;
        int splits = 0; // number off times the player has split
        Pack deck;
        Hand playerHand1, playerHand2, playerHand3; // holders for all possible player hands
        Hand activePlayerHand;// current playing player hand
        Hand dealerHand; // dealer hand
        int playerMoneyValue;// retrieve current player's money
        int playerDebt; // How much player owes bank
        int betMoneyValue = 0; // bettng value takes place
        int lostTotalMoneyValue;  // How much you lost total from the dealer
        int gainTotalMoneyValue; // How much you won total from the games
        int gainMostMoneyValue; //How much you gain the most
        int lostMostMoneyValue; //how much you lost the most
        int totalGames;  //total games
        int totalWins;  //total wins in games
 

        public BlackjackMainWindow()
        {
            InitializeComponent();
            MoneyButtonVisiblity(false);
            valuePlayerLbl.Text = playerMoneyValue.ToString();
            lblTotalLost.Text = lostTotalMoneyValue.ToString();
            lblTotalGained.Text = gainTotalMoneyValue.ToString();
            lblMostGained.Text = gainMostMoneyValue.ToString();
            lblMostLost.Text = lostMostMoneyValue.ToString();
            lbltotalWinCount.Text = totalWins.ToString() + "/" + totalGames.ToString();
        }

        private void playerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void BlackjackMainWindow_Load(object sender, EventArgs e)
        {
            LogInWindow login = new LogInWindow();
            login.ShowDialog(this);

            this.WindowState = FormWindowState.Maximized;
            // if player closed login window without logging in
            // close this window to finish complete program shutdown
            if (activePlayer == null)
            { this.Close(); }
            
            //create decks and hands
            deck = new Pack();
            activePlayerHand = new Hand();
            playerHand1 = new Hand();
            playerHand2 = new Hand();
            playerHand3 = new Hand();
            dealerHand = new Hand();

            //get values from database and fill player money
            if (activePlayer != null)
            {
                playerMoneyValue = (int)activePlayer.Bank;
                valuePlayerLbl.Text = playerMoneyValue.ToString();
                if (activePlayer.Borrow != null)
                { playerDebt = (int)activePlayer.Borrow; } // retrieve how much player owes bank
                else
                { playerDebt = 0; }
            }
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            btnDoubleDown.Enabled = false;
            btnDoubleDown.Visible = false;
            btnSplit.Enabled = false;
            btnSplit.Visible = false;
            btnSurrender.Enabled = false;
            btnSurrender.Visible = false;
        }

        private void DisplayPlayerCards()
        {
            int size = 0;
            //Displays all cards in hand
            //if hand has not been split
            if (splits == 0)
            {
                for (int i = 1; i <= activePlayerHand.CardsInHand().Count; i++)
                {
                    //if control does not already exist create and position it
                    if (!pnlBackground.Controls.ContainsKey("Card" + i))
                    {
                        Button newButton = new Button();
                        newButton.Name = "Card" + i;
                        newButton.Parent = pnlBackground;
                        newButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                        size = newButton.Parent.Height / 8;
                        newButton.Size = new Size(size, (int)(size * 1.5));
                        newButton.Location = new Point((newButton.Parent.Size.Width / 2) - 35 + (35 * i), newButton.Parent.Size.Height - newButton.Size.Height - size);
                        newButton.BackgroundImage = ((PlayingCard)activePlayerHand.CardsInHand()[i - 1]).CardImage();
                        newButton.BackgroundImageLayout = ImageLayout.Stretch;
                        pnlBackground.Controls.Add(newButton);
                        pnlBackground.Controls.SetChildIndex(newButton, activePlayerHand.CardsInHand().Count - i);
                    }
                }
            }
            //hand is split once
            else if (splits == 1)
            {
                //create cards for playerHand1
                for (int i = 1; i <= playerHand1.CardsInHand().Count + playerHand2.CardsInHand().Count; i++)
                {
                    //if control does not already exist create and position it
                    if (!pnlBackground.Controls.ContainsKey("Card" + i) && i <= playerHand1.CardsInHand().Count)
                    {
                        Button newButton = new Button();
                        newButton.Name = "Card" + i;
                        newButton.Parent = pnlBackground;
                        newButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                        size = newButton.Parent.Height / 8;
                        newButton.Size = new Size(size, (int)(size * 1.5));
                        newButton.Location = new Point((newButton.Parent.Size.Width / 4) - 35 + (35 * i), newButton.Parent.Size.Height - newButton.Size.Height - size);
                        newButton.BackgroundImage = ((PlayingCard)playerHand1.CardsInHand()[i - 1]).CardImage();
                        newButton.BackgroundImageLayout = ImageLayout.Stretch;
                        pnlBackground.Controls.Add(newButton);
                        //pnlBackground.Controls.SetChildIndex(newButton, playerHand1.CardsInHand().Count - i);
                    }
                    //create cards for playerHand2
                    //if control does not already exist create and position it
                    else if (!pnlBackground.Controls.ContainsKey("Card" + i) && i > playerHand1.CardsInHand().Count)
                    {
                        Button newButton = new Button();
                        newButton.Name = "Card" + i;
                        newButton.Parent = pnlBackground;
                        newButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                        size = newButton.Parent.Height / 8;
                        newButton.Size = new Size(size, (int)(size * 1.5));
                        newButton.Location = new Point((newButton.Parent.Size.Width * 3 / 4) - 35 + (35 * i), newButton.Parent.Size.Height - newButton.Size.Height - size);
                        newButton.BackgroundImage = ((PlayingCard)playerHand2.CardsInHand()[i - (1 + playerHand1.CardsInHand().Count) ]).CardImage();
                        newButton.BackgroundImageLayout = ImageLayout.Stretch;
                        pnlBackground.Controls.Add(newButton);
                        //pnlBackground.Controls.SetChildIndex(newButton, i - playerHand2.CardsInHand().Count);
                    }
                }
            }
            else if (splits == 2)
            {
                int totalCardNum = playerHand1.CardsInHand().Count + playerHand2.CardsInHand().Count + playerHand3.CardsInHand().Count;
                int cardsPlaced = 0;
                //create cards for playerHand1
                for (int i = 1; i <= totalCardNum; i++)
                {
                    //if control does not already exist create and position it
                    if (!pnlBackground.Controls.ContainsKey("Card" + i) && i <= playerHand1.CardsInHand().Count)
                    {
                        Button newButton = new Button();
                        newButton.Name = "Card" + i;
                        newButton.Parent = pnlBackground;
                        newButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                        size = newButton.Parent.Height / 8;
                        newButton.Size = new Size(size, (int)(size * 1.5));
                        newButton.Location = new Point((newButton.Parent.Size.Width / 4) - 35 + (35 * i), newButton.Parent.Size.Height - newButton.Size.Height - size);
                        newButton.BackgroundImage = ((PlayingCard)playerHand1.CardsInHand()[i - 1]).CardImage();
                        newButton.BackgroundImageLayout = ImageLayout.Stretch;
                        pnlBackground.Controls.Add(newButton);
                        pnlBackground.Controls.SetChildIndex(newButton, playerHand1.CardsInHand().Count - i);
                        cardsPlaced = playerHand1.CardsInHand().Count;
                    }
                    //create cards for playerHand2
                    //if control does not already exist create and position it
                    else if (!pnlBackground.Controls.ContainsKey("Card" + i) && i > cardsPlaced)
                    {
                        Button newButton = new Button();
                        newButton.Name = "Card" + i;
                        newButton.Parent = pnlBackground;
                        newButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                        size = newButton.Parent.Height / 8;
                        newButton.Size = new Size(size, (int)(size * 1.5));
                        newButton.Location = new Point((newButton.Parent.Size.Width * 3 / 4) - 35 + (35 * i), newButton.Parent.Size.Height - newButton.Size.Height - size);
                        newButton.BackgroundImage = ((PlayingCard)playerHand2.CardsInHand()[i - (1 + cardsPlaced)]).CardImage();
                        newButton.BackgroundImageLayout = ImageLayout.Stretch;
                        pnlBackground.Controls.Add(newButton);
                        pnlBackground.Controls.SetChildIndex(newButton, i - cardsPlaced);
                        cardsPlaced += playerHand2.CardsInHand().Count;
                    }
                    //create cards for playerHand3
                    //if control does not already exist create and position it
                    else if (!pnlBackground.Controls.ContainsKey("Card" + i) && i > cardsPlaced)
                    {
                        Button newButton = new Button();
                        newButton.Name = "Card" + i;
                        newButton.Parent = pnlBackground;
                        newButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                        size = newButton.Parent.Height / 8;
                        newButton.Size = new Size(size, (int)(size * 1.5));
                        newButton.Location = new Point((newButton.Parent.Size.Width * 3 / 4) - 35 + (35 * i), newButton.Parent.Size.Height - newButton.Size.Height - size);
                        newButton.BackgroundImage = ((PlayingCard)playerHand2.CardsInHand()[i - (1 + cardsPlaced)]).CardImage();
                        newButton.BackgroundImageLayout = ImageLayout.Stretch;
                        pnlBackground.Controls.Add(newButton);
                        pnlBackground.Controls.SetChildIndex(newButton, i - cardsPlaced);
                    }
                }
            }
            
        }

        private void DisplayDealerCards()
        {
            int size;
            //Displays all cards in hand
            for (int i = 1; i <= dealerHand.CardsInHand().Count; i++)
            {
                //if this control exists, reposition it
                if (pnlBackground.Controls.ContainsKey("DealerCard" + i))
                {
                    Button newButton = (Button)pnlBackground.Controls[pnlBackground.Controls.IndexOfKey("DealerCard" + i)];
                    newButton.Parent = pnlBackground;
                    newButton.Location = new Point((newButton.Parent.Size.Width / 2) - 35 + (35 * i), (newButton.Parent.Size.Height / 4));
                }
                //if control does not already exist create and position it
                else if (!pnlBackground.Controls.ContainsKey("DealerCard" + i))
                {
                    if (dealerFirstDraw)
                    {
                        Button newButton = new Button();
                        newButton.Name = "DealerCard" + i;
                        newButton.Parent = pnlBackground;
                        newButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                        size = newButton.Parent.Height/8;
                        newButton.Size = new Size(size, (int)(size * 1.5));
                        newButton.Location = new Point((newButton.Parent.Size.Width / 2) - 35 + (35 * i), (newButton.Parent.Size.Height / 4));
                        newButton.BackgroundImage = ((PlayingCard)dealerHand.CardsInHand()[i - 1]).HiddenCardImage();
                        newButton.BackgroundImageLayout = ImageLayout.Stretch;
                        pnlBackground.Controls.Add(newButton);
                        pnlBackground.Controls.SetChildIndex(newButton, dealerHand.CardsInHand().Count - i);
                        dealerFirstDraw = false;
                    }
                    else
                    {
                        Button newButton = new Button();
                        newButton.Name = "DealerCard" + i;
                        newButton.Parent = pnlBackground;
                        newButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                        size = newButton.Parent.Height / 8;
                        newButton.Size = new Size(size, (int)(size * 1.5));
                        newButton.Location = new Point((newButton.Parent.Size.Width / 2) - 35 + (35 * i), (newButton.Parent.Size.Height / 4));
                        newButton.BackgroundImage = ((PlayingCard)dealerHand.CardsInHand()[i - 1]).CardImage();
                        newButton.BackgroundImageLayout = ImageLayout.Stretch;
                        pnlBackground.Controls.Add(newButton);
                        pnlBackground.Controls.SetChildIndex(newButton, dealerHand.CardsInHand().Count - i);
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

        //check for hand greater than 21, returns true if hand busted
        private bool CheckForBust(Hand hand)
        {
            bool bust = false;

            if (GetTotalHandValue(hand) > 21)
            { bust = true; }

            return bust;
        }

        //check for chance for player to buy insurance
        //returns true if player buys insurance
        private bool CheckForInsurance()
        {
            bool insurance = false;
            //get second card in dealer's hand
            PlayingCard card = (PlayingCard)dealerHand.CardsInHand().ToArray()[1];
            if (card.CardValue() == Value.Ace)
            {
                DialogResult result = MessageBox.Show("The dealer has a face up ace. Do you want to buy insurance equal to your bet?", "Insurance", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    insurance = true;
                }
            }

            return insurance;
        }

        private void CheckForSplit (Hand hand)
        {
            // if player has already split 2 times, prevent any more splitting
            if (splits == 1)
            { return;  }

            // Split hand scenario checker
            if (hand.CardsInHand().Count == 2)
            {
                PlayingCard card1 = null;
                int i = 1;
                foreach (PlayingCard card in hand.CardsInHand())
                {
                    if (i == 1)
                    {
                        card1 = card;
                        i++;
                    }
                    else if (card1.CardValue() == card.CardValue())
                    {
                        btnSplit.Visible = true;
                        btnSplit.Enabled = true;
                    }
                }
            } // end of split hand check
       }

        private void Deal()
        {
            //delete all cards shown in player and dealer hands
            DeleteCards();

            stand1 = false;
            stand2 = false;
            stand3 = false; // not used

            activePlayerHand.ClearHand();
            playerHand1.ClearHand();
            playerHand2.ClearHand();
            playerHand3.ClearHand();
            dealerHand.ClearHand();

            // reset split conditions
            splits = 0;

            // reshuffle deck if below 21 cards
            if (deck.CardsLeft() <= 21)
            {
                deck.ClearPack();
                deck.Reshuffle();
            }

            dealerFirstDraw = true;
            activePlayerHand = new Hand();
            dealerHand = new Hand();

            //activePlayerHand.AddCardToHand(deck.DealCardFromPack());
            //activePlayerHand.AddCardToHand(deck.DealCardFromPack());
            PlayingCard card = new PlayingCard(Suit.Clubs, Value.Four);
            activePlayerHand.AddCardToHand(card);
            activePlayerHand.AddCardToHand(card);
            CheckForSplit(activePlayerHand);
            lblPlayerHandValue.Text = GetTotalHandValue(activePlayerHand).ToString();

            dealerHand.AddCardToHand(deck.DealCardFromPack());
            dealerHand.AddCardToHand(deck.DealCardFromPack());
            lblDealerHandValue.Text = GetTotalHandValue(dealerHand).ToString();

            DisplayPlayerCards();
            DisplayDealerCards();

            //Check for initial win conditions
            //player blackjack
            if (CheckForBlackjack(activePlayerHand))
            {
                 totalWins++;
                 ModifyBank((int)(betMoneyValue * 2.5), true, false);
                 MessageBox.Show("You got blackjack! Great job! Here's your money.", "Win!", MessageBoxButtons.OK);
                 totalWins++;
            }
            //check for player insurance
            //Scenarios:
            //1. The player buys insurance, the dealer has blackjack. 
            //Result: The player's bet is taken. The amount the player places up for insurance is payed out 2 to 1. The round ends.
            //2. The player buys insurance, the dealer does not have blackjack.
            //Result: The player's insurance is taken by the dealer, and the round continues with the players original bet.
            else if (CheckForInsurance())
            {
                if (CheckForBlackjack(dealerHand))
                {
                    ModifyBank(betMoneyValue, true, false);
                    MessageBox.Show("I have blackjack! Good call!", "Insurance",MessageBoxButtons.OK);
                }
                else if (!CheckForBlackjack(dealerHand))
                {
                    ModifyBank(betMoneyValue / 2 * -1, false, false);
                    MessageBox.Show("Too bad, I don't have blackjack! I'll take half your bet now.", "Lose Your Insurance!", MessageBoxButtons.OK);
                    btnHit.Enabled = true;
                    btnStand.Enabled = true;
                    betAndSetBtn.Enabled = false;
                }
                
            }
            //check to see if dealer has blackjack if player doesn't have to buy insurance
            //3. The player does not buy insurance, the dealer has blackjack.
            //Result: The player loses the round and loses his bet
            //4. The player does not buy insurance, the dealer does not have blackjack.
            //Result: The round continues as normal.
            else if(CheckForBlackjack(dealerHand))
            {
                //flip dealers card
                ((Button)pnlBackground.Controls["DealerCard1"]).BackgroundImage = ((PlayingCard)dealerHand.CardsInHand()[0]).CardImage();
                //take away money
                ModifyBank(betMoneyValue * -1, true , false);
                MessageBox.Show("I got blackjack! You lose. I'll take your bet now.", "Lose!", MessageBoxButtons.OK); 
            }
            else
            {
                btnSurrender.Enabled = true;
                btnSurrender.Visible = true;

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

        private void DeleteCards()
        {
            //Deletes all cards shown
            int i = 1;
            while(pnlBackground.Controls.ContainsKey("Card" + i))
            {
                pnlBackground.Controls.RemoveByKey("Card" + i);
                i++;
            }
            i = 1;
            while(pnlBackground.Controls.ContainsKey("DealerCard" + i))
            {
                pnlBackground.Controls.RemoveByKey("DealerCard" + i);
                i++;
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
            btnDoubleDown.Enabled = false;
            btnDoubleDown.Visible = false;
            btnSplit.Enabled = false;
            btnSplit.Visible = false;
            btnSurrender.Enabled = false;
            btnSurrender.Visible = false;
            Hit();
        }

        private void Hit()
        {
            activePlayerHand.AddCardToHand(deck.DealCardFromPack());
            lblPlayerHandValue.Text = GetTotalHandValue(activePlayerHand).ToString();
            
            DeleteCards();

            //copy activePlayerHand into proper variable for display
            if (stand2)
            {
                playerHand3.ClearHand();
                foreach (PlayingCard card in activePlayerHand.CardsInHand())
                { playerHand3.AddCardToHand(card); }
            }
            else if (stand1)
            {
                playerHand2.ClearHand();
                foreach (PlayingCard card in activePlayerHand.CardsInHand())
                { playerHand2.AddCardToHand(card); }
            }
            else 
            {
                playerHand1.ClearHand();
                foreach (PlayingCard card in activePlayerHand.CardsInHand())
                { playerHand1.AddCardToHand(card); }
            }

            DisplayPlayerCards();
            DisplayDealerCards();

            //if player busts
            if (CheckForBust(activePlayerHand))
            {
                if (splits == 1)
                {
                    ModifyBank((betMoneyValue / 2) * -1, true, false);
                    MessageBox.Show("You busted!", "Lose!", MessageBoxButtons.OK);
                }
                else
                {
                    ModifyBank(betMoneyValue * -1, true, false);
                    MessageBox.Show("You busted!", "Lose!", MessageBoxButtons.OK);
                }
                MessageBox.Show("You busted! You lose. I'll take your bet now.", "Lose!", MessageBoxButtons.OK); 
            }
            else if(CheckForBlackjack(activePlayerHand))
            {
                DealerHit();
                DeleteCards();
                DisplayDealerCards();
                DisplayPlayerCards();
                //if dealer got to 21, there is a tie
                if (CheckForBlackjack(dealerHand))
                {
                    ModifyBank(betMoneyValue, true, false);
                    MessageBox.Show("We tied!", "Tie!", MessageBoxButtons.OK);
                }
                //if dealer busted or did not get to 21, player wins
                else
                {
                    totalWins++;
                    ModifyBank(betMoneyValue * 2, true, false);
                    MessageBox.Show("You win!", "Win!", MessageBoxButtons.OK);
                    MessageBox.Show("You win! Here's your money.", "Win!", MessageBoxButtons.OK);
                 
               }
            }
           
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            btnDoubleDown.Enabled = false;
            btnDoubleDown.Visible = false;
            btnSplit.Enabled = false;
            btnSplit.Visible = false;
            btnSurrender.Enabled = false;
            btnSurrender.Visible = false;
            Stand();
        }

        private void Stand()
        {
            // once a player stands hold a copy of the hand (this is important for splits)
            if (splits == 1 && !stand1)
            {
                activePlayerHand.ClearHand();
                foreach (PlayingCard card in playerHand2.CardsInHand())
                { activePlayerHand.AddCardToHand(card); }
                CheckForSplit(activePlayerHand);
                stand1 = true;
                return;
            }
            if (splits == 2 && !stand2) // not used
            {
                activePlayerHand.ClearHand();
                foreach (PlayingCard card in playerHand3.CardsInHand())
                { activePlayerHand.AddCardToHand(card); }
                CheckForSplit(activePlayerHand);
                stand2 = true;
                return;
            }
            if (splits == 3 && !stand3)
            {
                foreach (PlayingCard card in activePlayerHand.CardsInHand())
                { playerHand3.AddCardToHand(card); }
                stand3 = true;
            }

            stand1 = true;
            btnHit.Enabled = false;
            //flip dealers card
            ((Button)pnlBackground.Controls["DealerCard1"]).BackgroundImage = ((PlayingCard)dealerHand.CardsInHand()[0]).CardImage();
            //dealer hits until 17
            DealerHit();
            DisplayDealerCards();

            int i = 1; // set loop counter
            double gain = betMoneyValue * 2, loss = betMoneyValue * -1, draw = betMoneyValue;// money values

            if (stand3) // not used
            { i = 3; }
            else if (stand2)
            { 
                i = 2;
                gain /= 2;
                loss /= 2;
                draw = betMoneyValue;
            }


            while (i >= 1)
            {
                //dealer has blackjack
                if (CheckForBlackjack(dealerHand))
                {
                    ModifyBank((int)loss, true, false);
                    MessageBox.Show("You lose.", "Lose!", MessageBoxButtons.OK);
                }
                //dealer busts
                else if (CheckForBust(dealerHand))
                {
                    ModifyBank((int)gain, true, false);
                    MessageBox.Show("I busted! You win!", "Win!", MessageBoxButtons.OK);
                    ModifyBank(betMoneyValue * 2, true, false);
                    MessageBox.Show("I busted! You win! Here's your money.", "Win!", MessageBoxButtons.OK);
                    totalWins++;
                }
                //dealer beats player
                else if(GetTotalHandValue(dealerHand) > GetTotalHandValue(handSelector(i)))
                {
                    ModifyBank((int)loss, true, false);
                    MessageBox.Show("You lose.", "Lose!", MessageBoxButtons.OK);
                }
                //player beats dealer
                else if (GetTotalHandValue(dealerHand) < GetTotalHandValue(handSelector(i)))
                {
                    ModifyBank((int)gain, true, false);
                    MessageBox.Show("You win!", "Win!", MessageBoxButtons.OK);
                    ModifyBank(betMoneyValue * 2, true, false);
                    MessageBox.Show("You win! Here's your money.", "Win!", MessageBoxButtons.OK);
                    totalWins++;
            
                }
                //player and dealer tie
                else if (GetTotalHandValue(dealerHand) == GetTotalHandValue(handSelector(i)))
                {
                    ModifyBank((int)draw, true, false);
                    MessageBox.Show("We tied!", "Tie!", MessageBoxButtons.OK);
                }
                    i--;
            } // while loop
        }
        
        // support func for stand method
        private Hand handSelector(int i)
        {
            if (splits == 0)
            { return activePlayerHand; }
            if (i == 1)
            { return playerHand1; }
            if (i == 2)
            { return playerHand2; }
            if (i == 3)
            { return playerHand3; }

            return null;
        }

        //Double down
        private void btnDoubleDown_Click(object sender, EventArgs e)
        {
            if (splits == 1)
            { 
                BettingMoneyGrabber((betMoneyValue / 2));
            }
            else
            { 
                BettingMoneyGrabber(betMoneyValue);
                btnDoubleDown.Enabled = false;
                btnDoubleDown.Visible = false;
            }
            activePlayerHand.AddCardToHand(deck.DealCardFromPack());
            lblPlayerHandValue.Text = GetTotalHandValue(activePlayerHand).ToString();
            DisplayPlayerCards();
            btnDoubleDown.Enabled = false;
            btnDoubleDown.Visible = false;
            btnSurrender.Enabled = false;
            btnSurrender.Visible = false;
            BettingMoneyGrabber(betMoneyValue);
            activePlayerHand.AddCardToHand(deck.DealCardFromPack());
            lblPlayerHandValue.Text = GetTotalHandValue(activePlayerHand).ToString();
            DisplayPlayerCards();
            //check for blackjack
            if (CheckForBlackjack(activePlayerHand))
            {
                ModifyBank(betMoneyValue * 2, true, false);
                MessageBox.Show("You got blackjack! Great job! Here's your money.", "Win!", MessageBoxButtons.OK);
                totalWins++;
            }
            //check for bust
            if (CheckForBust(activePlayerHand))
            {
                if (splits == 1)
                {
                    ModifyBank((betMoneyValue / 2) * -1, true, false);
                    MessageBox.Show("You busted!", "Lose!", MessageBoxButtons.OK);
                }
                else
                {
                    ModifyBank(betMoneyValue * -1, true, false);
                    MessageBox.Show("You busted!", "Lose!", MessageBoxButtons.OK);
                }
            }
            //otherwise stand
            else
            {
                Stand();
            }
        }

        //Split hand
        private void btnSplit_Click(object sender, EventArgs e)
        {
            PlayingCard card1 = null , card2 = null;
            int i = 1;
            // first split
            if (splits == 0)
            {
                foreach (PlayingCard card in activePlayerHand.CardsInHand())
                {
                    if (i == 1)
                    { card1 = card; }
                    else if (i == 2)
                    { card2 = card; }
                    i++;
                }
                DeleteCards();
                activePlayerHand.ClearHand();

                activePlayerHand.AddCardToHand(card1);
                activePlayerHand.AddCardToHand(deck.DealCardFromPack());
                
                //make sure playerHand1 is holding the cards for display
                foreach (PlayingCard card in activePlayerHand.CardsInHand())
                { playerHand1.AddCardToHand(card); }
                

                playerHand2.AddCardToHand(card2);
                //playerHand2.AddCardToHand(deck.DealCardFromPack());
                PlayingCard card3 = new PlayingCard(Suit.Clubs, Value.Four);
                playerHand2.AddCardToHand(card3);
                splits++;

                playerMoneyValue = playerMoneyValue - betMoneyValue;
                valuePlayerLbl.Text = playerMoneyValue.ToString();
                betMoneyValue *= 2;
                valueBetLbl.Text = betMoneyValue.ToString();

                if (CheckForBlackjack(activePlayerHand))
                {
                    ModifyBank((int)((betMoneyValue / 2) * 2.5), true, false);
                    MessageBox.Show("You got blackjack in your first hand!", "Win!", MessageBoxButtons.OK);
                }
                if (CheckForBlackjack(playerHand2))
                {
                    ModifyBank((int)((betMoneyValue / 2) * 2.5), true, false);
                    MessageBox.Show("You got blackjack in your second hand!", "Win!", MessageBoxButtons.OK);
                }
                //display cards
                DisplayPlayerCards();
                DisplayDealerCards();
            }
            else if (splits == 1) // not used
            {
                foreach (PlayingCard card in activePlayerHand.CardsInHand())
                {
                    if (i == 1)
                    { card1 = card; }
                    else if (i == 2)
                    { card2 = card; }
                    i++;
                }
                DeleteCards();
                activePlayerHand.ClearHand();

                activePlayerHand.AddCardToHand(card1);
                activePlayerHand.AddCardToHand(deck.DealCardFromPack());
                
                playerHand3.AddCardToHand(card2);
                playerHand3.AddCardToHand(deck.DealCardFromPack());
                splits++;

                playerMoneyValue = playerMoneyValue - betMoneyValue;
                valuePlayerLbl.Text = playerMoneyValue.ToString();
                betMoneyValue *= 2;
                valueBetLbl.Text = betMoneyValue.ToString();

                //display cards
                DisplayPlayerCards();
                DisplayDealerCards();
            }

            btnSplit.Enabled = false;
            btnSplit.Visible = false;
            btnSurrender.Enabled = false;
            btnSurrender.Visible = false;
        }

        private void betAndSetBtn_Click(object sender, EventArgs e)
        {
            playerMoneyValue = (int)activePlayer.Bank; // retrieve current player's money

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
                btnDoubleDown.Visible = true;
                btnDoubleDown.Enabled = true;
                Deal();
            }
        }

        private void BettingMoneyGrabber(int amount)
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
     
        //helper function to add and take away from players bank
        //updates labels as well, and ends round
        private void ModifyBank(int change, bool resetBet, bool borrow)
        {
            //update
            totalGames++;

            if (change > gainMostMoneyValue)
            {
                gainMostMoneyValue = change;
            }
            else if (change < lostMostMoneyValue)
            {
                lostMostMoneyValue = change;
            }

            if (change > 0)
            {
                gainTotalMoneyValue += change;
            }
            else  if (change < 0)
            {
                lostTotalMoneyValue += change;
            }
            DatabaseCall.UpdateBank(activePlayer, (int)change, borrow);
            //update variables
            playerMoneyValue = (int)activePlayer.Bank;
            if (resetBet)
            {
                betMoneyValue = 0;
            }
            //update lables
            valueBetLbl.Text = betMoneyValue.ToString();
            valuePlayerLbl.Text = playerMoneyValue.ToString();
            lbltotalWinCount.Text = totalWins.ToString() + "/" + totalGames.ToString();
            lblTotalLost.Text = lostTotalMoneyValue.ToString();
            lblTotalGained.Text = gainTotalMoneyValue.ToString();
            lblMostGained.Text = gainMostMoneyValue.ToString();
            lblMostLost.Text = lostMostMoneyValue.ToString();
           
            //reset buttons for next round
            EndRound();
        }

        //helper function to set up for next round by disabling the proper buttons
        //and enabling the bet button
        private void EndRound()
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            btnSplit.Visible = false;
            btnDoubleDown.Visible = false;
            betAndSetBtn.Enabled = true;
            dealerStand = false;
        }

        private void btnSurrender_Click(object sender, EventArgs e)
        {
            ModifyBank(betMoneyValue / -2, true, false);
            MessageBox.Show("You surrender! You gain half your money back.", "Surrender", MessageBoxButtons.OK);
            btnSurrender.Enabled = false;
            btnSurrender.Visible = false;
        }

    }
}

