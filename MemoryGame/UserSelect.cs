using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace MemoryGame
{
    public partial class UserSelect : Form
    {
        //DATA STRUCTURE 1 OF 5
        ArrayList users = new ArrayList();

        public UserSelect()
        {
            fillUsersList();
            InitializeComponent();
        }

        private void btn_new_start_Click(object sender, EventArgs e)
        {
            if (txt_user_name.Text.Equals(""))
            {

                MessageBox.Show("Please type a user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                users.Add(txt_user_name.Text.Trim());
                fillComboBox(users, cb_select_player);
                MemoryGame.getSingleton(cb_select_player.Text.Trim(), this).Show();
                
                this.Hide();
            }
        }

        private void userOnLoadEvent(object sender, EventArgs e)
        {
            
            fillComboBox(users, cb_select_player);
        }

        private void fillComboBox(ArrayList users, ComboBox cb)
        {

            cb.Items.Clear();
            for (int j = 0; j < users.Count; j++)
            {
                cb.Items.Insert(j, users[j]);
            }

        }

        private void fillUsersList() {

            this.users.Add("Carlos");
            this.users.Add("Sadanand");
            this.users.Add("Erika");
            this.users.Add("Cintia");
            this.users.Add("Cesar");

        }

        private void btn_reg_player_start_Click(object sender, EventArgs e)
        {
            if (cb_select_player.Text.Equals(""))
            {

                MessageBox.Show("Please select a user ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //MemoryGame form = MemoryGame(cb_select_player.Text.Trim(), this);
                MemoryGame.getSingleton(cb_select_player.Text.Trim(), this).Show();
                this.Hide();
            }
        }

        private void closeEvent(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
