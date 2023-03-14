using CLIChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models
{
    public class Rook : ChessPiece
    {
        public Rook()
        {
            ChessPieceName = PieceName.Rook;
        }
        public override bool Move(List<BoardTile> chessBoard, char desiredXCoord, int desiredYCoord, bool isWhiteMove)
        {
            //can move right/left/up/down unless collision with a piece OR edge of board
            //
            if (BoardRules.IsInBounds(desiredXCoord, desiredYCoord))
            {
                BoardCoordinates oldCoords = BoardRules.GetCurrentPieceCoordinates(chessBoard, desiredXCoord, desiredYCoord, PieceName.Rook, isWhiteMove);
                if(!IsColliding(oldCoords.XCoordinate, oldCoords.YCoordinate, desiredXCoord, desiredYCoord, chessBoard))
                {
                    BoardRules.ExecuteMove(chessBoard, desiredXCoord, desiredYCoord, PieceName.Rook, isWhiteMove);
                }

            }
            return false;
        }

        public bool IsMoveValid()
        {
            return true;
        }

        public bool IsColliding(char oldXCoord, int oldYCoord, char desiredXCoord, int desiredYCoord, List<BoardTile> chessBoard)
        {
            //determine direction
            if(oldXCoord == desiredXCoord)
            {
                //vertical move, see if anything is in tiles between oldycoord and desiredycoord
                //get all tiles in xcoord between old/new ycoord

                if(oldYCoord < desiredYCoord)
                {
                    var passingTiles = chessBoard.Where(i => i.XCoordinate == desiredXCoord && i.YCoordinate <= desiredYCoord);

                    //upward move
                    foreach (BoardTile tile in passingTiles)
                    {
                        if (tile.YCoordinate > oldYCoord && tile.OccupyingPiece != null)
                        {
                            Console.WriteLine("Invalid move, collides with {0} at {1}{2}", tile.OccupyingPiece.ChessPieceName, tile.XCoordinate, tile.YCoordinate);
                            return true;
                        }
                    }                   
                }
                if (oldYCoord > desiredYCoord)
                {
                    var passingTiles = chessBoard.Where(i => i.XCoordinate == desiredXCoord && i.YCoordinate >= desiredYCoord);

                    //downward move
                    foreach (BoardTile tile in passingTiles.Reverse())//passingTiles.reverse()?
                    {
                        if (tile.YCoordinate < oldYCoord && tile.OccupyingPiece != null)
                        {
                            return true;
                        }
                    }
                }
            }

            if(oldYCoord == desiredYCoord)
            {
                //side move               
                if (oldXCoord < desiredXCoord)
                {
                    var passingTiles = chessBoard.Where(i => i.YCoordinate == desiredYCoord && i.XCoordinate <= desiredXCoord);
                    //right side move
                    foreach (BoardTile tile in passingTiles)
                    {
                        if (tile.XCoordinate > oldXCoord && tile.OccupyingPiece != null)
                        {
                            return true;
                        }
                    }
                }
                if (oldXCoord > desiredXCoord)
                {
                    var passingTiles = chessBoard.Where(i => i.YCoordinate == desiredYCoord && i.XCoordinate >= desiredXCoord);
                    //left side move
                    foreach (BoardTile tile in passingTiles.Reverse())
                    {
                        if (tile.XCoordinate < oldXCoord && tile.OccupyingPiece != null)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
