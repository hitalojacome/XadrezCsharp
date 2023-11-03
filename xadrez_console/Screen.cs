using System;
using chessboard;

namespace xadrez_console
{
    class Screen // Responsável pela visualização
    {
        public static void printChessboard(Chessboard board) // Método estático para imprimir o tabuleiro
        {

            for(int i=0; i<board.lines; i++) {
                for(int j=0; j<board.columns; j++) {
                    if(board.Piece(i,j) == null) {
                        Console.Write("- "); // Imprime um hífen para espaços vaziox
                    } else { 
                        Console.Write($"{board.Piece(i,j)} "); // Imprime a representação da peça 
                    }
                }
                Console.WriteLine();
            }

        }
    }
}