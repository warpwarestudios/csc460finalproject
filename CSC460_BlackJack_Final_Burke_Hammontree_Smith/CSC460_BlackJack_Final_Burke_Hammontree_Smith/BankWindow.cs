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
    public partial class BankWindow : Form
    {
        public int amountBorrow;

        public BankWindow()
        {
            InitializeComponent();
        }

        private void okBankBtn_Click(object sender, EventArgs e)
        {
            try
            {
                amountBorrow = int.Parse(valueBorrowBank.Text);
                Close();
            }
            catch (Exception notInt)
            {
                MessageBox.Show("Invalid Input, Try Again");
                valueBorrowBank.Clear();
            }
        }
    }
}
