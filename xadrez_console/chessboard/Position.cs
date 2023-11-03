namespace chessboard
{
    public class Position
    {
        public int line { get; set; } // atributo linha
        public int column { get; set; } // atributo coluna

        public Position(int line, int column) // Construtor recebendo linha e coluna
        {
            this.line = line;
            this.column = column;
        }

        public override string ToString() // Método para impressão da posição
        {
            return $"{line}, {column}";
        }
    }
}