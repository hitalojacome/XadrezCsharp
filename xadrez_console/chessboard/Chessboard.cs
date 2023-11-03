namespace chessboard
{
    public class Chessboard
    {
        public int lines { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Chessboard(int lines, int columns) {
            this.lines = lines;
            this.columns = columns;
            pieces = new Piece[lines, columns];
        }

        public Piece piece(int line, int column) {
            return pieces[line, column];
        }
    }
}