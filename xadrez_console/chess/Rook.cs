using chessboard;

namespace chess
{
    public class Rook : Piece
    {
        public Rook(Chessboard board, Color color) : base(board, color) {}

        public override string ToString()
        {
            return "T";
        }
    }
}