using System;
using chess;
using chessboard;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            Chessboard board = new(8,8);

            board.InsertPiece(Rook, new Position(0,0));
            board.InsertPiece(Rook, new Position(1,3));
            board.InsertPiece(King, new Position(2,4));

            Screen.PrintChessboard(board);
        }
    }
}