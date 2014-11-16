using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cards; // import for card classes

namespace CSC460_BlackJack_Final_Burke_Hammontree_Smith
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BlackjackMainWindow());
        }

    }
}
