using System;
using chess;
using chessboard;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            
            try 
            {
                ChessMatch match = new();
                while (!match.GameOver)
                {
                    try
                    {
                        Console.Clear();
                        Screen.PrintMatch(match);

                        Console.WriteLine();
                        Console.Write("Origin: ");
                        Position origin = Screen.ReedChessPosition().ToPosition();
                        match.ValidateOriginPosition(origin);

                        bool[,] possiblePositions = match.Board.Piece(origin).PossibleMoves();

                        Console.Clear();
                        Screen.PrintChessboard(match.Board, possiblePositions);
                        
                        Console.WriteLine();
                        Console.Write("Destination: ");
                        Position destination = Screen.ReedChessPosition().ToPosition();
                        match.ValidateDestinationPosition(origin, destination);

                        match.MakePlay(origin, destination);
                    }
                    catch (ChessException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                        Console.Write("Press enter to play again");
                        Console.ReadLine();
                    }
                }
            }
            catch (ChessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}