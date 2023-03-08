using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models
{
    class BoardTile
    {
        public BoardTile(char x, int y)
        {
            this.XCoordinate = x;
            this.YCoordinate = y;
        }
        public IChessPiece OccupyingPiece { get; set; }
        public char XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Color TileColor {get;set;}
    }
}
