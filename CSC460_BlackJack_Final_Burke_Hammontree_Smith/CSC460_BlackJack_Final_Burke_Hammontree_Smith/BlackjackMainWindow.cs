﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
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

            // Database Insertion
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
