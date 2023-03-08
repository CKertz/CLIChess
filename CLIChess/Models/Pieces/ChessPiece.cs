﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models.Pieces
{
    public abstract class ChessPiece : IChessPiece
    {
        public PieceName ChessPieceName { get; set; }
        public Color ChessPieceColor { get; set; }
        public abstract void MovePiece();
    }
}
