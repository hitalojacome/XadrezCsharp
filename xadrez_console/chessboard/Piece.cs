namespace chessboard
{
    public class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int moveCount { get; protected set; }
        public Chessboard board { get; protected set; }

        public Piece(Chessboard board, Color color) {
            this.position = null;
            this.board = board;
            this.color = color;
            this.moveCount = 0;
        }
    }
}