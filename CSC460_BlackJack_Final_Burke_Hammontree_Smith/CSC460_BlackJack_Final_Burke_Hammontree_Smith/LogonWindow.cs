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
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            // find player from log in info
            Player selectedPlayer = DatabaseCall.SelectPlayer(tboxUsername.Text, tboxPassword.Text);
            // if invalid player notify user of such
            if (selectedPlayer == null)
            { MessageBox.Show("Invalid username or password combination."); }
            else // else, login is valid, close window and proceed back to main game window
            { this.Close(); }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
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
    }
}
