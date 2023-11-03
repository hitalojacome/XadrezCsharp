using System;
using chess;
using chessboard;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try 
            {
                ChessGame game = new ChessGame();

                Screen.printChessboard(game.board);
            }
            catch (ChessException e)
            {
                Console.WriteLine(e.Message);
            }            
        }
    }
}