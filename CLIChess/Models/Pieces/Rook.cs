using CLIChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models
{
    class Rook : ChessPiece
    {
        public override void MovePiece(List<BoardTile> chessBoard, char desiredXCoord, int desiredYCoord)
        {
            //can move right/left/up/down unless collision with a piece OR edge of board
            //
            if (BoardRules.IsInBounds(desiredXCoord, desiredYCoord) && !BoardRules.IsColliding(desiredXCoord,desiredYCoord,chessBoard))
            {
               
            }
        }
        public bool IsColliding(char desiredXCoord, int desiredYCoord, List<BoardTile> chessBoard)
        {
            //knight - check if landing spot is occupied
            //pawn - check if piece is 1 (or 2) spots up. or diagonal
            //rook - check if anything is in up/down/left/right path
            //queen - anywhere
            //king - anywhere within 1
            //bishop - diagonal 
            return false;
        }

        public Rook()
        {
            ChessPieceName = PieceName.Rook;
        }
    }
}
