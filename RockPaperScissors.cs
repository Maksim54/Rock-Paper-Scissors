using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class RockPaperScissors : Form
    {
        public RockPaperScissors()
        {
            InitializeComponent();
            timer1.Enabled = true;
            playerChoice = "none";
        }

        //declaring the variables for this game

        public int rounds = 3; // 3 rounds per game
        public int timePerRound = 6; // 5 seconds per rounds
        //enemy choice options stored inside an array for easy access
        string[] AIchoice = { "rock", "paper", "scissor", "rock", "scissor", "paper" };
        public int randomNumber;
        string command;
        Random rnd = new Random();
        string playerChoice;
        int playerWins = 0;
        int AIwins = 0;

        // end of declaring variables

        //---------------------------------------------------------------\\
             private void pictureBox2_Click(object sender, EventArgs e) //||
             {                                                          //||
                                                                        //||
             }                                                          //||
                                                                        //||
             private void button4_Click(object sender, EventArgs e)     //||
             {                                                          //||
                helpScreen help = new helpScreen();                      //||
                help.Show();                                            //||
             }                                                          //||
                                                                        //||
             private void label6_Click(object sender, EventArgs e)      //||
             {                                                          //||
                                                                        //||
             }                                                          //||
        //---------------------------------------------------------------//

    }
}