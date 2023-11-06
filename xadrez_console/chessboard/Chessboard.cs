namespace chessboard
{
    // Classe do tabuleiro
    public class Chessboard
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        // Um tabuleiro tem uma matriz de peças, somente o tabuleiro pode acessar essas peças
        private Piece[,] _pieces; 

        public Chessboard(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            // Instancia a matriz de peças com base nas linhas e colunas passadas como argumentos
            _pieces = new Piece[lines, columns];
        }

        // Como a matriz é privada, criamos este método para ter acesso a peça uma peça individual
        // Abstração
        public Piece Piece(int line, int column)
        {
            // Retorna a peça na posição indicada
            return _pieces[line, column];
        }
    }
}