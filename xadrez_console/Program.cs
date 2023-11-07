using System;
using chess;
using chessboard;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            
            ChessPosition position = new ChessPosition('A', 1);

            Console.WriteLine(position);
        }
    }
}