using CLIChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models
{
    class Knight : ChessPiece
    {
        public override void MovePiece(List<BoardTile> chessBoard, char desiredXCoord, int desiredYCoord)
        {

        }
        public Knight()
        {
            ChessPieceName = PieceName.Knight;
        }
    }
}
