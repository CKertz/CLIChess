using CLIChess.Models;
using CLIChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess
{
    class BoardSetup
    {
        //public static List<BoardTile> ChessBoard = new List<BoardTile>();

        //value of 'a'-1 when casted to int. this is just used as an easy way to give coordinates to tiles on creation of a board
        private const int asciiHelper = 96;
        public static void SetupChessBoard()
        {
            List<BoardTile> ChessBoard = new List<BoardTile>();
            for (int i = 1 + asciiHelper; i <= 8 + asciiHelper; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    BoardTile newTile = new BoardTile((char)i,j);
                    if ((i % 2 != 0) && (j % 2 == 0))
                    {
                        newTile.TileColor = Color.White;
                    }
                    if ((i % 2 == 0) && (j % 2 == 1))
                    {
                        newTile.TileColor = Color.White;
                    }
                    AddPieceToBoard(newTile);
                    ChessBoard.Add(newTile);
                    Console.WriteLine("tile created with coordinates of: " + newTile.XCoordinate + newTile.YCoordinate+ " " + newTile.TileColor);
                    if (newTile.OccupyingPiece != null)
                    {
                        var color = newTile.OccupyingPiece.ChessPieceColor.ToString();
                        var piecename = newTile.OccupyingPiece.ChessPieceName.ToString();
                        Console.WriteLine(color + piecename);
                    }
                }
            }
        }
        public static void AddPieceToBoard(BoardTile tile)
        {
            if (tile.YCoordinate < 7 && tile.YCoordinate > 2) { return; }
  
            //TODO: probably a way to extract SetChessPieceProperties out to be called only once
            if (tile.YCoordinate == 2 || tile.YCoordinate == 7)
            {
                var newPiece = new Pawn();
                SetChessPieceProperties(newPiece, tile);
                return;
            }
            if(tile.XCoordinate == 'a' || tile.XCoordinate == 'h')
            {
                var newPiece = new Rook();
                SetChessPieceProperties(newPiece, tile);
                return;
            }
            if(tile.XCoordinate == 'b' || tile.XCoordinate == 'g')
            {
                var newPiece = new Knight();
                SetChessPieceProperties(newPiece, tile);
                return;
            }
            if (tile.XCoordinate == 'c' || tile.XCoordinate == 'f')
            {
                var newPiece = new Bishop();
                SetChessPieceProperties(newPiece, tile);
                return;
            }
            if (tile.XCoordinate == 'd')
            {
                var newPiece = new Queen();
                SetChessPieceProperties(newPiece, tile);
                return;
            }
            if (tile.XCoordinate == 'e')
            {
                var newPiece = new King();
                SetChessPieceProperties(newPiece, tile);
                return;
            }
        }

        public static void SetChessPieceProperties(ChessPiece chessPiece, BoardTile boardTile)
        {
            if (boardTile.YCoordinate <= 2)
            {
                chessPiece.ChessPieceColor = Color.White;
            }
            boardTile.OccupyingPiece = chessPiece;
        }

    }
}
