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
            bool[,] matrix = new bool [Board.Lines, Board.Columns];
            Position position = new (0,0);

            // Movimenta para Norte
            position.SetValues(position.Line - 1, position.Column);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }
                position.Line--;
            }

            // Movimenta para Leste
            position.SetValues(position.Line, position.Column + 1);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }
                position.Column++;
            }

            // Movimenta para Sul
            position.SetValues(position.Line + 1, position.Column);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }
                position.Line++;
            }

            // Movimenta para Oeste
            position.SetValues(position.Line, position.Column - 1);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }
                position.Column--;
            }

            return matrix;
        }
    }
}