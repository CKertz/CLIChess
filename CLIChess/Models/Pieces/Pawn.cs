using CLIChess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess.Models
{
    public class Pawn : ChessPiece
    {
        public Pawn()
        {
            ChessPieceName = PieceName.Pawn;
            IsFirstMove = true;
        }
        private bool IsFirstMove { get; set; }
        public override bool Move(List<BoardTile> chessBoard, char desiredXCoord, int desiredYCoord, bool isWhiteMove)
        {

            if (BoardRules.IsInBounds(desiredXCoord, desiredYCoord) && !BoardRules.IsColliding(desiredXCoord, desiredYCoord, chessBoard))
            {
                BoardRules boardRules = new BoardRules();
                //boardRules.ExecuteMove(chessBoard, desiredXCoord, desiredYCoord, PieceName.Pawn);             
            }
            return false;
        }

        private bool IsMoveValid(char oldXCoord, int oldYCoord, char desiredXCoord, int desiredYCoord, List<BoardTile> chessBoard)
        {
            //TODO: unfinished
            //move 1 up, or 2 up on first turn
            //move diag only if capping
            if(Math.Abs(desiredYCoord - oldYCoord) > 2)
            {
                Console.WriteLine("Pawns don't move that far");
                return false;
            }
            if(Math.Abs(desiredYCoord - oldYCoord) > 1 && !IsFirstMove)
            {
                Console.WriteLine("Pawn can't be moved more than one space after its first move");
                return false;
            }

            if(IsFirstMove)
            {
                //move up 1 - check if piece 1 up is colliding
                
                //move up 2, check if piece 1 or 2 up is colliding.

                //capture L/R 1

                if (!BoardRules.IsColliding(desiredXCoord,desiredYCoord,chessBoard))
                {

                }
            }
            else
            {
                //move up 1 - check if piece 1 up is colliding

                //capture L/R 1
            }
            return true;
        }

        private void CapturePiece(char oldXcoord, int oldYCoord, char desiredXCoord, int desiredYCoord, List<BoardTile> chessBoard)
        {
            if (desiredXCoord != oldXcoord && (Math.Abs(desiredXCoord - oldXcoord) == 1))
            {
                //capture attempt
                if (chessBoard.Where(p => p.XCoordinate == desiredXCoord && p.YCoordinate == desiredYCoord).FirstOrDefault().OccupyingPiece == null)
                {
                    //nothing diag

                }
                else
                {

                }
            }
        }
    }
}
