using chessboard;

namespace chess
{
    // Representação do rainha no xadrez
    class Queen : Piece
    {
        public Queen(Chessboard board, Color color) : base(board, color) {}

        // Dama é exibido como 'D'
        public override string ToString() 
        {
            return "D";
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

            // Movimenta para Norte
            pos.SetValues(Position.Line - 1, Position.Column);
            while(Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
                if(Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.SetValues(pos.Line - 1, pos.Column);
            }

            // Movimenta para Nordeste
            pos.SetValues(Position.Line - 1, Position.Column + 1);
            while(Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
                if(Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.SetValues(pos.Line - 1, pos.Column + 1);
            }

            // Movimenta para Leste
            pos.SetValues(Position.Line, Position.Column + 1);
            while(Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
                if(Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.SetValues(pos.Line, pos.Column + 1);
            }

            // Movimenta para Sudeste
            pos.SetValues(Position.Line + 1, Position.Column + 1);
            while(Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
                if(Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.SetValues(pos.Line + 1, pos.Column + 1);
            }

            // Movimenta para Sul
            pos.SetValues(Position.Line + 1, Position.Column);
            while(Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
                if(Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.SetValues(pos.Line + 1, pos.Column);
            }

            // Movimenta para Sudoeste
            pos.SetValues(Position.Line + 1, Position.Column - 1);
            while(Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
                if(Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.SetValues(pos.Line + 1, pos.Column - 1);
            }

            // Movimenta para Oeste
            pos.SetValues(Position.Line, Position.Column - 1);
            while(Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
                if(Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.SetValues(pos.Line, pos.Column - 1);
            }

            // Movimenta para Noroeste
            pos.SetValues(Position.Line - 1, Position.Column - 1);
            while(Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
                if(Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.SetValues(pos.Line - 1, pos.Column - 1);
            }

            return matrix;
        }
    }
}