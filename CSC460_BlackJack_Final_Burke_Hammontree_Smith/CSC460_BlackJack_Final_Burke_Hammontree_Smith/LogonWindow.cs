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
            Player selectedPlayer = DatabaseCall.SelectPlayer(tboxUsername.Text, tboxPassword.Text);
            if (selectedPlayer == null)
            { MessageBox.Show("Invalid username or password combination."); }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DatabaseCall.CreatePlayer(tboxUsername.Text, tboxPassword.Text);
            if (DatabaseCall.SelectPlayer(tboxUsername.Text, tboxPassword.Text) != null)
            { MessageBox.Show("New account succesfully registered. You may now try logging in."); }
        }
    }
}
