using chessboard;

namespace chess
{
    // Classe que irá personalizar as posições do tabuleiro conforme as posições reais do xadrez
    class ChessPosition
    {
        public char Column { get; set; }
        public int Line { get; set; }
 
        public ChessPosition(char column, int line)
        {
            Column = column;
            Line = line;
        }

        // Responsável pela conversão de uma posição interna de matriz para uma posição de um tabuleiro de xadrez (mat- 0,0 = tab- A,1)
        public Position ToPosition() {
            return new Position(8 - Line, char.ToLower(Column) - 'a');
        }

        public override string ToString()
        {
            return $"{Column}{Line}";
        }
    }
}