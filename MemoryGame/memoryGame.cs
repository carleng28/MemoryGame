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
    /*
     Singleton pattern for creating only one instance of the game
         */
    public partial class MemoryGame : Form
    {

        private static MemoryGame instance;
        
        public UserSelect userMenu;
        public String username;
        public int score;
        
        //DATA STRUCTURE 2 OF 5
        int[] boardGame = new int[16];
        int playNumber = 0;
        //DATA STRUCTURE 3 OF 5
        List<int> pairPlay = new List<int>();
        //DATA STRUCTURE 4 OF 5
        Dictionary<String, int> hsTable = new Dictionary<String, int>();
        int points = 0;
        int chain = 0;
        int correctPlays = 0;
        
        SqlConnection con;
        SqlDataAdapter sda;
        DataTable dt;

        IHints hint = new AdapterHints();
        


        private MemoryGame(String username, UserSelect u)
        {
            this.userMenu = u;
            u.Hide();
            this.username = username;
            this.score = 0;
            pairPlay.Add(0);
            pairPlay.Add(1);
            this.hsTable.Add(username, 0);
            InitializeComponent();

        }

        public static MemoryGame getSingleton(String username, UserSelect u)
        {

            if (instance == null)
            {

                instance = new MemoryGame(username, u);

            }
            else {

                if (instance.hsTable.ContainsKey(username)) 
                {
                    instance.hsTable[username] = 0;
                } else {

                    instance.hsTable.Add(username, 0);
                }
                
                instance.username = username;
                instance.score = 0;
                instance.lbl_score.Text = "0";
                instance.startOver(null, null);
            }

            return instance;
            
        }

   
        private void discoverCardEvent(object sender, EventArgs e)
        {
            if (sender == boxIcon1)
            {

                boxIcon1.Image = gameImageList.Images[boardGame[0]];
                pairPlay[playNumber] = 0;


            }
            else if (sender == boxIcon2)
            {

                boxIcon2.Image = gameImageList.Images[boardGame[1]];
                pairPlay[playNumber] = 1;
            }
            else if (sender == boxIcon3)
            {

                boxIcon3.Image = gameImageList.Images[boardGame[2]];
                pairPlay[playNumber] = 2;
            }
            else if (sender == boxIcon4)
            {

                boxIcon4.Image = gameImageList.Images[boardGame[3]];
                pairPlay[playNumber] = 3;
            }
            else if (sender == boxIcon5)
            {

                boxIcon5.Image = gameImageList.Images[boardGame[4]];
                pairPlay[playNumber] = 4;
            }
            else if (sender == boxIcon6)
            {

                boxIcon6.Image = gameImageList.Images[boardGame[5]];
                pairPlay[playNumber] = 5;
            }
            else if (sender == boxIcon7)
            {

                boxIcon7.Image = gameImageList.Images[boardGame[6]];
                pairPlay[playNumber] = 6;
            }
            else if (sender == boxIcon8)
            {

                boxIcon8.Image = gameImageList.Images[boardGame[7]];
                pairPlay[playNumber] = 7;
            }
            if (sender == boxIcon9)
            {

                boxIcon9.Image = gameImageList.Images[boardGame[8]];
                pairPlay[playNumber] = 8;

            }
            else if (sender == boxIcon10)
            {

                boxIcon10.Image = gameImageList.Images[boardGame[9]];
                pairPlay[playNumber] = 9;
            }
            else if (sender == boxIcon11)
            {

                boxIcon11.Image = gameImageList.Images[boardGame[10]];
                pairPlay[playNumber] = 10;
            }
            else if (sender == boxIcon12)
            {

                boxIcon12.Image = gameImageList.Images[boardGame[11]];
                pairPlay[playNumber] = 11;
            }
            else if (sender == boxIcon13)
            {

                boxIcon13.Image = gameImageList.Images[boardGame[12]];
                pairPlay[playNumber] = 12;
            }
            else if (sender == boxIcon14)
            {

                boxIcon14.Image = gameImageList.Images[boardGame[13]];
                pairPlay[playNumber] = 13;
            }
            else if (sender == boxIcon15)
            {

                boxIcon15.Image = gameImageList.Images[boardGame[14]];
                pairPlay[playNumber] = 14;
            }
            else if (sender == boxIcon16)
            {

                boxIcon16.Image = gameImageList.Images[boardGame[15]];
                pairPlay[playNumber] = 15;
            }
            playNumber++;
            if (playNumber == 2)
            {

                checkPairs(pairPlay);
            }
        }

        private void checkPairs(List<int> pairPlay)
        {


            if (boardGame[pairPlay[0]] != boardGame[pairPlay[1]])
            {

                MessageBox.Show("Not a match");
                coverCard(pairPlay[0]);
                coverCard(pairPlay[1]);
                points = points - 20;
                if (points < 0)
                {
                    points = 0;
                }
                chain = 0;
            }
            else
            {

                chain++;
                points = points + 100 * chain;
                correctPlays++;
            }
            playNumber = 0;
            lbl_score.Text = Convert.ToString(points);
            checkEndGame();
        }

        private void checkEndGame()
        {

            if (correctPlays == 8)
            {

                MessageBox.Show("Game over!\nScore: " + points);
                //insertScore();
                showHighScores();

            }
            

        }

        private void insertScore() {

            DateTime dt = DateTime.UtcNow.Date;
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=memoryGame;Integrated Security=True");
            con.Open();
            sda = new SqlDataAdapter("Insert into player_score values('" +
                this.username.Trim() + "', "+this.points+", '" + dt + "')", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();

            

        }

        private void coverCard(int position)
        {


            if (position == 0)
            {

                boxIcon1.Image = gameImageList.Images[0];
            }
            else if (position == 1)
            {

                boxIcon2.Image = gameImageList.Images[0];
            }
            if (position == 2)
            {

                boxIcon3.Image = gameImageList.Images[0];
            }
            else if (position == 3)
            {

                boxIcon4.Image = gameImageList.Images[0];
            }
            if (position == 4)
            {

                boxIcon5.Image = gameImageList.Images[0];
            }
            else if (position == 5)
            {

                boxIcon6.Image = gameImageList.Images[0];
            }
            if (position == 6)
            {

                boxIcon7.Image = gameImageList.Images[0];
            }
            else if (position == 7)
            {

                boxIcon8.Image = gameImageList.Images[0];
            }
            if (position == 8)
            {

                boxIcon9.Image = gameImageList.Images[0];
            }
            else if (position == 9)
            {

                boxIcon10.Image = gameImageList.Images[0];
            }
            if (position == 10)
            {

                boxIcon11.Image = gameImageList.Images[0];
            }
            else if (position == 11)
            {

                boxIcon12.Image = gameImageList.Images[0];
            }
            if (position == 12)
            {

                boxIcon13.Image = gameImageList.Images[0];
            }
            else if (position == 13)
            {

                boxIcon14.Image = gameImageList.Images[0];
            }
            if (position == 14)
            {

                boxIcon15.Image = gameImageList.Images[0];
            }
            else if (position == 15)
            {

                boxIcon16.Image = gameImageList.Images[0];
            }


        }

        private void coverCards()
        {
            boxIcon1.Image = gameImageList.Images[0];
            boxIcon2.Image = gameImageList.Images[0];
            boxIcon3.Image = gameImageList.Images[0];
            boxIcon4.Image = gameImageList.Images[0];
            boxIcon5.Image = gameImageList.Images[0];
            boxIcon6.Image = gameImageList.Images[0];
            boxIcon7.Image = gameImageList.Images[0];
            boxIcon8.Image = gameImageList.Images[0];
            boxIcon9.Image = gameImageList.Images[0];
            boxIcon10.Image = gameImageList.Images[0];
            boxIcon11.Image = gameImageList.Images[0];
            boxIcon12.Image = gameImageList.Images[0];
            boxIcon13.Image = gameImageList.Images[0];
            boxIcon14.Image = gameImageList.Images[0];
            boxIcon15.Image = gameImageList.Images[0];
            boxIcon16.Image = gameImageList.Images[0];

        }


        private void assignRandomPics()
        {

            Random r = new Random();
            int aux = 1;


            foreach (int i in Enumerable.Range(0, 16).OrderBy(x => r.Next()))
            {
                if (aux > 8)
                {
                    aux = 1;
                }

                boardGame[i] = aux;
                aux++;


            }

            


        }

        private void assignUser() {

            lbl_user.Text = username;
            lbl_user.Visible = true;
            //lbl_score.Text = Convert.ToString(points);
            lbl_score.Visible = true;


        }

        private void loadGame(object sender, EventArgs e)
        {
            assignUser();
            coverCards();
            assignRandomPics();
        }

        private void startOverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startOver(sender, e);
            lbl_score.Text = "0";
        }

        private void startOver(object sender, EventArgs e)
        {

            loadGame(sender, e);
            //boardGame = new int[16];
            playNumber = 0;
            //pairPlay = new int[2];
            points = 0;
            chain = 0;
            correctPlays = 0;
            //lbl_score.Text = "0";

        }

        private void uncoverAllToolStripMenuItem_Click(object sender, EventArgs e)
        {


            boxIcon1.Image = gameImageList.Images[boardGame[0]];
            pairPlay[playNumber] = 0;



            boxIcon2.Image = gameImageList.Images[boardGame[1]];
            pairPlay[playNumber] = 1;


            boxIcon3.Image = gameImageList.Images[boardGame[2]];
            pairPlay[playNumber] = 2;


            boxIcon4.Image = gameImageList.Images[boardGame[3]];
            pairPlay[playNumber] = 3;


            boxIcon5.Image = gameImageList.Images[boardGame[4]];
            pairPlay[playNumber] = 4;


            boxIcon6.Image = gameImageList.Images[boardGame[5]];
            pairPlay[playNumber] = 5;


            boxIcon7.Image = gameImageList.Images[boardGame[6]];
            pairPlay[playNumber] = 6;


            boxIcon8.Image = gameImageList.Images[boardGame[7]];
            pairPlay[playNumber] = 7;


            boxIcon9.Image = gameImageList.Images[boardGame[8]];
            pairPlay[playNumber] = 8;



            boxIcon10.Image = gameImageList.Images[boardGame[9]];
            pairPlay[playNumber] = 9;


            boxIcon11.Image = gameImageList.Images[boardGame[10]];
            pairPlay[playNumber] = 10;


            boxIcon12.Image = gameImageList.Images[boardGame[11]];
            pairPlay[playNumber] = 11;


            boxIcon13.Image = gameImageList.Images[boardGame[12]];
            pairPlay[playNumber] = 12;


            boxIcon14.Image = gameImageList.Images[boardGame[13]];
            pairPlay[playNumber] = 13;


            boxIcon15.Image = gameImageList.Images[boardGame[14]];
            pairPlay[playNumber] = 14;


            boxIcon16.Image = gameImageList.Images[boardGame[15]];
            pairPlay[playNumber] = 15;

            MessageBox.Show("GAME OVER!\n Please start over");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to " +
                "close the application?", "close?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
               
                this.Hide();
                this.userMenu.Show();
            }
        }

        private void changePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to change player?", 
                "change player?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                this.userMenu.Show();
            }
        }

        private void formClosedEvent(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkHighScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showHighScores();
        }

        private void showHighScores() {

            if (hsTable[username] < this.points) {

                hsTable[username] = this.points;
                
            }
            highScores hs = new highScores(hsTable, this);
            this.Enabled = false;
            hs.Show();


        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\tMemory Game Instructions\n\n" +
                "   The goal of the game is to get all the matching pairs with the less amount of errors," +
                " thus, testing your memory. Can you beat yours and other players records?\n\n" +
                "   The player clicks two cards and if the two are a matching pair he will get" +
                "100 points. For succesive pair matches, the player will be awarded with bonus points." +
                " Each error will cost 20 points. ", "Instructions", MessageBoxButtons.OK,MessageBoxIcon.Information);

 
        }

        private void displayHintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hint.GetHints();
        }
    }
}
