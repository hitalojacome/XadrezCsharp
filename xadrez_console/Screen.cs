using System;
using chessboard;

namespace xadrez_console
{
    // Responsável pela visualização do tabuleiro
    class Screen
    {
        // Método estático para imprimir o tabuleiro
        public static void PrintChessboard(Chessboard board)
        {
            // Percorre as linhas da matriz
            for(int i=0; i<board.Lines; i++) {
                Console.Write($"{8-i}  ");
                // Percorre as colunas da matriz
                for(int j=0; j<board.Columns; j++) {
                    // SE a localização i,j da matriz estiver vazia
                    if(board.Piece(i,j) == null) {
                        // Imprima um hífen para espaços vazios
                        Console.Write("- ");
                    } 
                    // SE NÃO
                    else 
                    { 
                        // Faz a impressão da peça conforme o método PrintPiece 
                        PrintPiece(board.Piece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            // Apresentação das colunas
            Console.WriteLine("   A B C D E F G H");

        }

        // Método estático para impressão de peça com cor personalizada
        public static void PrintPiece(Piece piece)
        {
            // Se for branca somente imprima
            if (piece.Color == Color.White)
            {
                Console.Write(piece);
            }
            else 
            {
                // Váriavel do tipo ConsoleColor que pega a cor atual do console (ForegroundColor)
                ConsoleColor aux = Console.ForegroundColor;
                // Altera a cor para Yellow
                Console.ForegroundColor = ConsoleColor.Yellow;
                // Imprime a peça amarela
                Console.Write(piece);
                // Volta para a cor inicial
                Console.ForegroundColor = aux;

            }
        }
    }
}