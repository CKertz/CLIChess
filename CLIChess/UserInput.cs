using CLIChess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIChess
{
    public class UserInput
    {
        private static int moveCount = 0;
        private static bool gameOver = false;
        private static bool isWhiteMove = false;

        //TODO: probably a less repetitive way to go about this. ALSO plenty of non-basic moves
        // that will need to be considered valid later on. https://www.chesshouse.com/blogs/education/how-to-read-and-write-algebraic-chess-notation#:~:text=Chess%20Notation%20describes%20each%20move,K%E2%80%9D%2C%20which%20is%20King.
        private static char[] validLeadingTokens = new char[]
        {
            'Q','R','N','K','B', //pieces
            'a','b','c','d','e','f','g','h' //xCoord (for pawn moves)
        };
        private static char[] validSecondTokens = new char[]
        {
            'x', //capture
            'a','b','c','d','e','f','g','h', //xCoord (non-pawn moves)
            '1','2','3','4','5','6','7','8' //yCoord pawn moves 
        };
        private static char[] validThirdTokens = new char[]
        {
            'a','b','c','d','e','f','g','h', //capture moves
            '1','2','3','4','5','6','7','8' //yCoord moves (non-pawn)
        };
        private static char[] validFourthTokens = new char[]
        {
            '1','2','3','4','5','6','7','8'
        };
        private static char[][] validTokenSet = new char[][]
        {
            validLeadingTokens,
            validSecondTokens,
            validThirdTokens,
            validFourthTokens
        };
        public bool PlayGame(List<BoardTile> chessBoard)
        {
            Console.WriteLine("New game is ready.");
            while(!gameOver)
            {
                string teamToMove = isWhiteMove ? "White" : "Black";
                Console.WriteLine("Your move, " + teamToMove);
                var res = Console.ReadLine();
                if(IsValidUserInput(res))
                {
                    //attempt to issue move
                    IssueMove(res, isWhiteMove,chessBoard);
                }
            }
            Console.WriteLine("Game over in " + moveCount + "moves");
            return true;
        }

        public void IssueMove(string requestedMove, bool isWhiteMove, List<BoardTile> chessBoard)
        {
            //peek first token to determine what piece is attempting to move.
            //verify the correct team is moving it and let the piece logic handle from there
            //see last 2 tokens for desired x/y coords, 
            char[] parsedMove = requestedMove.ToCharArray();
            var tile = chessBoard.Where(x => (x.XCoordinate == parsedMove.Last() - 1) && (x.YCoordinate == parsedMove.Last())).FirstOrDefault();
            
            tile.OccupyingPiece.Move(chessBoard, parsedMove.ElementAt(parsedMove.Last()-1), parsedMove.Last());
            //switch (parsedMove[0])
            //{
            //    case 'R':
            //        break;
            //    case 'K':
            //        break;
            //    case 'Q':
            //        break;
            //    case 'B':
            //        break;
            //    case 'N':
            //        break;
            //    default:
            //        //pawn, castles, ...
            //        break;
            //}
        }

        private bool IsValidUserInput(string requestedMove) //e4, Rxh5, Ba2
        {
            if(string.IsNullOrEmpty(requestedMove))
            {
                Console.WriteLine("input is empty, try again");
                return false;
            }
            if(requestedMove.Length > validTokenSet.Length) 
            {
                Console.WriteLine("please stop that");
                return false;
            }
            var tokens = requestedMove.ToCharArray();

            for(int i = 0; i < tokens.Length; i++) 
            {
                if(IsLeadingTokenAcceptable(tokens[i],validTokenSet[i]))
                {
                    if (i == tokens.Length - 1)
                    {
                        moveCount++;
                        return true;
                    }                  
                }
            }               
            return false;
        }

        private static bool IsLeadingTokenAcceptable(char leadingToken, char[] tokenSet)
        {           
            foreach (char acceptableToken in tokenSet)
            {
                if (leadingToken == acceptableToken)
                {
                    //Console.WriteLine(leadingToken + "is ok for token set");
                    return true;
                }
            }
            return false;
        }
    }
}
