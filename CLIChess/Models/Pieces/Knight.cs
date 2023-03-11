using CLIChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models
{
    public class Knight : ChessPiece
    {
        public Knight()
        {
            ChessPieceName = PieceName.Knight;
        }

        public override void Move(List<BoardTile> chessBoard, char desiredXCoord, int desiredYCoord)
        {
            if (BoardRules.IsInBounds(desiredXCoord, desiredYCoord) && !BoardRules.IsColliding(desiredXCoord, desiredYCoord, chessBoard))
            {

            }
        }
    }
}
