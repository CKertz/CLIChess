using System;

namespace CLIChess
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = new UserInput();
            var gameBoard = BoardSetup.SetupChessBoard();
            userInput.PlayGame(gameBoard);
        }
    }
}
