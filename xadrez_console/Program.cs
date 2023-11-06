using System;
using chess;
using chessboard;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            Chessboard board = new(8,8);

            Screen.PrintChessboard(board);
        }
    }
}