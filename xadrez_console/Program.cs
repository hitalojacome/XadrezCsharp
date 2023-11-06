using System;
using chess;
using chessboard;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            try {
                Chessboard board = new(8,8);

                board.InsertPiece(new Rook(board, Color.Black), new Position(0,0));
                board.InsertPiece(new Rook(board, Color.Black), new Position(1,3));
                board.InsertPiece(new King(board, Color.Black), new Position(0,1));

                Screen.PrintChessboard(board);
            }
            catch(ChessException e) // Tratamento de erros
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}