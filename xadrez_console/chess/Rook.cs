using chessboard;

namespace chess
{
    /* A Rook herda da classe peça
    Representação da torre no xadrez*/
    class Rook : Piece
    {
        public Rook(Chessboard board, Color color) : base(board, color) {}

        // Torre é exibido como 'T'
        public override string ToString()
        {
            return "T";
        }

        // Método auxiliar para ver se a peça pode ser movida
        private bool CanMove(Position position)
        {
            // Cria uma peça da classe Piece que é a peça da posição passada como argumento
            Piece piece = Board.Piece(position);
            // Retorna somente se a posição for nula ou se a cor for diferente
            return piece == null || piece.Color != Color;
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
            while (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
                if (Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.Line--;
            }

            // Movimenta para Leste
            pos.SetValues(Position.Line, Position.Column + 1);
            while (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
                if (Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.Column++;
            }

            // Movimenta para Sul
            pos.SetValues(Position.Line + 1, Position.Column);
            while (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
                if (Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.Line++;
            }

            // Movimenta para Oeste
            pos.SetValues(Position.Line, Position.Column - 1);
            while (Board.ValidPosition(pos) && CanMove(pos))
            {
                matrix[pos.Line, pos.Column] = true;
                if (Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.Column--;
            }

            return matrix;
        }
    }
}