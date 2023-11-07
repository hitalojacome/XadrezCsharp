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
                // Apresentação das linhas
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
                        // Imprime a representação da peça acessada na classe Piece do objeto board
                        PrintPiece(board.Piece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            // Apresentação das colunas
            Console.WriteLine("   A B C D E F G H");

        }

        // Método estático para impressão personalizada das peças
        public static void PrintPiece(Piece piece)
        {
            // SE a cor da peça for branca
            if (piece.Color == Color.White)
            {   
                // Mostre-a
                Console.Write(piece);
            }
            else  // SE NÃO
            {
                
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;

            }
        }
    }
}