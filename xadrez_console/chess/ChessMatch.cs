using System.Collections.Generic;
using chessboard;

namespace chess
{
    class ChessMatch
    {
        public Chessboard Board { get; private set; }
        public int Turn { get; private set; }
        public Color CurrentPlayer { get; private set; }
        public bool GameOver { get; private set; }
        // Criação de conjuntos para armazenar todas as peças e as peças capturadas
        private HashSet<Piece> pieces;
        private HashSet<Piece> capturedPieces;

        // Inicia uma partida de xadrez
        public ChessMatch()
        {
            // Cria um tabuleiro 8x8
            Board = new Chessboard(8,8);
            // Inicia o turno com 1
            Turn = 1;
            // O jogador inicial é o das peças brancas
            CurrentPlayer = Color.White;
            // Partida inicia com o 'GameOver' falso
            GameOver = false;
            pieces = new HashSet<Piece>();
            capturedPieces = new HashSet<Piece>();
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
            if (capturedPiece != null)
            {
                capturedPieces.Add(capturedPiece);
            }
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
                throw new ChessException("There is no piece in the chosen starting position!");
             }
             if(CurrentPlayer != Board.Piece(position).Color)
             {
                throw new ChessException("The chosen piece is not yours!");
             }
             if(!Board.Piece(position).HasPossibleMoves())
             {
                throw new ChessException("There are no possible moves for the chosen piece!");
             }
         }

         // Validação de posição de destino
         public void ValidateDestinationPosition(Position origin, Position destination)
         {
            if(!Board.Piece(origin).CanMoveTo(destination))
            {
                throw new ChessException("Invalid destination position!");
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

        // Retorna a quantidade de paças captuir
        public HashSet<Piece> CapturedPieces(Color color)
        {
            HashSet<Piece> aux = new ();
            foreach(Piece x in capturedPieces)
            {
                if(x.Color == color)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        // Retorna quantas peças ainda existem no jogo
        public HashSet<Piece> PieceInGame(Color color)
        {
            HashSet<Piece> aux = new();
            foreach(Piece x in pieces)
            {
                if(x.Color == color)
                {
                    aux.Add(x);
                }
            }
            // As peças de tal cor EXCETO as capturadas
            aux.ExceptWith(CapturedPieces(color));
            return aux;
        }

        // Método para inserir a peça no conjunto
        public void InsertNewPiece(char column, int line, Piece piece)
        {
            Board.InsertPiece(piece, new ChessPosition(column, line).ToPosition());
            pieces.Add(piece);
        }

        // Método para inserção de peças, assim, não se insere as peças no program e já se inicia o tabuleiro
        private void SetupPieces()
        {
            // Peças brancas
            InsertNewPiece('c', 1, new Rook(Board, Color.White));
            InsertNewPiece('c', 2, new Rook(Board, Color.White));
            InsertNewPiece('d', 2, new Rook(Board, Color.White));
            InsertNewPiece('e', 2, new Rook(Board, Color.White));
            InsertNewPiece('e', 1, new Rook(Board, Color.White));
            InsertNewPiece('d', 1, new King(Board, Color.White));

            // Peças pretas
            InsertNewPiece('c', 7, new Rook(Board, Color.Black));
            InsertNewPiece('c', 8, new Rook(Board, Color.Black));
            InsertNewPiece('d', 7, new Rook(Board, Color.Black));
            InsertNewPiece('e', 7, new Rook(Board, Color.Black));
            InsertNewPiece('e', 8, new Rook(Board, Color.Black));
            InsertNewPiece('d', 8, new King(Board, Color.Black));
        }
    }
}