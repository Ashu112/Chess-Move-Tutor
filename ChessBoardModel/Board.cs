using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Board
    {
        public int Size { get; set; }

        public Cell[,] theGrid { get; set; }
        public Board(int s)
        {
            Size = s;

            theGrid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void MarknextLegalMoves(Cell currentCell, string chessPiece)
        {

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;
                }
            }

            switch (chessPiece)
            {
                case "Knight":
                    if (currentCell.RowNumber == 0 && currentCell.Columnnumber == 0)
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 2].LegalNextMove = true;

                    }
                    else if (currentCell.RowNumber == 0 && currentCell.Columnnumber == 7)
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                    }
                    else if (currentCell.RowNumber == 7 && currentCell.Columnnumber == 0)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                    }
                    else if (currentCell.RowNumber == 7 && currentCell.Columnnumber == 7)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    else if (currentCell.RowNumber == 0 && currentCell.Columnnumber == 1)
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                    }
                    else if ( currentCell.RowNumber ==1 && currentCell.Columnnumber == 0  )
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                    }
                    else if( currentCell.RowNumber == 0 && currentCell.Columnnumber == 6 )
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                    }
                    else if ( currentCell.RowNumber == 1 && currentCell.Columnnumber == 7)
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                    }
                    else if (currentCell.RowNumber ==6 && currentCell.Columnnumber == 0)
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                    }
                    else if ( currentCell.RowNumber ==7 && currentCell.Columnnumber == 1)
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    else if ( currentCell.RowNumber == 6 && currentCell.Columnnumber == 7  )
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                    }
                    else if ( currentCell.RowNumber == 7 && currentCell.Columnnumber == 6  )
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    else if (currentCell.RowNumber == 0 )
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                    }
                    else if ( currentCell.RowNumber ==7 )
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                    }
                    else if ( currentCell.Columnnumber == 0 )
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                    }
                    else if ( currentCell.Columnnumber == 7 )
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                    }
                    else if ( currentCell.RowNumber == 1 && currentCell.Columnnumber == 1 )
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                    }
                    else if ( currentCell.RowNumber == 1 && currentCell.Columnnumber == 6  )
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                    }
                    else if ( currentCell.RowNumber == 6 && currentCell.Columnnumber ==1  )
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                    }
                    else if ( currentCell.RowNumber == 6 && currentCell.Columnnumber == 6 )
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                    }
                    else if (currentCell.RowNumber == 1 )
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                    }
                    else if ( currentCell.RowNumber ==6 )
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                    }
                    else if ( currentCell.Columnnumber == 1)
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                    }
                    else if (currentCell.Columnnumber == 6)
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    else
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 2, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 2].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 2].LegalNextMove = true;

                    }
                    break;

                case "King":
                    if (currentCell.RowNumber == 0 && currentCell.Columnnumber == 0)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 0].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 1].LegalNextMove = true;
                    }
                    else if (currentCell.RowNumber == 0 && currentCell.Columnnumber == 7 )
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 0].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    else if (currentCell.RowNumber ==7 && currentCell.Columnnumber ==0  )
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 0].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 1].LegalNextMove = true;
                    }

                    else if (currentCell.RowNumber == 7 && currentCell.Columnnumber == 7)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 0].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    else if (currentCell.Columnnumber == 0  )
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 0].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 0].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 1].LegalNextMove = true;
                    }
                    else if (currentCell.Columnnumber == 7)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 0].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 0].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    else if(currentCell.RowNumber == 0)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 0].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    else if ( currentCell.RowNumber == 7)
                    {
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 0].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    else
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 0].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 0].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber - 1, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber - 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 1, currentCell.Columnnumber - 1].LegalNextMove = true;
                        
                    }



                    break;

                case "Rook":
                    for (int i = 1; i < Size - currentCell.RowNumber; i++)
                    { 
                        theGrid[currentCell.RowNumber + i, currentCell.Columnnumber + 0].LegalNextMove = true;
                    }
                   for(int i=1; i<=currentCell.RowNumber  ; i++)
                    {
                        theGrid[currentCell.RowNumber - i, currentCell.Columnnumber + 0].LegalNextMove = true;
                    }
                    for (int i = 1; i < Size - currentCell.Columnnumber ; i++)
                    {
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber + i].LegalNextMove = true;
                    }
                    for (int i = 1 ; i <= currentCell.Columnnumber ; i++)
                    {
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber - i].LegalNextMove = true;
                    }



                    break;

                case "Bishop":

                   for(int i=1; i<Size -currentCell.RowNumber;i++)
                    {
                        for( int j=1;j<Size -currentCell.Columnnumber;j++)
                        {
                            if(i==j)
                            theGrid[currentCell.RowNumber + i, currentCell.Columnnumber + j].LegalNextMove = true;
                        }
                    }
                    for (int i =1; i <=currentCell.RowNumber; i++)
                    {
                        for (int j = 1; j <=currentCell.Columnnumber ; j++)
                        {
                            if (i == j)
                                theGrid[currentCell.RowNumber - i, currentCell.Columnnumber - j].LegalNextMove = true;
                        }
                    }


                    for(int i=1; i<Size-currentCell.RowNumber ;i++ )
                    {
                        for(int j=1; j <=currentCell.Columnnumber; j++)
                        {
                            if(i==j)
                            theGrid[currentCell.RowNumber + i, currentCell.Columnnumber - j].LegalNextMove = true;
                        }
                    }

                    for( int i=1; i <= currentCell.RowNumber;i++ )
                    {
                        for(int j =1; j<Size-currentCell.Columnnumber;j++ )
                        {
                            if(i==j)
                                theGrid[currentCell.RowNumber - i, currentCell.Columnnumber + j].LegalNextMove = true;

                        }
                    }

                    break;

                case "Pawn":
                    if (currentCell.RowNumber == 0 && currentCell.Columnnumber == 0 )
                    {
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber + 1].LegalNextMove = true;
                    }
                   else if(currentCell.RowNumber ==0 && currentCell.Columnnumber == 7)
                    {
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    else if(currentCell.RowNumber ==7 && currentCell.Columnnumber == 0 )
                    {
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber + 1].LegalNextMove = true;
                    }
                    else if (currentCell.RowNumber == 7 && currentCell.Columnnumber == 7)
                    {
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    else if (currentCell.Columnnumber ==0 )
                        {
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber + 1].LegalNextMove = true;
                    }
                    else if (currentCell.Columnnumber == 7)
                    {
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    else
                    {
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber + 1].LegalNextMove = true;
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber - 1].LegalNextMove = true;
                    }
                    break;


                case "Queen":

                    // Moves of Rook

                    for (int i = 1; i < Size - currentCell.RowNumber; i++)
                    {
                        theGrid[currentCell.RowNumber + i, currentCell.Columnnumber + 0].LegalNextMove = true;
                    }
                    for (int i = 1; i <= currentCell.RowNumber; i++)
                    {
                        theGrid[currentCell.RowNumber - i, currentCell.Columnnumber + 0].LegalNextMove = true;
                    }
                    for (int i = 1; i < Size - currentCell.Columnnumber; i++)
                    {
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber + i].LegalNextMove = true;
                    }
                    for (int i = 1; i <= currentCell.Columnnumber; i++)
                    {
                        theGrid[currentCell.RowNumber + 0, currentCell.Columnnumber - i].LegalNextMove = true;
                    }



                    // Moves of Bishop

                    for (int i = 1; i < Size - currentCell.RowNumber; i++)
                    {
                        for (int j = 1; j < Size - currentCell.Columnnumber; j++)
                        {
                            if (i == j)
                                theGrid[currentCell.RowNumber + i, currentCell.Columnnumber + j].LegalNextMove = true;
                        }
                    }
                    for (int i = 1; i <= currentCell.RowNumber; i++)
                    {
                        for (int j = 1; j <= currentCell.Columnnumber; j++)
                        {
                            if (i == j)
                                theGrid[currentCell.RowNumber - i, currentCell.Columnnumber - j].LegalNextMove = true;
                        }
                    }


                    for (int i = 1; i < Size - currentCell.RowNumber; i++)
                    {
                        for (int j = 1; j <= currentCell.Columnnumber; j++)
                        {
                            if (i == j)
                                theGrid[currentCell.RowNumber + i, currentCell.Columnnumber - j].LegalNextMove = true;
                        }
                    }

                    for (int i = 1; i <= currentCell.RowNumber; i++)
                    {
                        for (int j = 1; j < Size - currentCell.Columnnumber; j++)
                        {
                            if (i == j)
                                theGrid[currentCell.RowNumber - i, currentCell.Columnnumber + j].LegalNextMove = true;

                        }
                    }


                    break;
                default:
                    break;
            }
            theGrid[currentCell.RowNumber, currentCell.Columnnumber].CurrentlyOccupied = true;
        }

        
    }
}
