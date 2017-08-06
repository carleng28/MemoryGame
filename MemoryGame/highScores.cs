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
    public partial class highScores : Form
    {
        String username;
        Form game;
        SqlConnection con;
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder sqlb;
        public highScores(String username, Form game)
        {
            this.username = username;
            this.game = game;

            InitializeComponent();

            cb_score_filter.SelectedItem = cb_score_filter.Items[0];
        }

        private void highScoreGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formClosedEvent(object sender, FormClosedEventArgs e)
        {
            
            game.Enabled = true;
        }
        

        private void cb_score_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_score_filter.Text.Equals("All players"))
            {


                con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=memoryGame;Integrated Security=True");
                con.Open();
                sda = new SqlDataAdapter("select top 10 name, max(score) high_score, date_entry"+ 
                    " from player_score" +
                    " group by name, date_entry" +
                    " order by max(score) desc", con);
                dt = new DataTable();
                sda.Fill(dt);
                highScoreGrid.DataSource = dt;
                con.Close();
            }
            else {

                loadPersonalBests();
            }

        }

        private void formLoad(object sender, EventArgs e)
        {
            loadPersonalBests();

        }

        private void loadPersonalBests() {

            con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=memoryGame;Integrated Security=True");
            con.Open();
            sda = new SqlDataAdapter("select top 10 * from player_score where name = '" + username + "'" +
                " order by score desc", con);
            dt = new DataTable();
            sda.Fill(dt);
            highScoreGrid.DataSource = dt;
            con.Close();
        }
    }
}
