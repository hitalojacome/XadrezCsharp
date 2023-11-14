using System;
using chess;
using chessboard;

namespace xadrez_console
{
    // Responsável pela visualização do tabuleiro
    class Screen
    {
        // Método estático para imprimir o tabuleiro
        public static void PrintChessboard(Chessboard board)
        {
            for(int i=0; i<board.Lines; i++) {
                Console.Write(8 - i + " ");
                for(int j=0; j<board.Columns; j++)
                {
                    PrintPiece(board.Piece(i, j));
                }
                Console.WriteLine();
            }
            // Apresentação das colunas
            Console.WriteLine("  A B C D E F G H");
        }

        // Sobrecarga para imprimir as posições possiveis da peça
        public static void PrintChessboard(Chessboard board, bool[,] possiblePositions)
        {
            // Guarda a cor original do console
            ConsoleColor originalBackground = Console.BackgroundColor;
            // Guarda uma cor alternativa
            ConsoleColor changedBackground = ConsoleColor.DarkGray;

            for (int i=0; i<board.Lines; i++) {
                Console.Write(8 - i + " ");
                for(int j=0; j<board.Columns; j++)
                {
                    if (possiblePositions[i,j])
                    {
                        Console.BackgroundColor = changedBackground;
                    }
                    else
                    {
                        Console.BackgroundColor = originalBackground;
                    }
                    PrintPiece(board.Piece(i, j));
                    Console.BackgroundColor = originalBackground;
                }
                Console.WriteLine();
            }
            // Apresentação das colunas
            Console.WriteLine("  A B C D E F G H");
            Console.BackgroundColor = originalBackground;
        }

        // Método responsável por ler a posição da peça
        public static ChessPosition ReedChessPosition()
        {
            // String s receberá o que o usuário inserir
            string s = Console.ReadLine()!;
            // Primeira posição da string é a representação da coluna
            char column = s[0];
            // Segunda posição da string é a representação da linha
            int line = int.Parse(s[1] + "");
            return new ChessPosition(column, line);
        }

        // Método estático para impressão de peça com cor personalizada
        public static void PrintPiece(Piece piece)
        {
            // Se a peça for nula
            if (piece == null)
            {
                // Imprima um hífen para espaços vazios
                Console.Write("- ");
            }
            else
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
                Console.Write(" ");
            }
        }
    }
}