namespace chessboard
{
    // Responsável pela peça em si
    public class Piece
    {
        // Peça tem uma posição | composição
        public Position Position { get; set; } 
        // Tipo enum de Color
        public Color Color { get; protected set; } 
        // Quantidade de movimentos
        public int MoveCount { get; protected set; }
        // Peça está em um tabuleiro | composição
        public Chessboard Board { get; protected set; }

        public Piece(Position position, Chessboard board, Color color)
        {
            Position = position; // Posição inicia sem valor
            Board = board; // Recebe o tabuleiro passado no argumento
            Color = color; // Recebe a cor passada conforme o enum
            MoveCount = 0; // Por se iniciar com 0 não passa como parametro
        }

        public void SetMoveCount() {
            MoveCount++;
        }
    }
}