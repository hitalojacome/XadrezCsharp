namespace chessboard
{
    public class Piece
    {
        public Position position { get; set; } // Atributo do tipo da classe Position
        public Color color { get; protected set; } // Atributo do tipo enum de Color
        public int moveCount { get; protected set; } // Armazena q quantidade de movimentos
        public Chessboard board { get; protected set; } // Atributo do tipo da classe Chessboard

        public Piece(Chessboard board, Color color) // Construtor para instanciação
        {
            this.position = null; // Posição inicia sem valor
            this.board = board; // Recebe o tabuleiro passado no argumento
            this.color = color; // Recebe a cor passada conforme o enum
            this.moveCount = 0; // Contador se incia com 0
        }
    }
}