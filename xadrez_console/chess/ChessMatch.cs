using chessboard;

namespace chess
{
    public class ChessMatch
    {
        public Chessboard Board { get; private set; }
        private int _turn;
        private Color _currentPlayer;
        public bool GameOver { get; private set; }

        // Inicia uma partida de xadrez
        public ChessMatch()
        {
            // Cria um tabuleiro 8x8
            Board = new Chessboard(8,8);
            // Inicia o turno com 1
            _turn = 1;
            // O jodaor   inicial é o das peças brancas
            _currentPlayer = Color.White;
            // Partida inicia com o 'GameOver' falso
            GameOver = false;
            // Método para inserção de peça
            SetupPieces();
        }

        // Método para a execução dos movimentos, ele recebe a posição atual da peça, e a que deseja mover
        public void ExecuteMove(Position origin, Position destination)
        {
            // Remove a peça da posição atual
            Piece piece = Board.RemovePiece(origin);
            // Incrementa o movimento
            piece.SetMoveCount();
            // Remove a peça do destino (se existir) e armazena na variavel 'capturedPiece'
            Piece capturedPiece = Board.RemovePiece(destination);
            // Por fim, coloca a peça na posição desejada
            Board.InsertPiece(piece, destination);
        }

        // Método para inserção de peças, assim, não se insere as peças no program e já se inicia o tabuleiro
        private void SetupPieces()
        {
            // Peças brancas
            Board.InsertPiece(new Rook(Board, Color.White), new ChessPosition('C', 1).ToPosition());
            Board.InsertPiece(new Rook(Board, Color.White), new ChessPosition('C', 2).ToPosition());
            Board.InsertPiece(new Rook(Board, Color.White), new ChessPosition('D', 2).ToPosition());
            Board.InsertPiece(new Rook(Board, Color.White), new ChessPosition('E', 2).ToPosition());
            Board.InsertPiece(new Rook(Board, Color.White), new ChessPosition('E', 1).ToPosition());
            Board.InsertPiece(new King(Board, Color.White), new ChessPosition('D', 1).ToPosition());

            // Peças pretas
            Board.InsertPiece(new Rook(Board, Color.Black), new ChessPosition('C', 7).ToPosition());
            Board.InsertPiece(new Rook(Board, Color.Black), new ChessPosition('C', 8).ToPosition());
            Board.InsertPiece(new Rook(Board, Color.Black), new ChessPosition('D', 7).ToPosition());
            Board.InsertPiece(new Rook(Board, Color.Black), new ChessPosition('E', 7).ToPosition());
            Board.InsertPiece(new Rook(Board, Color.Black), new ChessPosition('E', 8).ToPosition());
            Board.InsertPiece(new King(Board, Color.Black), new ChessPosition('D', 8).ToPosition());
        }
    }
}