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
            this.playerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Test Insertion
            System.Data.SqlClient.SqlConnection connect =
            new System.Data.SqlClient.SqlConnection("Data Source=|DataDirectory|\\Database.sdf");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT Player (Username, Password, Bank, Borrowed) VALUES ('Ryan', 'fancypants', $100, '$0)";
            cmd.Connection = connect;

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            // End Test Insertion
        }
    }
}
