package com.cooper.chess.pieces;

import com.cooper.chess.BoardTile;
import com.cooper.chess.ChessBoard;
import com.cooper.chess.IChessMoves;

public class King extends ChessPiece implements IChessMoves {

    private final int pointCount = 0;
    private boolean isInCheck = false;

    public King(){}

    public int getPointCount() {return pointCount;}

    public King(char columnCoordinate, int rowCoordinate, PieceName pieceName, BoardTile.color color) {
        super(columnCoordinate, rowCoordinate, pieceName, color);
    }

    public boolean isMoveValid(char currentColumnCoord, int currentRowCoord, char desiredColumnCoord, int desiredRowCoord, ChessBoard board)
    {

        return false;
    }
    public void movePiece(char currentColumnCoord, int currentRowCoord, char desiredColumnCoord, int desiredRowCoord){}
}
