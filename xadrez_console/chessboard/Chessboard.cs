namespace chessboard
{
    // Classe do tabuleiro
    class Chessboard
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] _pieces;

        public Chessboard(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            _pieces = new Piece[lines, columns];
        }

        // Como a matriz é privada, criamos este método para ter acesso a peça uma peça individual
        // Abstração
        public Piece Piece(int line, int column)
        {
            // Retorna a peça na posição indicada
            return _pieces[line, column];
        }

        // Sobrecarga da classe Piece
        public Piece Piece(Position position)
        {
            return _pieces[position.Line, position.Column];
        }

        // Método que verifica se já existe uma peça na posição passada
        public bool PieceExist(Position position)
        {
            // Primeiro verifica se a posição é valida
            PositionValidation(position);
            // Retorna a peça na posição se não for nulo
            return Piece(position) != null;
        }

        // Método para inserção de peça no tabuleiro
        public void InsertPiece(Piece piece, Position position)
        {
            // Antes da inserção de peça valida se existe peça no local indicado
            if (PieceExist(position)) // Como na classe PieceExist já está incluido a validação da class PositionValidation, acaba validando ambos antes de inserir uma peça
            {
                throw new ChessException("Already exist a piece in this position!");
            }
            // A matriz é uma peça
            _pieces[position.Line, position.Column] = piece;
            // A posição da peça é a posição passada
            piece.Position = position;
        }

        // Método para remover a peça do tabuleiro
        public Piece RemovePiece(Position position)
        {
            // Se a a posição for nula
            if (Piece(position) == null)
            {
                // Retorne nada
                return null;
            }
            // Variavel auxiliar que recebe a peça da posição informada
            Piece aux = Piece(position);
            // Altera a posição da peça para vazia
            aux.Position = null;
            // Remove a peça da matriz
            _pieces[position.Line, position.Column] = null;
            // Retorna a variavel auxiliar com a peça
            return aux;
        }

        // Método para validar se a posição é válida
        public bool ValidPosition(Position position)
        {
            /* SE o valor de linha for menor que 0 ou maior que a quantidade em linhas
            OU SE o valor de coluna for menor que 0 ou maior que a quantidade em colunas */
            // linha e coluna = atributos Position || linhas e colunas = atributos Chessboard
            if (position.Line < 0 || position.Line >= Lines || position.Column < 0 || position.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        // Método para lançar a exceção caso a posição seja inválida
        public void PositionValidation(Position position)
        {
            // SE a posição passada em ValidPosition NÃO(!) for válida
            if (!ValidPosition(position))
            {
                throw new ChessException("Invalid position!");
            }
        }
    }
}