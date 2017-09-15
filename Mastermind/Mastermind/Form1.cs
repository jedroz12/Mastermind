using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class Form1 : Form
    {
        //numbers for colours, will be generated

        /*
        Red     =   1
        Blue    =   2
        Yellow  =   3
        Purple  =   4
        Green   =   5
        Pink    =   6
        */

        //array for holding current boardstate

        //boardstate at start (zeros are actually null panels, but this helps for visualization)
        
        /*
        0 0 0 0
        0 0 0 0
        0 0 0 0
        0 0 0 0
        0 0 0 0
        0 0 0 0
        0 0 0 0
        0 0 0 0
        0 0 0 0
        0 0 0 0
        */

        Panel[,] BoardState = new Panel[10, 4];

        //colours for panels to show user guesses
        Color Red = Color.FromArgb(255,0,0);
        Color Blue = Color.FromArgb(0, 0, 153);
        Color Yellow = Color.FromArgb(255, 255, 0);
        Color Purple = Color.FromArgb(102, 0, 102);
        Color Green = Color.FromArgb(0, 153, 0);
        Color Pink = Color.FromArgb(255, 0, 127);

        //for the side of the board, also to set blank tiles
        Color Black = Color.FromArgb(0, 0, 0);
        Color White = Color.FromArgb(255, 255, 255);
        Color Grey = Color.FromArgb(96, 96, 96);

        //array for answer, will be randomly generated on game start
        string[] solution = new string[4];
        Panel[] AnswerSquares = new Panel[4];
        Panel[] SideAnswerSquares = new Panel[40];

        //array for user guess
        string[] guess = new string[4];

        //create new random object
        Random random = new Random();

        //set turn to 0, used for determining what panels to change on the board; should go up to turn 9 for usage in array indexing
        public int CurrentTurn = 0;

        void SetArrays()
        {
            SideAnswerSquares[0] = SideAnswerSquare1;
            SideAnswerSquares[1] = SideAnswerSquare2;

            SideAnswerSquares[2] = SideAnswerSquare3;
            SideAnswerSquares[3] = SideAnswerSquare4;

            SideAnswerSquares[4] = SideAnswerSquare5;
            SideAnswerSquares[5] = SideAnswerSquare6;

            SideAnswerSquares[6] = SideAnswerSquare7;
            SideAnswerSquares[7] = SideAnswerSquare8;

            SideAnswerSquares[8] = SideAnswerSquare9;
            SideAnswerSquares[9] = SideAnswerSquare10;

            SideAnswerSquares[10] = SideAnswerSquare11;
            SideAnswerSquares[11] = SideAnswerSquare12;

            SideAnswerSquares[12] = SideAnswerSquare13;
            SideAnswerSquares[13] = SideAnswerSquare14;

            SideAnswerSquares[14] = SideAnswerSquare15;
            SideAnswerSquares[15] = SideAnswerSquare16;

            SideAnswerSquares[16] = SideAnswerSquare17;
            SideAnswerSquares[17] = SideAnswerSquare18;

            SideAnswerSquares[18] = SideAnswerSquare19;
            SideAnswerSquares[19] = SideAnswerSquare20;

            SideAnswerSquares[20] = SideAnswerSquare21;
            SideAnswerSquares[21] = SideAnswerSquare22;

            SideAnswerSquares[22] = SideAnswerSquare23;
            SideAnswerSquares[23] = SideAnswerSquare24;

            SideAnswerSquares[24] = SideAnswerSquare25;
            SideAnswerSquares[25] = SideAnswerSquare26;

            SideAnswerSquares[26] = SideAnswerSquare27;
            SideAnswerSquares[27] = SideAnswerSquare28;

            SideAnswerSquares[28] = SideAnswerSquare29;
            SideAnswerSquares[29] = SideAnswerSquare30;

            SideAnswerSquares[30] = SideAnswerSquare31;
            SideAnswerSquares[31] = SideAnswerSquare32;

            SideAnswerSquares[32] = SideAnswerSquare33;
            SideAnswerSquares[33] = SideAnswerSquare34;

            SideAnswerSquares[34] = SideAnswerSquare35;
            SideAnswerSquares[35] = SideAnswerSquare36;

            SideAnswerSquares[36] = SideAnswerSquare37;
            SideAnswerSquares[37] = SideAnswerSquare38;

            SideAnswerSquares[38] = SideAnswerSquare39;
            SideAnswerSquares[39] = SideAnswerSquare40;

            AnswerSquares[0] = AnswerSquare1;
            AnswerSquares[1] = AnswerSquare2;
            AnswerSquares[2] = AnswerSquare3;
            AnswerSquares[3] = AnswerSquare4;

            BoardState[0, 0] = UserAnswerSquare1;
            BoardState[0, 1] = UserAnswerSquare2;
            BoardState[0, 2] = UserAnswerSquare3;
            BoardState[0, 3] = UserAnswerSquare4;

            BoardState[1, 0] = UserAnswerSquare5;
            BoardState[1, 1] = UserAnswerSquare6;
            BoardState[1, 2] = UserAnswerSquare7;
            BoardState[1, 3] = UserAnswerSquare8;

            BoardState[2, 0] = UserAnswerSquare9;
            BoardState[2, 1] = UserAnswerSquare10;
            BoardState[2, 2] = UserAnswerSquare11;
            BoardState[2, 3] = UserAnswerSquare12;

            BoardState[3, 0] = UserAnswerSquare13;
            BoardState[3, 1] = UserAnswerSquare14;
            BoardState[3, 2] = UserAnswerSquare15;
            BoardState[3, 3] = UserAnswerSquare16;

            BoardState[4, 0] = UserAnswerSquare17;
            BoardState[4, 1] = UserAnswerSquare18;
            BoardState[4, 2] = UserAnswerSquare19;
            BoardState[4, 3] = UserAnswerSquare20;

            BoardState[5, 0] = UserAnswerSquare21;
            BoardState[5, 1] = UserAnswerSquare22;
            BoardState[5, 2] = UserAnswerSquare23;
            BoardState[5, 3] = UserAnswerSquare24;

            BoardState[6, 0] = UserAnswerSquare25;
            BoardState[6, 1] = UserAnswerSquare26;
            BoardState[6, 2] = UserAnswerSquare27;
            BoardState[6, 3] = UserAnswerSquare28;

            BoardState[7, 0] = UserAnswerSquare29;
            BoardState[7, 1] = UserAnswerSquare30;
            BoardState[7, 2] = UserAnswerSquare31;
            BoardState[7, 3] = UserAnswerSquare32;

            BoardState[8, 0] = UserAnswerSquare33;
            BoardState[8, 1] = UserAnswerSquare34;
            BoardState[8, 2] = UserAnswerSquare35;
            BoardState[8, 3] = UserAnswerSquare36;

            BoardState[9, 0] = UserAnswerSquare37;
            BoardState[9, 1] = UserAnswerSquare38;
            BoardState[9, 2] = UserAnswerSquare39;
            BoardState[9, 3] = UserAnswerSquare40;

        }

        void SetColours()
        {
            for (int i = 0; i < BoardState.GetLength(0); i++)
            {
                for (int x = 0; x < BoardState.GetLength(1); x++)
                {
                    BoardState[i, x].BackColor = Grey;
                }
            }

            for (int i = 0; i < SideAnswerSquares.GetLength(0); i++)
            {
                SideAnswerSquares[i].BackColor = Grey;
            }
        }

        public Form1()
        {
            InitializeComponent();
            GenerateSolution();
            SetArrays();
            //debug
            SetColours();
        }

        void GenerateSolution()
        {
            //sets solution colours
            for (int i = 0; i < 4; i++)
            {
                switch (random.Next(1, 7))
                {
                    case 1:
                        solution[i] = "Red";                    
                        break;
                    case 2:
                        solution[i] = "Blue";
                        break;
                    case 3:
                        solution[i] = "Yellow";
                        break;
                    case 4:
                        solution[i] = "Purple";
                        break;
                    case 5:
                        solution[i] = "Green";
                        break;
                    case 6:
                        solution[i] = "Pink";
                        break;
                }
            }
            if (HasDuplicates(solution))
            {
                GenerateSolution();
            }
        }

        void ShowSolution()
        {
            for (int i = 0; i < 4; i++)
            {
                switch (solution[i])
                {
                    case "Red":
                        AnswerSquares[i].BackColor = Red;
                        break;
                    case "Blue":
                        AnswerSquares[i].BackColor = Blue;
                        break;
                    case "Yellow":
                        AnswerSquares[i].BackColor = Yellow;
                        break;
                    case "Purple":
                        AnswerSquares[i].BackColor = Purple;
                        break;
                    case "Green":
                        AnswerSquares[i].BackColor = Green;
                        break;
                    case "Pink":
                        AnswerSquares[i].BackColor = Pink;
                        break;
                }
            }
            AnswerSquare1.Visible = true;
            AnswerSquare2.Visible = true;
            AnswerSquare3.Visible = true;
            AnswerSquare4.Visible = true;
        }

        void GetGuess()
        {
            //get guesses
            guess[0] = UserColour1.Text;
            guess[1] = UserColour2.Text;
            guess[2] = UserColour3.Text;
            guess[3] = UserColour4.Text;

            CheckGuess();

            //for each guess
            for (int i = 0; i < 4; i++)
            {
                //check what the user guessed; then set colour to guess
                switch (guess[i])
                {
                    case "Red":
                        BoardState[CurrentTurn, i].BackColor = Red;
                        break;
                    case "Blue":
                        BoardState[CurrentTurn, i].BackColor = Blue;
                        break;
                    case "Yellow":
                        BoardState[CurrentTurn, i].BackColor = Yellow;
                        break;
                    case "Purple":
                        BoardState[CurrentTurn, i].BackColor = Purple;
                        break;
                    case "Green":
                        BoardState[CurrentTurn, i].BackColor = Green;
                        break;
                    case "Pink":
                        BoardState[CurrentTurn, i].BackColor = Pink;
                        break;
                }
            }
            //increase turn count
            CurrentTurn++;            
        }

        void CheckGuess()
        {
            if (guess.SequenceEqual(solution))
            {
                ShowSolution();
                GuessButton.Visible = false;
            }

            for (int i = 0; i < 4; i++)
            {

                if (guess[i] == solution[i])
                {
                    SideAnswerSquares[i + CurrentTurn * 4].BackColor = Red;
                }
                else if (solution.Contains(guess[i]))
                {
                    SideAnswerSquares[i + CurrentTurn * 4].BackColor = Black;
                }
            }
            if (CurrentTurn == 9)
            {
                GuessButton.Visible = false;
                ShowSolution();
            }
        }

        private bool HasDuplicates(string[] arrayList)
        {
            List<string> vals = new List<string>();
            bool returnValue = false;
            foreach (string s in arrayList)
            {
                if (vals.Contains(s))
                {
                    returnValue = true;
                    break;
                }
                vals.Add(s);
            }


            return returnValue;
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            GetGuess();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            GenerateSolution();
            //debug
            ShowSolution();
            SetColours();
            CurrentTurn = 0;
            AnswerSquare1.Visible = false;
            AnswerSquare2.Visible = false;
            AnswerSquare3.Visible = false;
            AnswerSquare4.Visible = false;
            GuessButton.Visible = true;
        }

        private void InstructionsButton_Click(object sender, EventArgs e)
        {
            Form2 myform2 = new Form2();
            myform2.Show();
        }
    }
}