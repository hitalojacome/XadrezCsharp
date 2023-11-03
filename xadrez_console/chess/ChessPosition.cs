using chessboard;

namespace chess
{
    // Classe criada para simplificar a visualização das posições, dando mais sentido ao contexto do xadrez
    public class ChessPosition
    {
        public char column { get; set; }
        public int line { get; set; }

        public ChessPosition(char column, int line)
        {
            this.column = column;
            this.line = line;
        }
        
        public Position toPosition() // Responsável por converter uma posição em notação de xadrez para uma instância da classe Position
        {
            return new Position(8 - line, column - 'A'); // Esta linha realiza a conversão da posição em notação de xadrez para uma representação interna.

            /* 
                8 - line: A variável line contém um valor numérico que representa a linha em notação de xadrez (por exemplo, 1 a 8). A subtração de 8 - line é usada para converter a notação de xadrez para um índice de matriz, onde a linha 1 em notação de xadrez se torna 7 (índice de matriz 0) e a linha 8 em notação de xadrez se torna 0 (índice de matriz 7).
                column - 'A': A variável column contém uma letra representando a coluna em notação de xadrez (de 'A' a 'H'). A subtração column - 'A' é usada para converter a notação de xadrez em um índice de matriz para colunas, onde 'A' se torna 0, 'B' se torna 1, e assim por diante.
            */
        }
        public override string ToString()
        {
            return $"{column}{line}";
        }
    }
}