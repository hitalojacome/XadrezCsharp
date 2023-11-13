using System;
using chess;
using chessboard;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            
            try 
            {
                ChessMatch match = new ChessMatch();
                Screen.PrintChessboard(match.Board);
            }
            catch (ChessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}