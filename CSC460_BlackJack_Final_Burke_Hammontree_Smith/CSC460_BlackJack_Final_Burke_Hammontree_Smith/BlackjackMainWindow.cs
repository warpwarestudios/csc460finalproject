using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cards;

namespace CSC460_BlackJack_Final_Burke_Hammontree_Smith
{
    public partial class BlackjackMainWindow : Form
    {
        // Variables
        public static Player activePlayer;

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

            //Console.WriteLine();
        }




    }


}
