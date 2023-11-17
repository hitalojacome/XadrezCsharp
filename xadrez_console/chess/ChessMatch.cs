using chessboard;

namespace chess
{
    class ChessMatch
    {
        public Chessboard Board { get; private set; }
        public int Turn { get; private set; }
        public Color CurrentPlayer { get; private set; }
        public bool GameOver { get; private set; }

        // Inicia uma partida de xadrez
        public ChessMatch()
        {
            // Cria um tabuleiro 8x8
            Board = new Chessboard(8,8);
            // Inicia o turno com 1
            Turn = 1;
            // O jodaor   inicial é o das peças brancas
            CurrentPlayer = Color.White;
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

        // Método para fazer a jogada
         public void MakePlay(Position origin, Position destination)
         {
            ExecuteMove(origin, destination);
            Turn++;
            ChangePlayer();
         }

        // Validação de posição de origem
         public void ValidateOriginPosition(Position position)
         {
             if(Board.Piece(position) == null)
             {
                throw new ChessException("There is no piece in the origin position choose");
             }
             if(CurrentPlayer != Board.Piece(position).Color)
             {
                throw new ChessException("The piece you chose is not yours!");
             }
             if(!Board.Piece(position).HasPossibleMoves())
             {
                throw new ChessException("There aren't possible moves for the chosen piece");
             }
         }

         // Método responsável em alterar o jogador
         private void ChangePlayer()
         {
             if(CurrentPlayer == Color.White)
             {
                CurrentPlayer = Color.Black;
             }
             else
             {
                CurrentPlayer = Color.White;
             }
         }

        // Método para inserção de peças, assim, não se insere as peças no program e já se inicia o tabuleiro
        private void SetupPieces()
        {
            // Peças brancas
            //Board.InsertPiece(new Rook(Board, Color.White), new ChessPosition('c', 1).ToPosition());
            Board.InsertPiece(new Rook(Board, Color.White), new ChessPosition('c', 2).ToPosition());
            //Board.InsertPiece(new Rook(Board, Color.White), new ChessPosition('d', 2).ToPosition());
            //Board.InsertPiece(new Rook(Board, Color.White), new ChessPosition('e', 2).ToPosition());
            //Board.InsertPiece(new Rook(Board, Color.White), new ChessPosition('e', 1).ToPosition());
            //Board.InsertPiece(new King(Board, Color.White), new ChessPosition('d', 1).ToPosition());

            // Peças pretas
            //Board.InsertPiece(new Rook(Board, Color.Black), new ChessPosition('c', 7).ToPosition());
            //Board.InsertPiece(new Rook(Board, Color.Black), new ChessPosition('c', 8).ToPosition());
            //Board.InsertPiece(new Rook(Board, Color.Black), new ChessPosition('d', 7).ToPosition());
            //Board.InsertPiece(new Rook(Board, Color.Black), new ChessPosition('e', 7).ToPosition());
            //Board.InsertPiece(new Rook(Board, Color.Black), new ChessPosition('e', 8).ToPosition());
            //Board.InsertPiece(new King(Board, Color.Black), new ChessPosition('d', 8).ToPosition());
        }
    }
}