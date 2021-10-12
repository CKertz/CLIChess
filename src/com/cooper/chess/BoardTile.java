package com.cooper.chess;

import java.util.Arrays;
import java.util.HashSet;

public class BoardTile {
    private boolean isOccupied;
    private char columnCoordinate;
    private int rowCoordinate;
    private color tileColor;


    public enum color{
        BLACK,
        WHITE
    }
    public BoardTile()
    {
        isOccupied = false;
    };
    public BoardTile(char columnCoord, int rowCoord, color color)
    {
        isOccupied = true;
        columnCoordinate = columnCoord;
        rowCoordinate = rowCoord;
        tileColor = color;
    }

    public boolean isOccupied() {
        return isOccupied;
    }

    public void setOccupied(boolean occupied) {
        isOccupied = occupied;
    }

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

    public color getTileColor() {
        return tileColor;
    }

    public void setTileColor(color tileColor) {
        this.tileColor = tileColor;
    }
}
