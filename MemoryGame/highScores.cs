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
        int score;
        Form game;
        SqlDataAdapter sda;
        DataTable dt = new DataTable();
        SqlCommandBuilder sqlb;
        DataRow row;
        Dictionary<String, int> hsT;

        public highScores(Dictionary<String, int> hst, Form game)
        {
            this.hsT = hst;
            this.game = game;

            
            dt.Columns.Add("Name");
            dt.Columns.Add("Score");

            InitializeComponent();

            
        }

        private void highScoreGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formClosedEvent(object sender, FormClosedEventArgs e)
        {
            
            game.Enabled = true;
        }
        



        private void formLoad(object sender, EventArgs e)
        {
            loadAllplayersBests();

        }



        private void loadAllplayersBests()
        {
            var top5 = hsT.OrderByDescending(pair => pair.Value).Take(5);
            
            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Score");
            foreach (var score in top5)
            {

                
                row = dt.NewRow();
                
                row["Name"] = score.Key;
                row["Score"] = score.Value;
                dt.Rows.Add(row);
               
            }
            highScoreGrid.DataSource = dt;

        }
    }
}
