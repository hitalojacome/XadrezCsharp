namespace chess
{
    // Classe que irá personalizar as posições do tabuleiro conforme as posições reais do xadrez
    public class  ChessPosition
    {
        public char Column { get; set; }
        public int Line { get; set; }
 
        public ChessPosition(char column, int line)
        {
            Column = column;
            Line = line;
        }

        public override string ToString()
        {
            return $"{Column}{Line}";
        }
    }
}