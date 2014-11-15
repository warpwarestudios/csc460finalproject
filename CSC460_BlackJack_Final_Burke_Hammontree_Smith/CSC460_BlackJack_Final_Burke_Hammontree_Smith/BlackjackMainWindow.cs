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
        public BlackjackMainWindow()
        {
            InitializeComponent();
        }

        private void playerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        int id = 1;

        private void button1_Click(object sender, EventArgs e)
        {

            // Test Insertion
            var db = new DatabaseEntities();
            Player newPlayer = new Player();

            // create player
            newPlayer.id = id;
            newPlayer.Username = "Ryan";
            newPlayer.Password = "secret";
            newPlayer.Bank = 1000;
            db.AddToPlayers(newPlayer);

            db.SaveChanges();
            // End Test Insertion
        }
    }
}
