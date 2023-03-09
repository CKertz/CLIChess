using CLIChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models
{
    class Pawn : ChessPiece
    {
        public override void MovePiece(List<BoardTile> chessBoard, char desiredXCoord, int desiredYCoord)
        {

        }
        public Pawn()
        {
            ChessPieceName = PieceName.Pawn;
        }
    }
}
