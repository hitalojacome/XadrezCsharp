using chessboard;

namespace chess
{
    /* A Rook herda da classe peça
    Representação da torre no xadrez*/
    public class Rook : Piece 
    {
        public Rook(Chessboard board, Color color) : base(board, color) {} 

        // Torre é exibido como 'T'
        public override string ToString() 
        {
            return "T";
        }
    }
}