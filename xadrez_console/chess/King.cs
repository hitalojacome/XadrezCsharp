using chessboard;

namespace chess
{
    /* A King herda da classe peça
    Representação do rei no xadrez*/
    public class King : Piece
    {
        public King(Chessboard board, Color color) : base(board, color) {}

        // Rei é exibido como 'R'
        public override string ToString() 
        {
            return "R";
        }
    }
}