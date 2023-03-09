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
        public static bool IsColliding(char xCoord, int yCoord, List<BoardTile> chessBoard)
        {
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
