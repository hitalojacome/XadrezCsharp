using System;
using chessboard;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            Chessboard board = new Chessboard(8,8);

            Screen.printChessboard(board);

        }
    }
}