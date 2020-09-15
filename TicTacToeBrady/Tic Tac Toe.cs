using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Tic Tac Toe
* Author      : Kabrina Brady
* Created     : 10/8/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : Player clicks New Game button and computer randomly fills tic tac toe board and displays who won.
*               Input:  Button clicks
*               Output: Filled array
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace TicTacToeBrady
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form
        }

        private void FillArray(int[] iArray)
        {

        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            //Makes all tiles display X
            lblTile1.Text = "X";
            lblTile2.Text = "X";
            lblTile3.Text = "X";
            lblTile4.Text = "X";
            lblTile5.Text = "X";
            lblTile6.Text = "X";
            lblTile7.Text = "X";
            lblTile8.Text = "X";
            lblTile9.Text = "X";

            Random rand = new Random(); //creates new random object

            //Every tile needs a separate variable so that all tiles won't be assigned the same letter
            string randomValueString; //string to hold an X or O
            string randomValueString2; //string to hold an X or O
            string randomValueString3; //string to hold an X or O
            string randomValueString4; //string to hold an X or O
            string randomValueString5; //string to hold an X or O
            string randomValueString6; //string to hold an X or O
            string randomValueString7; //string to hold an X or O
            string randomValueString8; //string to hold an X or O
            string randomValueString9; //string to hold an X or O

            int ROWS = 3;
            int COLS = 3;
            int[,] tilesArray = new int[ROWS, COLS]; //parallel array
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    tilesArray[row, col] = rand.Next(2); //parallel array now filled with random values 
                }
            }
            //Fills the GUI side of the program with Xs and Os
            if (tilesArray[0, 0] == 0)
            {
                randomValueString = "O";
            }
            else
            {
                randomValueString = "X";
            }

            if (tilesArray[0, 1] == 0)
            {
                randomValueString2 = "O";
            }
            else
            {
                randomValueString2 = "X";
            }

            if (tilesArray[0, 2] == 0)
            {
                randomValueString3 = "O";
            }
            else
            {
                randomValueString3 = "X";
            }

            if (tilesArray[1, 0] == 0)
            {
                randomValueString4 = "O";
            }
            else
            {
                randomValueString4 = "X";
            }

            if (tilesArray[1, 1] == 0)
            {
                randomValueString5 = "O";
            }
            else
            {
                randomValueString5 = "X";
            }

            if (tilesArray[1, 2] == 0)
            {
                randomValueString6 = "O";
            }
            else
            {
                randomValueString6 = "X";
            }

            if (tilesArray[2, 0] == 0)
            {
                randomValueString7 = "O";
            }
            else
            {
                randomValueString7 = "X";
            }

            if (tilesArray[2, 1] == 0)
            {
                randomValueString8 = "O";
            }
            else
            {
                randomValueString8 = "X";
            }

            if (tilesArray[2, 2] == 0)
            {
                randomValueString9 = "O";
            }
            else
            {
                randomValueString9 = "X";
            }
            //assigns the values of the variables to the labels' text properties
            lblTile1.Text = randomValueString;
            lblTile2.Text = randomValueString2;
            lblTile3.Text = randomValueString3;
            lblTile4.Text = randomValueString4;
            lblTile5.Text = randomValueString5;
            lblTile6.Text = randomValueString6;
            lblTile7.Text = randomValueString7;
            lblTile8.Text = randomValueString8;
            lblTile9.Text = randomValueString9;

            //Checks arrangement to see who won

            if (lblTile1.Text == "O" && lblTile2.Text == "O" && lblTile3.Text == "O"
                || lblTile4.Text == "O" && lblTile5.Text == "O" && lblTile6.Text == "O"
                || lblTile7.Text == "O" && lblTile8.Text == "O" && lblTile9.Text == "O"
                || lblTile1.Text == "O" && lblTile4.Text == "O" && lblTile7.Text == "O"
                || lblTile2.Text == "O" && lblTile5.Text == "O" && lblTile8.Text == "O"
                || lblTile3.Text == "O" && lblTile6.Text == "O" && lblTile9.Text == "O"
                || lblTile1.Text == "O" && lblTile5.Text == "O" && lblTile9.Text == "O"
                || lblTile3.Text == "O" && lblTile5.Text == "O" && lblTile7.Text == "O")
            {
                lblWinnerWinnerChickenDinner.Text = "Player O won!";

                if (lblTile1.Text == "X" && lblTile2.Text == "X" && lblTile3.Text == "X"
                || lblTile4.Text == "X" && lblTile5.Text == "X" && lblTile6.Text == "X"
                || lblTile7.Text == "X" && lblTile8.Text == "X" && lblTile9.Text == "X"
                || lblTile1.Text == "X" && lblTile4.Text == "X" && lblTile7.Text == "X"
                || lblTile2.Text == "X" && lblTile5.Text == "X" && lblTile8.Text == "X"
                || lblTile3.Text == "X" && lblTile6.Text == "X" && lblTile9.Text == "X"
                || lblTile1.Text == "X" && lblTile5.Text == "X" && lblTile9.Text == "X"
                || lblTile3.Text == "X" && lblTile5.Text == "X" && lblTile7.Text == "X")
                {
                    lblWinnerWinnerChickenDinner.Text = "Player X won!";
                }
            }
            else if ((lblTile1.Text == "X" && lblTile2.Text == "X" && lblTile3.Text == "X" && lblTile4.Text == "O" && lblTile5.Text == "O" && lblTile6.Text == "O") 
                || (lblTile1.Text == "O" && lblTile2.Text == "O" && lblTile3.Text == "O" && lblTile4.Text == "X" && lblTile5.Text == "X" && lblTile6.Text == "X")
                || (lblTile4.Text == "O" && lblTile5.Text == "O" && lblTile6.Text == "O" && lblTile7.Text == "X" && lblTile8.Text == "X" && lblTile9.Text == "X")
                || (lblTile4.Text == "X" && lblTile5.Text == "X" && lblTile6.Text == "X" && lblTile7.Text == "O" && lblTile8.Text == "O" && lblTile9.Text == "O")
                || (lblTile1.Text == "X" && lblTile4.Text == "X" && lblTile7.Text == "X" && lblTile2.Text == "O" && lblTile5.Text == "O" && lblTile8.Text == "O")
                || (lblTile1.Text == "O" && lblTile4.Text == "O" && lblTile7.Text == "O" && lblTile2.Text == "X" && lblTile5.Text == "X" && lblTile8.Text == "X")
                || (lblTile2.Text == "X" && lblTile5.Text == "X" && lblTile8.Text == "X" && lblTile3.Text == "O" && lblTile6.Text == "O" && lblTile9.Text == "O")
                || (lblTile2.Text == "O" && lblTile5.Text == "O" && lblTile8.Text == "O" && lblTile3.Text == "X" && lblTile6.Text == "X" && lblTile9.Text == "X")
                )
            {
                lblWinnerWinnerChickenDinner.Text = "It's a tie!";
            }
            else
            {
                lblWinnerWinnerChickenDinner.Text = "No one won. Try again.";
            }
        }
    }
}
