package com.cooper.chess;

import com.cooper.chess.pieces.ChessPiece;

import java.util.HashMap;
import java.util.List;

public class ChessBoard {

    private List<BoardTile> tileList;
    private List<ChessPiece> pieceList;
    private HashMap<String,ChessPiece> pieceLocator = new HashMap<>();


    public ChessBoard()
    {

    };

    public List<BoardTile> getTileList() {
        return tileList;
    }

    public void setTileList(List<BoardTile> tileList) {
        this.tileList = tileList;
    }

    public List<ChessPiece> getPieceList() {
        return pieceList;
    }

    public void setPieceList(List<ChessPiece> pieceList) {
        this.pieceList = pieceList;
    }

    public HashMap<String, ChessPiece> getPieceLocator() {
        return pieceLocator;
    }

    public void setPieceLocator(HashMap<String, ChessPiece> pieceLocator) {
        this.pieceLocator = pieceLocator;
    }
}
