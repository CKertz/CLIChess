package com.cooper.chess;


import com.cooper.chess.pieces.ChessPiece;
import com.cooper.chess.pieces.Pawn;

import java.util.*;

import static com.cooper.chess.setup.BoardSetupHelper.setupChessPieces;
import static com.cooper.chess.setup.BoardSetupHelper.setupTiles;

public class Main {

    private static ChessBoard chessBoard = new ChessBoard();
    private static List<ChessPiece> pieceList = new ArrayList<ChessPiece>();
    private static List<BoardTile> tileList = new ArrayList<BoardTile>();

    private static HashMap<String,ChessPiece> pieceLocator = new HashMap<>();

    public static void main(String[] args) {

        initializeGame();
    }

    public static void initializeGame()
    {
        System.out.println("Setting up a new game...");
        setupTiles(tileList);
        chessBoard.setTileList(tileList);

        setupChessPieces(chessBoard,pieceList,pieceLocator);
        chessBoard.setPieceList(pieceList);
        chessBoard.setPieceLocator(pieceLocator);
        System.out.println("Game ready");

        playGame();
    }

    public static void playGame()
    {
        boolean isGameOver = false;
        Scanner scanner = new Scanner(System.in);
        System.out.println("Choose a side. Enter W for White, or B for Black");
        String sideChoice = scanner.nextLine();

        if(sideChoice == "W"|| sideChoice == "w")
        {
            System.out.println("You chose White, so you go first. Make a move");
        }
        while (!isGameOver)
        {
        makeMove(scanner);
        }

    }

    public static void makeMove(Scanner scanner)
    {
        String nextMove = scanner.nextLine();
        ChessPiece pieceToMove = new ChessPiece();
        char pieceAbbreviated = nextMove.charAt(0);

        if(pieceAbbreviated != 'P')
        {
            System.out.println("Invalid input, try again");
            return;
        }
        switch(pieceAbbreviated)
        {
            case 'P':
                //just a basic test case while I piece this workflow out
                new Pawn().movePiece('a',2,'c',2);
        }
    }

}
