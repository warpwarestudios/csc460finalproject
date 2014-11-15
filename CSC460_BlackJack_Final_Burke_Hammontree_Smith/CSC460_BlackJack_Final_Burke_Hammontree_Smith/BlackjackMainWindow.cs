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

        // create a new player for the database
        private static void CreatePlayer(String name, String password)
        {
            // primary key id value
            int id = 1;

            // id set sequence
            using (var playerList = new DatabaseEntities())
            {
                // Query for all players  
                var players = from player in playerList.Players
                              select player;
                // Go through all players in db
                foreach (Player item in players)
                {   // set the new id value to 1 + the highest current id in use
                    if (item.id > id)
                    {
                        id += 1;
                    }
                }
            }

            var db = new DatabaseEntities();
            Player newPlayer = new Player();

            // create player
            newPlayer.id = id;
            newPlayer.Username = name;
            newPlayer.Password = password;
            newPlayer.Bank = 1000;
            db.AddToPlayers(newPlayer);

            db.SaveChanges();
        }

        // Select player based on name and password
        private static Player SelectPlayer(String name, String password)
        {
            using (var playerList = new DatabaseEntities())
            {
                // Query for selected player  
                Player selectedPlayer = (from player in playerList.Players
                                  where ((player.Username == name) && (player.Password == password))
                                  select player).FirstOrDefault<Player>();
                // return player
                return selectedPlayer;
            }
        }

        // update bank amount based on current selected player 
        // and entered values for bank amount change and if borrowing is invoked
        private static void UpdateBank(Player selectPlayer, decimal change, bool borrow)
        {
            // database connect
            var db = new DatabaseEntities();

            // update bank value
            selectPlayer.Bank += change;

            // update if borrowing
            if (borrow)
            {
                selectPlayer.Bank += 1000;
                selectPlayer.Borrow += 1000;
            }
            // save database changes
            db.SaveChanges();

            // note: the database saving part may be unneccesary
        }

        private void BlackjackMainWindow_Load(object sender, EventArgs e)
        {

        }



    }


}
