using System;
using chess;
using chessboard;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            ChessPosition pos = new ChessPosition('C', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosition());

            try 
            {
                Chessboard board = new Chessboard(8,8);
                board.PlacePiece(new Rook(board, Color.Black), new Position(0,0));
                board.PlacePiece(new Rook(board, Color.Black), new Position(1,3));
                board.PlacePiece(new King(board, Color.Black), new Position(0,2));

                Screen.printChessboard(board);
            }
            catch (ChessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}