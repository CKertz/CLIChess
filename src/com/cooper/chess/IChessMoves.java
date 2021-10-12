package com.cooper.chess;

public interface IChessMoves{
    public boolean isMoveValid(char currentColumnCoord, int currentRowCoord, char desiredColumnCoord, int desiredRowCoord, ChessBoard board);
    public void movePiece(char currentColumnCoord, int currentRowCoord, char desiredColumnCoord, int desiredRowCoord);
}
