using CLIChess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess
{
    public class BoardStateEditor
    {
        //quick and sloppy tool used to alter board state and test piece movements
        public static void NullPieceAtBoardCoordinates(List<BoardTile> chessBoard, char xCoordToDelete, int yCoordToDelete)
        {
            var index = chessBoard.IndexOf(chessBoard.Where(x => x.XCoordinate == xCoordToDelete && x.YCoordinate == yCoordToDelete).FirstOrDefault());
            chessBoard[index].OccupyingPiece = null;
        }
    }
}
