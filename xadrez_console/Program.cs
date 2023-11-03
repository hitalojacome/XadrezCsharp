using System;
using chess;
using chessboard;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try 
            {
                Chessboard board = new Chessboard(8,8);
                board.PlacePiece(new Rook(board, Color.Black), new Position(0,0));
                board.PlacePiece(new Rook(board, Color.Black), new Position(1,3));
                board.PlacePiece(new King(board, Color.Black), new Position(0,9));

                Screen.printChessboard(board);
            }
            catch (ChessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}