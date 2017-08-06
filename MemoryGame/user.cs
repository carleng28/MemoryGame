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

namespace MemoryGame
{
    public partial class user : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder sqlb;
        public user()
        {
            InitializeComponent();
        }

        private void btn_new_start_Click(object sender, EventArgs e)
        {
            if (txt_user_name.Text.Equals(""))
            {

                MessageBox.Show("Please type a user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                DateTime dt = DateTime.UtcNow.Date;
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=memoryGame;Integrated Security=True");
                con.Open();
                sda = new SqlDataAdapter("Insert into player values('" + 
                    txt_user_name.Text.Trim() +"')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                memoryForm form = new memoryForm(txt_user_name.Text.Trim());
                form.Show();
                this.Hide();
            }
        }

        private void userOnLoadEvent(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=memoryGame;Integrated Security=True");
            con.Open();
            sda = new SqlDataAdapter("Select name from player", con);
            dt = new DataTable();
            fillComboBox(sda, dt, cb_select_player);
        }

        private void fillComboBox(SqlDataAdapter sda, DataTable dt, ComboBox cb)
        {

            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    cb.Items.Insert(i, dt.Rows[i].ItemArray[j]);
                }

            }

        }

        private void btn_reg_player_start_Click(object sender, EventArgs e)
        {
            if (cb_select_player.Text.Equals(""))
            {

                MessageBox.Show("Please select a user ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                memoryForm form = new memoryForm(cb_select_player.Text.Trim());
                form.Show();
                this.Hide();
            }
        }

        private void closeEvent(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
