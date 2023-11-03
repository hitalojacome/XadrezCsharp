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

        public Piece piece(int line, int column) // Como a matriz é privativa, criamos este método para ter acesso a peça em sua linha e coluna
        {
            return pieces[line, column];
        }

        public void PlacePiece(Piece p, Position pos) // Método para colocar a peça no tabuleiro
        {
            pieces[pos.line, pos.column] = p; // determina que uma Piece 'p' é a instanciação de linha e coluna da matriz
            p.position = pos; // Determina que o atributo position será instanciado como a posição do nosso objeto p
        }
    }
}