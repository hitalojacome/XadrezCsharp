using chessboard;

namespace chess
{
    public class Rook : Piece // A peça torre herda da classe peça
    {
        public Rook(Chessboard board, Color color) : base(board, color) {} // Construtor herdando o já criado na classe Piece


        public override string ToString() // Método para imprimir sua representação como 'T'
        {
            return "T";
        }
    }
}