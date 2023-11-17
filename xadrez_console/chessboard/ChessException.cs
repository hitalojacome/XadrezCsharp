namespace chessboard
{
    // Criando uma exceção personalizada para nosso tabuleiro
    class ChessException : Exception
    {
        public ChessException(string message) : base(message) {}
    }
}