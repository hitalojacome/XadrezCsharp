using chessboard;

namespace chess
{
    // Representação do Peão no xadrez*/
    class Pawn : Piece
    {
        public Pawn(Chessboard board, Color color) : base(board, color) {}

        // Peão é exibido como 'P'
        public override string ToString() 
        {
            return "P";
        }

        private bool HasEnemy(Position pos)
        {
            Piece piece = Board.Piece(pos);
            return piece != null && piece.Color != Color;
        }

        private bool Free(Position pos)
        {
            return Board.Piece(pos) == null;
        }

        // Determina o que a peça pode fazer
        public override bool[,] PossibleMoves() 
        {
            // Cria uma nova matriz do tamanho do tabuleiro
            bool[,] matrix = new bool[Board.Lines, Board.Columns];
            Position pos = new (0,0);   

            if (Color == Color.Green)
            {
                pos.SetValues(Position.Line - 1, Position.Column);
                if (Board.ValidPosition(pos) && Free(pos))
                {
                    matrix[pos.Line, pos.Column] = true;
                }
                pos.SetValues(Position.Line - 2, Position.Column);
                Position p2 = new (Position.Line - 1, Position.Column);
                if (Board.ValidPosition(p2) && Free(p2) && Board.ValidPosition(pos) && Free(pos) && MoveCount == 0)
                {
                    matrix[pos.Line, pos.Column] = true;
                }
                pos.SetValues(Position.Line - 1, Position.Column - 1);
                if (Board.ValidPosition(pos) && HasEnemy(pos))
                {
                    matrix[pos.Line, pos.Column] = true;
                }
                pos.SetValues(Position.Line - 1, Position.Column + 1);
                if (Board.ValidPosition(pos) && HasEnemy(pos))
                {
                    matrix[pos.Line, pos.Column] = true;
                }
            }
            else
            {
                pos.SetValues(Position.Line + 1, Position.Column);
                if (Board.ValidPosition(pos) && Free(pos))
                {
                    matrix[pos.Line, pos.Column] = true;
                }
                pos.SetValues(Position.Line + 2, Position.Column);
                Position p2 = new (Position.Line + 1, Position.Column);
                if (Board.ValidPosition(p2) && Free(p2) && Board.ValidPosition(pos) && Free(pos) && MoveCount == 0)
                {
                    matrix[pos.Line, pos.Column] = true;
                }
                pos.SetValues(Position.Line + 1, Position.Column - 1);
                if (Board.ValidPosition(pos) && HasEnemy(pos))
                {
                    matrix[pos.Line, pos.Column] = true;
                }
                pos.SetValues(Position.Line + 1, Position.Column + 1);
                if (Board.ValidPosition(pos) && HasEnemy(pos))
                {
                    matrix[pos.Line, pos.Column] = true;
                }
            }

            return matrix;
        }
    }
}