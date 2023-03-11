using System;

namespace CLIChess
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = new UserInput();
            BoardSetup.SetupChessBoard();
            userInput.PlayGame();
        }
    }
}
