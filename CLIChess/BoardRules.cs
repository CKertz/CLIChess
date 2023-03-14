using CLIChess.Models;
using CLIChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess
{
    public class BoardRules
    {
        public static bool IsInBounds(char xCoord, int yCoord)
        {
            if(yCoord > 8 || yCoord < 1)
            {
                return false;
            }
            if(xCoord < 'a' || xCoord  > 'h')
            {
                return false;
            }
            return true;
        }

        public static void ExecuteMove(List<BoardTile> chessBoard, char desiredXCoord, int desiredYCoord, PieceName pieceName, bool isWhiteMove)
        {
            //determine which pawn is eligble to move to the desired coord
            //for each of the team's turn piece, attempt the move until it succeeds or all fail out(invalid)
            var pieceCollection = new List<BoardTile>();
            pieceCollection = chessBoard?.Where(x => x.OccupyingPiece != null && x.OccupyingPiece.ChessPieceName == pieceName).ToList();
            foreach (BoardTile tile in pieceCollection)
            {
                var oldXCoord = tile.XCoordinate;
                var oldYCoord = tile.YCoordinate;
                if (!IsMoveColliding(oldXCoord, oldYCoord, desiredXCoord, desiredYCoord, chessBoard, pieceName) && IsCorrectTeamMovingPiece(isWhiteMove, tile))
                {
                    tile.OccupyingPiece.XCoordinate = desiredXCoord;
                    tile.OccupyingPiece.YCoordinate = desiredYCoord;
                    var newIndex = chessBoard.IndexOf(chessBoard.Where(n => n.XCoordinate == desiredXCoord && n.YCoordinate == desiredYCoord).FirstOrDefault());
                    chessBoard[newIndex].OccupyingPiece = tile.OccupyingPiece;

                    Console.WriteLine(pieceName + "to " + desiredXCoord + desiredYCoord);
                    var oldIndex = chessBoard.IndexOf(chessBoard.Where(z => z.XCoordinate == oldXCoord && z.YCoordinate == oldYCoord).FirstOrDefault());
                    chessBoard[oldIndex].OccupyingPiece = null;
                    return;
                }
            }
        }

        public static BoardCoordinates GetCurrentPieceCoordinates(List<BoardTile> chessBoard, char desiredXCoord, int desiredYCoord, PieceName pieceName, bool isWhiteMove)
        {
            var pieceCollection = new List<BoardTile>();
            pieceCollection = chessBoard?.Where(x => x.OccupyingPiece != null && x.OccupyingPiece.ChessPieceName == pieceName).ToList();
            var res = new BoardCoordinates();
            foreach (BoardTile tile in pieceCollection)
            {
                var oldXCoord = tile.XCoordinate;
                var oldYCoord = tile.YCoordinate;
                if (!IsMoveColliding(oldXCoord, oldYCoord, desiredXCoord, desiredYCoord, chessBoard, pieceName) && IsCorrectTeamMovingPiece(isWhiteMove, tile))
                {
                    res.XCoordinate = tile.XCoordinate;
                    res.YCoordinate = tile.YCoordinate;
                    return res;
                }
            }
            return res;
        }

        public static bool IsCorrectTeamMovingPiece(bool isWhiteMove, BoardTile tile)
        {
            if (isWhiteMove && tile.OccupyingPiece.ChessPieceColor == Color.White ||
                !isWhiteMove && tile.OccupyingPiece.ChessPieceColor == Color.Black)
            {
                return true;
            }            
            return false;
        }

        public static bool IsMoveColliding(char oldXCoord, int oldYCoord, char desiredXCoord, int desiredYCoord, List<BoardTile> chessBoard, PieceName pieceName)
        {
            switch(pieceName)
            {
                case PieceName.Rook:
                    Rook rook = new Rook();
                    return rook.IsColliding(oldXCoord, oldYCoord, desiredXCoord, desiredYCoord, chessBoard);
                    //and so on..
                default:
                    return false;
            }
        }
        public static bool IsColliding(char xCoord, int yCoord, List<BoardTile> chessBoard)
        {
            //TODO: delete if we make this an abstract method in chesspiece.cs
            //knight - check if landing spot is occupied
            //pawn - check if piece is 1 (or 2) spots up. or diagonal
            //rook - check if anything is in up/down/left/right path
            //queen - anywhere
            //king - anywhere within 1
            //bishop - diagonal 
            return false;
        }
    }
}
