using chessboard;

namespace chess
{
    // Representação do cavalo no xadrez
    class Knight : Piece
    {
        public Knight(Chessboard board, Color color) : base(board, color) {}

        // Cavalo é exibido como 'C'
        public override string ToString()
        {
            return "C";
        }

        // Método auxiliar para ver se a peça pode ser movida
        private bool CanMove(Position position)
        {
            Piece piece = Board.Piece(position);
            return piece == null || piece.Color != Color;
        }

        // Determina o que a peça pode fazer
        public override bool[,] PossibleMoves()
        {
            // Cria uma nova matriz do tamanho do tabuleiro
            bool[,] matrix = new bool[Board.Lines, Board.Columns];
            Position pos = new (0,0);

            pos.SetValues(Position.Line - 1, Position.Column - 2);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }
            pos.SetValues(Position.Line - 2, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }
            pos.SetValues(Position.Line - 2, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }
            pos.SetValues(Position.Line - 1, Position.Column + 2);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }
            pos.SetValues(Position.Line + 1, Position.Column + 2);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }
            pos.SetValues(Position.Line + 2, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }
            pos.SetValues(Position.Line + 2, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }
            pos.SetValues(Position.Line + 1, Position.Column - 2);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }

            return matrix;
        }
    }
}