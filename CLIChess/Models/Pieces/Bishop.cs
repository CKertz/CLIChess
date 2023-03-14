using CLIChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models
{
    public class Bishop : ChessPiece
    {
        public Bishop()
        {
            ChessPieceName = PieceName.Bishop;
        }
        public override bool Move(List<BoardTile> chessBoard, char desiredXCoord, int desiredYCoord, bool isWhiteMove)
        {
            //can move right/left/up/down unless collision with a piece OR edge of board
            //
            if (BoardRules.IsInBounds(desiredXCoord, desiredYCoord) && !BoardRules.IsColliding(desiredXCoord, desiredYCoord, chessBoard))
            {

            }
            return false;

        }
    }
}
