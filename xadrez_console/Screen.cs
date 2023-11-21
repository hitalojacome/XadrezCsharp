using System;
using chessboard;
using chess;

namespace xadrez_console
{
    // Responsável pela visualização do tabuleiro
    class Screen
    {
        // Método imprime a partida
        public static void PrintMatch(ChessMatch match)
        {
            PrintChessboard(match.Board);
            Console.WriteLine();
            if(match.Turn > 1)
            {
                PrintCapturedPieces(match);
            }
            Console.WriteLine($"Turn: {match.Turn}");
            Console.WriteLine($"Awaiting Move: {match.CurrentPlayer}");
        }

        // Método imprime todas as peças capturadas
        public static void PrintCapturedPieces(ChessMatch match)
        {
            Console.WriteLine("Captured pieces:");
            Console.Write("White: ");
            PrintSet(match.CapturedPieces(Color.White));
            Console.WriteLine();
            Console.Write("Black: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintSet(match.CapturedPieces(Color.Black));
            Console.ForegroundColor = aux;
            Console.WriteLine();
            Console.WriteLine();
        }

        // Lógicas para imprimir o conjunto de peças caputradas
        public static void PrintSet(HashSet<Piece> set)
        {
            Console.Write("[");
            foreach(Piece piece in set)
            {
                Console.Write($"{piece}, ");
            }
            Console.Write("]");
        }

        public static void PrintChessboard(Chessboard board)
        {
            for(int i=0; i<board.Lines; i++) 
            {
                Console.Write($"{8-i} ");
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

            for (int i=0; i<board.Lines; i++) 
            {
                Console.Write($"{8-i} ");
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
            int line = int.Parse($"{s[1]}");
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