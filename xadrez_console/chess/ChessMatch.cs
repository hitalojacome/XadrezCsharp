using chessboard;

namespace chess
{
    public class ChessMatch
    {
        private Chessboard _board;
        private int _turn;
        private Color _currentPlayer;

        // Inicia uma partida de xadrez
        public ChessMatch()
        {
            // Cria um tabuleiro 8x8
            _board = new Chessboard(8,8);
            // Inicia o turno com 1
            _turn = 1;
            // O jodaor inicial é o das peças brancas
            _currentPlayer = Color.White;
        }

        // Método para a execução dos movimentos, ele recebe a posição atual da peça, e a que deseja mover
        public void ExecuteMove(Position origin, Position destination)
        {
            // Remove a peça da posição atual
            Piece piece = _board.RemovePiece(origin);
            // Incrementa o movimento
            piece.SetMoveCount();
            // Remove a peça do destino (se existir) e armazena na variavel 'capturedPiece'
            Piece capturedPiece = _board.RemovePiece(destination);
            // Por fim, coloca a peça na posição desejada
            _board.InsertPiece(piece, destination);
        }
    
    }
}