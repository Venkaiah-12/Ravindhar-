using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Game
    {
             char[,] Board;
          char CurrentPlayer;
            public Game()
            {
             Board = new char[3, 3];
            CurrentPlayer ='X';

            IntializeBoard();
            }
        public char Currentplayer()
        {
            return CurrentPlayer;
        }
        public void IntializeBoard()
        {
            for(int row=0;row<3;row++)
            {
                for(int col=0; col<3;col++)
                {
                    Board[row, col] = '-';
                }
            }
        }
       /* public void IntializeBoard()
        {
            printRow();
        }
        public void printRow()
        {
            for(int row=0;row<Board.Length;row++)
            {
                printCol(row);
            }
        }
        public void printCol(int row)
        {
            for(int col=0;col<Board.Length;col++)
            {
                Board[row, col] = '-';
            }
        }*/
        public void printBoard()
        {
            Console.WriteLine("================");
            printRowBoard();
        }
       public void printRowBoard()
        {
            for(int row=0;row<3;row++)
            {
                Console.Write("|   ");
                printColBoard(row);
            }
        }
        public void printColBoard(int row)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(Board[row, col] + "|   ");
               
            }

            Console.WriteLine();
            Console.WriteLine("================");
        }

        public bool isBoardFull()
        {
            bool status = true;
            for(int row=0; row<3;row++)
            {
                for(int col=0; col<3;col++)
                {
                    if(Board[row,col]=='-')
                    {
                        status = false;
                    }
                }
            }
            return status;

        }
        public bool isWinner()
        {
            return (checkRows() || checkCols() || checkDiagonals());
        }
        public bool checkDiagonals()
        {
            return ((CheckRowCol(Board[0, 0],Board[1, 1],Board[2, 2] )== true)||(CheckRowCol(Board[0,2],Board[1,1],Board[0,1])==true));
        }
        public bool CheckRowCol(char c,char d,char e)
        {
            return (c != '-') && (c == d) && (d == e);
        }
        public bool checkRows()
        {
            for (int row = 0; row < 3; row++)
            {
                if (CheckRowCol(Board[row, 0], Board[row, 1], Board[row, 2]) == true)
               {
                    return true;
                }
            }
            return false;

        }
        public bool checkCols()
        {
            for(int col=0;col<3;col++)
            {
                if(CheckRowCol(Board[0,col],Board[1,col],Board[2,col])==true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool PlaceMark(int Row, int Col)
        {
            if((Row >=0 ) && (Row <3))
            {
                if((Col >= 0) && ( Col < 3))
                {
                 if(Board[Row,Col]=='-')
                    {
                        Board[Row, Col] = CurrentPlayer;
                        return true;
                    }
                }
            }
            return false;
        }
        public void ChangePlayer()
        {
            if(CurrentPlayer=='x')
            {
                CurrentPlayer = 'o';
            }
            else
            {
                CurrentPlayer = 'x';
            }
        }
        
    }
}
