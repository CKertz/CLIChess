package com.cooper.chess.pieces;

import com.cooper.chess.BoardTile;
import com.cooper.chess.ChessBoard;
import com.cooper.chess.IChessMoves;

import static com.cooper.chess.setup.BoardSetupHelper.getTranslatedColumnNumber;

public class Pawn extends ChessPiece implements IChessMoves {

    private final int pointCount = 1;
    private boolean isFirstMove = false;

    public Pawn(){}

    public int getPointCount() {return pointCount;}

    public Pawn(char columnCoordinate, int rowCoordinate, PieceName pieceName, BoardTile.color color) {
        super(columnCoordinate, rowCoordinate, pieceName, color);
    }

    public boolean isMoveValid(char currentColumnCoord, int currentRowCoord, char desiredColumnCoord, int desiredRowCoord, ChessBoard board)
    {
        //first check if there is a diagonal of opposite color. if so it can move forward 1/2 or diagonal l/r 1 depending on if 1 or 2 are in front
        //also need to check if the vertical move is blocked in either the 1/2 square move

        //if (board.getPieceLocator().get()

        int columnNum = getTranslatedColumnNumber(currentColumnCoord);
        String stringifiedCurrentCoord = currentColumnCoord + Integer.toString(currentRowCoord);
        //TODO this doesnt do anything but the accessors are in place
        if (board.getPieceLocator().get(stringifiedCurrentCoord) != null)
        {

        }

        if (isFirstMove)
        {
            //going to be on row 2/7. can only move two spots vertical max. alter isFirstMove. needs to check for cap/block
            if(getColor() == BoardTile.color.BLACK)
            {
                //7
                
            }
            else
            {
                //2

            }
        }
        else
        {

        }
        return false;
    }
    public void movePiece(char currentColumnCoord, int currentRowCoord, char desiredColumnCoord, int desiredRowCoord){}
}
