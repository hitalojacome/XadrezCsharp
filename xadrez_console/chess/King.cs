using chessboard;

namespace chess
{
    /* A King herda da classe peça
    Representação do rei no xadrez*/
    class King : Piece
    {
        public King(Chessboard board, Color color) : base(board, color) {}

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

        // Método abstrato da classe pai
        // Determina o que a peça pode fazer
        public override bool[,] PossibleMoves() 
        {
            // Cria uma nova matriz do tamanho do tabuleiro
            bool[,] matrix = new bool [Board.Lines, Board.Columns];
            Position position = new (0,0);

            // Movimenta para Norte
            position.SetValues(position.Line - 1, position.Column);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
            }

            // Movimenta para Nordeste
            position.SetValues(position.Line - 1, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
            }

            // Movimenta para Leste
            position.SetValues(position.Line, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
            }

            // Movimenta para Sudeste
            position.SetValues(position.Line + 1, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
            }

            // Movimenta para Sul
            position.SetValues(position.Line + 1, position.Column);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
            }

            // Movimenta para Sudoeste
            position.SetValues(position.Line + 1, position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
            }

            // Movimenta para Oeste
            position.SetValues(position.Line, position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
            }

            // Movimenta para Noroeste
            position.SetValues(position.Line - 1, position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Line, position.Column] = true;
            }

            return matrix;
        }
    }
}