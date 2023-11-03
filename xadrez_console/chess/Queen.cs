using chessboard;

namespace chess
{
    public class Queen : Piece
    {
        public Queen(Chessboard board, Color color) : base(board, color) {}

        public override string ToString()
        {
            return "Q";
        }
    }
}