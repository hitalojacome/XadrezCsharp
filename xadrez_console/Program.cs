using System;
using chess;
using chessboard;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            
            try 
            {
                Chessboard board = new Chessboard(8,8);

                board.InsertPiece(new King(board, Color.Black), new Position(0,0));                
                board.InsertPiece(new King(board, Color.Black), new Position(0,1));
                board.InsertPiece(new King(board, Color.Black), new Position(0,2));

                Screen.PrintChessboard(board);          
            }
            catch (ChessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}