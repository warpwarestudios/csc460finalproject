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

        private void BlackjackMainWindow_Load(object sender, EventArgs e)
        {

        }



    }


}
