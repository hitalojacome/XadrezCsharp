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
                    Console.Clear();
                    Screen.PrintChessboard(match.Board);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Position origin = Screen.ReedChessPosition().ToPosition();

                    // Conforme a origem informada, é validada suas possiveis posições e armazenadas em uma matriz
                    bool[,] possiblePositions = match.Board.Piece(origin).PossibleMoves();

                    Console.Clear();
                    Screen.PrintChessboard(match.Board, possiblePositions);
                    
                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Position destination = Screen.ReedChessPosition().ToPosition();

                    match.ExecuteMove(origin, destination);
                }
            }
            catch (ChessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}