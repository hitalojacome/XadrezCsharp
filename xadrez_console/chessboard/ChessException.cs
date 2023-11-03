namespace chessboard
{
    // Criando uma exceção personalizada para nosso tabuleiro
    public class ChessException : Exception
    {
        public ChessException(string message) : base(message) {}
    }
}