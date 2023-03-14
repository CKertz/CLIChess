using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models.Pieces
{
    public abstract class ChessPiece //: IChessPiece
    {
        public PieceName ChessPieceName { get; set; }
        public Color ChessPieceColor { get; set; }
        public int YCoordinate { get; set; }
        public char XCoordinate { get; set; }
        public abstract bool Move(List<BoardTile> chessBoard, char desiredXCoord, int desiredYCoord, bool isWhiteMove);

        //TODO: can uncomment later when ready to implement across all pieces
        //public abstract bool IsColliding(char desiredXCoord, int desiredYCoord, List<BoardTile> chessBoard);
    }
}
