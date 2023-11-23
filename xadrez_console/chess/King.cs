using chessboard;

namespace chess
{
    /* A King herda da classe peça
    Representação do rei no xadrez*/
    class King : Piece
    {
        private ChessMatch match;

        public King(Chessboard board, Color color, ChessMatch match) : base(board, color) {
            this.match = match;
        }

        // Rei é exibido como 'R'
        public override string ToString()
        {
            return "R";
        }

        // Método auxiliar para ver se a peça pode ser movida
        private bool CanMove(Position position)
        {
            // Cria uma peça da classe Piece que é a peça da posição passada como argumento
            Piece piece = Board.Piece(position);
            // Retorna somente se a posição for nula ou se a cor for diferente
            return piece == null || piece.Color != Color;
        }

        // Verifica se a torre está em posição para roque
        private bool TestRookForCastling(Position pos)
        {
            Piece piece = Board.Piece(pos);
            return piece != null && piece is Rook && piece.Color == Color && piece.MoveCount == 0;
        }

        // Método abstrato da classe pai
        // Determina o que a peça pode fazer
        public override bool[,] PossibleMoves()
        {
            // Cria uma nova matriz do tamanho do tabuleiro
            bool[,] matrix = new bool[Board.Lines, Board.Columns];
            Position pos = new (0,0);

            // Movimenta para Norte
            pos.SetValues(Position.Line - 1, Position.Column);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }

            // Movimenta para Nordeste
            pos.SetValues(Position.Line - 1, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }

            // Movimenta para Leste
            pos.SetValues(Position.Line, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }

            // Movimenta para Sudeste
            pos.SetValues(Position.Line + 1, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }

            // Movimenta para Sul
            pos.SetValues(Position.Line + 1, Position.Column);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }

            // Movimenta para Sudoeste
            pos.SetValues(Position.Line + 1, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }

            // Movimenta para Oeste
            pos.SetValues(Position.Line, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }

            // Movimenta para Noroeste
            pos.SetValues(Position.Line - 1, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
            }

            // #jogadaespecial ROQUE
            if(MoveCount == 0 && !match.Check)
            {
                // #jogadaespecial ROQUE PEQUENO
                Position posT1 = new (Position.Line, Position.Column + 3);
                if(TestRookForCastling(posT1))
                {
                    Position p1 = new (Position.Line, Position.Column + 1);
                    Position p2 = new (Position.Line, Position.Column + 2);
                    if(Board.Piece(p1) == null && Board.Piece(p2) == null)
                    {
                        matrix[Position.Line, Position.Column + 2] = true;
                    }
                }

                // #jogadaespecial ROQUE GRANDE
                Position posT2 = new (Position.Line, Position.Column - 4);
                if(TestRookForCastling(posT2))
                {
                    Position p1 = new (Position.Line, Position.Column - 1);
                    Position p2 = new (Position.Line, Position.Column - 2);
                    Position p3 = new (Position.Line, Position.Column - 3);
                    if(Board.Piece(p1) == null && Board.Piece(p2) == null && Board.Piece(p3) == null)
                    {
                        matrix[Position.Line, Position.Column - 2] = true;
                    }
                }
            }
            return matrix;
        }
    }
}