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
    public partial class LogInWindow : Form
    {

        // Variables
        Player selectedPlayer;

        public LogInWindow()
        {
            InitializeComponent();
            InitializePasswordBox();
        }

        private void InitializePasswordBox()
        {
            // characters in password box as turned into asterisks
            tboxPassword.PasswordChar = '*';
            // limit number of character for a password
            tboxPassword.MaxLength = 32;
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            // find player from log in info
            selectedPlayer = DatabaseCall.SelectPlayer(tboxUsername.Text, tboxPassword.Text);
            // if invalid player notify user of such
            if (selectedPlayer == null)
            { MessageBox.Show("Invalid username or password combination."); }
            else // else, login is valid, close window and proceed back to main game window
            { this.Close(); }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tboxUsername.Text.Equals(""))
            { 
                MessageBox.Show("Invalid username entry. Must contain at least 1 character.");
                return;
            }

            try 
            { // try creating player using provided info
                DatabaseCall.CreatePlayer(tboxUsername.Text, tboxPassword.Text);
                // if player was created and can be properly queried, creation was successful
                if (DatabaseCall.SelectPlayer(tboxUsername.Text, tboxPassword.Text) != null)
                { MessageBox.Show("New account succesfully registered. You may now try logging in."); }
            }
            catch (Exception ex) // if creation threw an error, the most likely culprit is the account
            {// already exists, currently displaying the error for our debugging purposes
                MessageBox.Show("Error saving account or account already exists.\n" 
                    + ex.Message + "\n" + ex.InnerException);
            }
        }

        private void LogInWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (selectedPlayer == null)
            { BlackjackMainWindow.activePlayer = null; }
            else
            { BlackjackMainWindow.activePlayer = selectedPlayer; }
        }

    }
}
