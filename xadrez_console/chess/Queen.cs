using chessboard;

namespace chess
{
    public class Queen : Piece // A peça rainha herda da classe peça
    {
        public Queen(Chessboard board, Color color) : base(board, color) {} // Construtor herdando o já criado na classe Piece

 
        public override string ToString() // Método para imprimir sua representação como 'Q'
        {
            return "Q";
        }
    }
}