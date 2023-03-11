using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models
{
    //TODO: deleteable, using abstract class instead
    public interface IChessPiece
    {
        public PieceName ChessPieceName { get; set; }
        public Color ChessPieceColor { get; set; }
        public void Move(List<BoardTile> chessBoard, char desiredXCoord, int desiredYCoord);

    }
}
