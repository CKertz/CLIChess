﻿using CLIChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models
{
    class Bishop : ChessPiece
    {
        public override void MovePiece()
        {

        }
        public Bishop()
        {
            ChessPieceName = PieceName.Bishop;
        }
    }
}
