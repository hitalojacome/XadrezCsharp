using chessboard;

namespace chess
{
    public class King : Piece // A peça rei herda da classe peça
    {
        public King(Chessboard board, Color color) : base(board, color) {} // Construtor herdando o já criado na classe Piece

        public override string ToString() // Método para imprimir sua representação como 'R'
        {
            return "R";
        }
    }
}