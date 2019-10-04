namespace Exercise2
{
    public enum PieceColor
    {
        Black, White
    }

    public static class PieceColorMethods
    {
        public static PieceColor Opposite(this PieceColor pieceColor)
        {
            return pieceColor == PieceColor.White ? PieceColor.Black : PieceColor.White;

        }
    }
}