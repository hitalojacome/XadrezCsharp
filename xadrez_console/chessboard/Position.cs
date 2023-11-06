namespace chessboard
{
    // Responsável pela posição no tabuleiro
    public class Position
    {
        // A posição é composta por linha e coluna
        public int Line { get; set; }
        public int Column { get; set; }

        public Position(int line, int column)
        {
            Line = line;
            Column = column;
        }

        // Método para impressão da posição
        public override string ToString() 
        {
            return $"{Line}, {Column}";
        }
    }
}