using chessboard;

namespace chess
{
    public class King : Piece
    {
        public King(Chessboard board, Color color) : base(board, color) {}

        public override string ToString()
        {
            return "R";
        }
    }
}