using System;

namespace CLIChess
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = new UserInput();
            var gameBoard = BoardSetup.SetupChessBoard();
            BoardStateEditor.NullPieceAtBoardCoordinates(gameBoard, 'a', 7);
            BoardStateEditor.NullPieceAtBoardCoordinates(gameBoard, 'f', 1);
            BoardStateEditor.NullPieceAtBoardCoordinates(gameBoard, 'e', 1);
            BoardStateEditor.NullPieceAtBoardCoordinates(gameBoard, 'd', 1);

            userInput.PlayGame(gameBoard);
        }
    }
}
