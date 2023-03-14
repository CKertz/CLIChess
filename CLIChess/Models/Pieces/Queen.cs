﻿using CLIChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models
{
    public class Queen : ChessPiece
    {
        public Queen()
        {
            ChessPieceName = PieceName.Queen;
        }

        public override bool Move(List<BoardTile> chessBoard, char desiredXCoord, int desiredYCoord, bool isWhiteMove)
        {
            if (BoardRules.IsInBounds(desiredXCoord, desiredYCoord) && !BoardRules.IsColliding(desiredXCoord, desiredYCoord, chessBoard))
            {

            }
            return false;

        }
    }
}
