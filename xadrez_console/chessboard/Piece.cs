namespace chessboard
{
    public class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int moveCount { get; protected set; }
        public Chessboard board { get; protected set; }

        public Piece(Position position, Chessboard board, Color color) {
            this.position = position;
            this.board = board;
            this.moveCount = 0;
        }
    }
}