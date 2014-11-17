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

        public BlackjackMainWindow()
        {
            InitializeComponent();
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

            dealerHand.AddCardToHand(deck.DealCardFromPack());
            dealerHand.AddCardToHand(deck.DealCardFromPack());
            
            DisplayPlayerCards();
            DisplayDealerCards();
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

            DisplayPlayerCards();
        }

        //intended to add everything up to make it easier to check for win conditions
        private int GetTotalHandValue(Hand hand)
        {
            int value = 0;

            foreach (PlayingCard card in hand.CardsInHand())
            {
               
            }

            return value;
        }
    }


}
