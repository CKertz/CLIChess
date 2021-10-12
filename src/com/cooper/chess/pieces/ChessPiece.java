package com.cooper.chess.pieces;

import com.cooper.chess.BoardTile;

public class ChessPiece {
    public enum PieceName{
        PAWN,
        BISHOP,
        KNIGHT,
        ROOK,
        QUEEN,
        KING
    }
    private int startingPieceCount;
    private int pointValue;
    private char columnCoordinate;
    private int rowCoordinate;
    private PieceName pieceName;
    private BoardTile.color color;

    public ChessPiece() {
    }

    public ChessPiece(char columnCoordinate, int rowCoordinate, PieceName pieceName, BoardTile.color color) {
        this.columnCoordinate = columnCoordinate;
        this.rowCoordinate = rowCoordinate;
        this.pieceName = pieceName;
        this.color = color;
    }

    //    public  boolean Move(String startCoordinates, String endCoordinates);
//    public  boolean isMoveValid();

    public char getColumnCoordinate() {
        return columnCoordinate;
    }

    public void setColumnCoordinate(char columnCoordinate) {
        this.columnCoordinate = columnCoordinate;
    }

    public int getRowCoordinate() {
        return rowCoordinate;
    }

    public void setRowCoordinate(int rowCoordinate) {
        this.rowCoordinate = rowCoordinate;
    }

    public int getPieceCount() {
        return startingPieceCount;
    }

    public void setPieceCount(int pieceCount) {
        this.startingPieceCount = pieceCount;
    }

    public int getPointValue() {
        return pointValue;
    }

    public void setPointValue(int pointValue) {
        this.pointValue = pointValue;
    }

    public int getStartingPieceCount() {
        return startingPieceCount;
    }

    public void setStartingPieceCount(int startingPieceCount) {
        this.startingPieceCount = startingPieceCount;
    }

    public PieceName getPieceName() {
        return pieceName;
    }

    public void setPieceName(PieceName pieceName) {
        this.pieceName = pieceName;
    }

    public BoardTile.color getColor() {
        return color;
    }

    public void setColor(BoardTile.color color) {
        this.color = color;
    }
}
