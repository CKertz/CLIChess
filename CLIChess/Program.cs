using System;

namespace CLIChess
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardSetup.SetupChessBoard();
            UserInput.PlayGame();
        }
    }
}
