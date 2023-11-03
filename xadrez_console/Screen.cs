using System;
using chessboard;

namespace xadrez_console
{
    class Screen // Responsável pela visualização
    {
        public static void printChessboard(Chessboard board) // Método estático para imprimir o tabuleiro
        {

            for(int i=0; i<board.lines; i++) {
                Console.Write($"{8-i}  ");
                for(int j=0; j<board.columns; j++) {
                    if(board.Piece(i,j) == null) {
                        Console.Write("- "); // Imprime um hífen para espaços vaziox
                    } else { 
                        Screen.printPiece(board.Piece(i, j)); // Imprime a representação da peça 
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("   A B C D E F G H");

        }

        public static void printPiece(Piece piece)
        {
            if (piece.color == Color.White)
            {
                Console.Write(piece);
            }
            else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;

            }
        }
    }
}