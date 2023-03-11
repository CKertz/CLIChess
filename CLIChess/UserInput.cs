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
        public bool PlayGame()
        {
            while(!gameOver)
            {
                Console.WriteLine("Enter a valid move");
                var res = Console.ReadLine();
                if(IsValidUserInput(res))
                {
                    //attempt to issue move
                    IssueMove(res);
                }
            }
            Console.WriteLine("Game over in " + moveCount + "moves");
            return true;
        }

        public void IssueMove(string requestedMove)
        {

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
