package com.cooper.chess.setup;

import com.cooper.chess.BoardTile;
import com.cooper.chess.ChessBoard;
import com.cooper.chess.pieces.*;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;

public class BoardSetupHelper {
    private static ArrayList<Character> possibleColumns = new ArrayList<>(Arrays.asList('a','b','c','d','e','f','g','h'));

    public static void setupChessPieces(ChessBoard board,List<ChessPiece> pieceList, HashMap<String,ChessPiece> pieceLocator)
    {
        setupKings(board,pieceList, pieceLocator);
        setupBishops(board,pieceList, pieceLocator);
        setupQueens(board,pieceList, pieceLocator);
        setupRooks(board,pieceList, pieceLocator);
        setupKnights(board,pieceList, pieceLocator);
        setupPawns(board,pieceList, pieceLocator);
    }

    public static int getTranslatedColumnNumber(char columnCoord)
    {
        for (Character c:possibleColumns)
        {
            if (c == columnCoord)
                return possibleColumns.indexOf(c);
        }
        return 0;
    }

    public static void setupTiles(List<BoardTile> tileList)
    {
        System.out.println("Initializing board tiles");

        for(int i = 1; i <= 8; i++)
        {
            for(int j = 1; j <=8; j++)
            {
                BoardTile newTile = new BoardTile();
                newTile.setColumnCoordinate(possibleColumns.get(j-1));
                newTile.setRowCoordinate(i);
                if(j%2 ==0)
                {
                    newTile.setTileColor(BoardTile.color.WHITE);
                }
                else
                {
                    newTile.setTileColor(BoardTile.color.BLACK);
                }
                tileList.add(newTile);
                //System.out.println("Tile created with color:"+newTile.getTileColor()+ " on tile " + newTile.getColumnCoordinate()+newTile.getRowCoordinate());
            }
        }
    }

    public static void setupPawns(ChessBoard board,List<ChessPiece> pieceList, HashMap<String,ChessPiece> pieceLocator)
    {
        for(int i = 1; i <= 8; i++)
        {
            setupChessPiece(7,possibleColumns.get(i-1), ChessPiece.PieceName.PAWN, BoardTile.color.BLACK,pieceList, pieceLocator);
            setTilePieceOccupied(board.getTileList(),7,possibleColumns.get(i-1));

            setupChessPiece(2,possibleColumns.get(i-1), ChessPiece.PieceName.PAWN, BoardTile.color.WHITE,pieceList, pieceLocator);
            setTilePieceOccupied(board.getTileList(),2,possibleColumns.get(i-1));
        }
    }
    public static void setupBishops(ChessBoard board,List<ChessPiece> pieceList, HashMap<String,ChessPiece> pieceLocator)
    {
        setupChessPiece(1,'c', ChessPiece.PieceName.BISHOP, BoardTile.color.WHITE,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),1,'c');

        setupChessPiece(1,'f', ChessPiece.PieceName.BISHOP, BoardTile.color.WHITE,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),1,'f');

        setupChessPiece(8,'c', ChessPiece.PieceName.BISHOP, BoardTile.color.BLACK,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),8,'c');

        setupChessPiece(8,'f', ChessPiece.PieceName.BISHOP, BoardTile.color.BLACK,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),8,'f');


    }
    public static void setupRooks(ChessBoard board,List<ChessPiece> pieceList, HashMap<String,ChessPiece> pieceLocator)
    {
        setupChessPiece(1,'a', ChessPiece.PieceName.ROOK, BoardTile.color.WHITE,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),1,'a');

        setupChessPiece(1,'h', ChessPiece.PieceName.ROOK, BoardTile.color.WHITE,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),1,'h');

        setupChessPiece(8,'a', ChessPiece.PieceName.ROOK, BoardTile.color.BLACK,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),8,'a');

        setupChessPiece(8,'h', ChessPiece.PieceName.ROOK, BoardTile.color.BLACK,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),8,'h');


    }
    public static void setupKnights(ChessBoard board,List<ChessPiece> pieceList, HashMap<String,ChessPiece> pieceLocator)
    {
        setupChessPiece(1,'b', ChessPiece.PieceName.KNIGHT, BoardTile.color.WHITE,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),1,'b');

        setupChessPiece(1,'g', ChessPiece.PieceName.KNIGHT, BoardTile.color.WHITE,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),1,'g');

        setupChessPiece(8,'b', ChessPiece.PieceName.KNIGHT, BoardTile.color.BLACK,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),8,'b');

        setupChessPiece(8,'g', ChessPiece.PieceName.KNIGHT, BoardTile.color.BLACK,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),8,'g');


    }
    public static void setupQueens(ChessBoard board,List<ChessPiece> pieceList, HashMap<String,ChessPiece> pieceLocator)
    {
        setupChessPiece(1,'d', ChessPiece.PieceName.QUEEN, BoardTile.color.WHITE,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),1,'d');

        setupChessPiece(8,'d', ChessPiece.PieceName.QUEEN, BoardTile.color.BLACK,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),8,'d');

    }
    public static void setupKings(ChessBoard board,List<ChessPiece> pieceList, HashMap<String,ChessPiece> pieceLocator)
    {
        setupChessPiece(1,'e', ChessPiece.PieceName.KING, BoardTile.color.WHITE,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),1,'e');

        setupChessPiece(8,'e', ChessPiece.PieceName.KING, BoardTile.color.BLACK,pieceList, pieceLocator);
        setTilePieceOccupied(board.getTileList(),8,'e');

    }
    public static void setupChessPiece(int rowCoordinate, char columnCoordinate, ChessPiece.PieceName pieceType, BoardTile.color color,List<ChessPiece> pieceList,HashMap<String,ChessPiece> pieceLocator )
    {

        switch(pieceType){
            case ROOK:
                ChessPiece newRook = new Rook(columnCoordinate,rowCoordinate,pieceType,color);
                pieceList.add(newRook);
                initializePieceLocator(pieceLocator,newRook,rowCoordinate,columnCoordinate);
                break;
            case BISHOP:
                ChessPiece newBishop = new Bishop(columnCoordinate,rowCoordinate,pieceType,color);
                pieceList.add(newBishop);
                initializePieceLocator(pieceLocator,newBishop,rowCoordinate,columnCoordinate);
                break;
            case KNIGHT:
                ChessPiece newKnight = new Knight(columnCoordinate,rowCoordinate,pieceType,color);
                pieceList.add(newKnight);
                initializePieceLocator(pieceLocator,newKnight,rowCoordinate,columnCoordinate);
                break;
            case KING:
                ChessPiece newKing = new King(columnCoordinate,rowCoordinate,pieceType,color);
                pieceList.add(newKing);
                initializePieceLocator(pieceLocator,newKing,rowCoordinate,columnCoordinate);
                break;
            case PAWN:
                ChessPiece newPawn = new Pawn(columnCoordinate,rowCoordinate,pieceType,color);
                pieceList.add(newPawn);
                initializePieceLocator(pieceLocator,newPawn,rowCoordinate,columnCoordinate);
                break;
            case QUEEN:
                ChessPiece newQueen = new Queen(columnCoordinate,rowCoordinate,pieceType,color);
                pieceList.add(newQueen);
                initializePieceLocator(pieceLocator,newQueen,rowCoordinate,columnCoordinate);
                break;
        }
    }
    public static void setTilePieceOccupied(List<BoardTile> board, int rowCoord, char columnCoord)
    {

        for (int i = 0; i < board.size(); i++)
        {
            if (board.get(i).getColumnCoordinate() == columnCoord && board.get(i).getRowCoordinate() == rowCoord)
            {
                board.get(i).setOccupied(true);
                System.out.println("tile at " + columnCoord + rowCoord + " set to true");
            }
        }
    }

    public static void initializePieceLocator(HashMap<String,ChessPiece> pieceLocator, ChessPiece chessPiece, int rowCoord, char columnCoord)
    {
        String coord = "";
        coord += columnCoord + Integer.toString(rowCoord);
        pieceLocator.put(coord,chessPiece);
    }
}
