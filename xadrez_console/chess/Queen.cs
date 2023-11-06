using chessboard;

namespace chess
{
    /* A Queen herda da classe peça
    Representação da rainha no xadrez*/
    public class Queen : Piece
    {
        public Queen(Chessboard board, Color color) : base(board, color) {}

        // Queen é exibido como 'Q'
        public override string ToString()
        {
            return "Q";
        }
    }
}