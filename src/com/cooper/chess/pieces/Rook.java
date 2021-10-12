package com.cooper.chess.pieces;

import com.cooper.chess.BoardTile;
import com.cooper.chess.ChessBoard;
import com.cooper.chess.IChessMoves;

public class Rook extends ChessPiece implements IChessMoves {

    private final int pointCount = 5;

    public Rook(){}

    public int getPointCount() {return pointCount;}

    public Rook(char columnCoordinate, int rowCoordinate, PieceName pieceName, BoardTile.color color) {
        super(columnCoordinate, rowCoordinate, pieceName, color);
    }

    public boolean isMoveValid(char currentColumnCoord, int currentRowCoord, char desiredColumnCoord, int desiredRowCoord, ChessBoard board)
    {

        return false;
    }
    public void movePiece(char currentColumnCoord, int currentRowCoord, char desiredColumnCoord, int desiredRowCoord){}
}
