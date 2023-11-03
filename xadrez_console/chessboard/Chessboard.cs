namespace chessboard
{
    public class Chessboard
    {
        public int lines { get; set; } // Atributo para armazenar as linhas
        public int columns { get; set; } // Atributo para armazenar as colunas
        private Piece[,] pieces; // Atributo privativo que cria uma matriz conforme as peças da classe Piece

        public Chessboard(int lines, int columns) // Construtor do tabuleiro
        {
            this.lines = lines; // Recebe o número de linhas passada no argumento
            this.columns = columns; // Recebe o número de colunas passada no argumento
            pieces = new Piece[lines, columns]; // Instancia o atributo pieces (que é uma matriz) com base nas linhas e colunas passadas
        }

        public Piece Piece(int line, int column) // Como a matriz é privativa, criamos este método para ter acesso a peça em sua linha e coluna
        {
            return pieces[line, column];
        }

        public Piece Piece(Position pos) // Como a matriz é privativa, criamos este método para ter acesso a peça em sua linha e coluna
        {
            return pieces[pos.line, pos.column];
        }

        public bool HasPiece(Position pos) // Método verifica se a peça existe no tabuleiro
        {
            ValidatePosition(pos); // Inicia com o método de validação de posição
            return Piece(pos) != null; // Se a posição for diferente de nula
        }

        public void PlacePiece(Piece p, Position pos) // Método para colocar a peça no tabuleiro
        {
            if (HasPiece(pos)) 
            {
                throw new ChessException("A piece already exists in this position!");
            }
            pieces[pos.line, pos.column] = p; // determina que uma Piece 'p' é a instanciação de linha e coluna da matriz
            p.position = pos; // Determina que o atributo position será instanciado como a posição do nosso objeto p
        }

        public Piece RemovePiece(Position pos) 
        {
            if (Piece(pos) == null)
            {
                return null;
            }
            Piece aux = Piece(pos);
            aux.position = null;
            pieces[pos.line, pos.column] = null;
            return aux;
        }

        public bool ValidPosition(Position pos) // Método verifica se a posição é valida
        {
            if (pos.line < 0 || pos.line >= lines || pos.column < 0 || pos.column >= columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position pos) // Método valida a posição com base no método anterior
        {
            if (!ValidPosition(pos)) {
                throw new ChessException("Invalid position!");
            }
        }
    }
}