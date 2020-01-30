using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class TicTacToe
    {
      public void Tictactoe()
        {
            int[,] a = new int[3, 3];
            Game game = new Game();
             game.IntializeBoard();
            Console.WriteLine("Welcome to tictoctoe");
            int Row;
            int Col;
            do
            {
                do
                {
                    Console.WriteLine("Player  " + game.Currentplayer() + " enter in the empty row and col to place mark");
                    Row = Utility.userInputs();
                    Col = Utility.userInputs();

                }
                while (!game.PlaceMark(Row, Col));
                game.ChangePlayer();
            }
            while (!(game.isWinner()) && !(game.isBoardFull())); 
            if(game.isBoardFull() && !game.isWinner())
            {
                Console.WriteLine("the game is tie ");
            }
            Console.WriteLine("Curent Board Layout :");
            game.printBoard();
            game.ChangePlayer();
            Console.WriteLine(char.ToUpper(game.Currentplayer()) + "wins!");


        }

    }
}
