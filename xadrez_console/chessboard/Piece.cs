namespace chessboard
{
    // Responsável pela peça em si
    abstract class Piece
    {
        // Peça tem uma posição | composição
        public Position Position { get; set; } 
        // Tipo enum de Color
        public Color Color { get; protected set; } 
        // Quantidade de movimentos
        public int MoveCount { get; protected set; }
        // Peça está em um tabuleiro | composição
        public Chessboard Board { get; protected set; }

        public Piece(Chessboard board, Color color)
        {
            // A classe tabuleiro tem o método para inserção de peças, então no construtor da peça a posição se inicia nula
            Position = null; 
            Board = board;
            Color = color;
            MoveCount = 0; // Por se iniciar com 0 não passa como parametro
        }
        
        // Método para incrementação em cada movimento
        public void SetMoveCount() {
            MoveCount++;
        }

        // Método abstrato não pode ser instanciado na classe pai
        // Cria uma matriz booleana
        public abstract bool[,] PossibleMoves();
    }
}