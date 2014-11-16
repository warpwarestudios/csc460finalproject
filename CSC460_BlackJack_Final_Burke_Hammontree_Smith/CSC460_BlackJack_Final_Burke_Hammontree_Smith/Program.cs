using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cards; // import for card classes

namespace CSC460_BlackJack_Final_Burke_Hammontree_Smith
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInWindow());

            Hand playerHand = new Hand();
            Hand dealerHand = new Hand();
            Pack playingDeck = new Pack();
            int playerScore = 0, DealerScore = 0;
        }
    }
}
