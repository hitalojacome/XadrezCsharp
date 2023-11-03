using chessboard;

namespace chess
{
    public class ChessGame
    {
        public Chessboard board { get;  private set; }
        private int turn;
        private Color currentPlayer;

        public ChessGame()
        {
            board = new Chessboard(8, 8);
            turn = 1;
            currentPlayer = Color.White;
        }

        public void ExecuteMoviment(Position origin, Position destination)
        {
            Piece p = board.RemovePiece(origin);
            p.SetMoveCount();
            Piece CapturedPiece = board.RemovePiece(destination);
            board.PlacePiece(p, destination);
        }

        private void AddPieces()
        {
            board.PlacePiece(new Rook(board, Color.White), new ChessPosition('C',1).toPosition());
        }
    }
}