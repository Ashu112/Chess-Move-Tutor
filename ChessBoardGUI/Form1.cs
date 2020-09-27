using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoardGUI
{
    public partial class Form1 : Form
    {
        //reference to the class Board. Contains the values of the board.
        static Board myBoard = new Board(8);
        // 2D array of buttons whose values are determined by mybBoard.
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];
        public Form1()
        {
            InitializeComponent();
            populateGrid();

        }

        private void populateGrid()
        {
            //Create buttons and place them into panel 1

            int buttonSize = panel1.Width / myBoard.Size;

            //make the panel a perfect square.
            panel1.Height = panel1.Width;

            //nested loops. create buttons and print them to the screen.
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j] = new Button();
                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;

                    // add a click event to each button.
                    btnGrid[i, j].Click += Grid_Button_Click;

                    //add the new button to the panel.
                    panel1.Controls.Add(btnGrid[i, j]);

                    // set the location of the new button.
                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);
                    
                    

                    btnGrid[i, j].Tag = new Point(i, j);

                }
            }
            int a, b, r;
            for( a=0;a<myBoard.Size;a++)
            {
                if( a%2==0)
                {
                    r = 1;
                }
                else { r = 0; }
                for(b=0;b<myBoard.Size;b++)
                {
                    if(b%2==r)
                    { btnGrid[a, b].BackColor = Color.SlateGray; }

                }
            }

        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            // get the row and col number of the button clicked
            Button clickedbutton = (Button)sender;
            Point location = (Point)clickedbutton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell currentCell = myBoard.theGrid[x, y];


            // detemine the legal next moves 
            if((string )comboBox1.SelectedItem == "King")
            {
                myBoard.MarknextLegalMoves(currentCell, "King");
            }
            else if((string)comboBox1.SelectedItem == "Queen" )
            {
                myBoard.MarknextLegalMoves(currentCell, "Queen");
            }
            else if ((string )comboBox1.SelectedItem == "Knight")
            {
                myBoard.MarknextLegalMoves(currentCell, "Knight");
            }
            else if ((string)comboBox1.SelectedItem == "Rook")
            {
                myBoard.MarknextLegalMoves(currentCell, "Rook");
            }
            else if ((string)comboBox1.SelectedItem == "Bishop")
            {
                myBoard.MarknextLegalMoves(currentCell, "Bishop");
            }
            else if ((string)comboBox1.SelectedItem == "Pawn")
            {
                myBoard.MarknextLegalMoves(currentCell, "Pawn");
            }


            // update the text on each button
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j].Text = "";
                    if (myBoard.theGrid[i, j].LegalNextMove == true)
                    {
                        btnGrid[i, j].Text = "Legal";
                    }
                    else if (myBoard.theGrid[i, j].CurrentlyOccupied == true)
                    {
                        if ((string)comboBox1.SelectedItem == "King")
                        {
                            btnGrid[i, j].Text = "King";
                        }
                        else if ((string)comboBox1.SelectedItem == "Queen")
                        {
                            btnGrid[i, j].Text = "Queen";
                        }
                        else if ((string)comboBox1.SelectedItem == "Knight")
                        {
                            btnGrid[i, j].Text = "Knight";
                        }
                        else if ((string)comboBox1.SelectedItem == "Rook")
                        {
                            btnGrid[i, j].Text = "Rook";
                        }
                        else if ((string)comboBox1.SelectedItem == "Bishop")
                        {
                            btnGrid[i, j].Text = "Bishop";
                        }
                        else if ((string)comboBox1.SelectedItem == "Pawn")
                        {
                            btnGrid[i, j].Text = "Pawn";
                        }


                    }
                }
            }


        }

       

       
    }
}
