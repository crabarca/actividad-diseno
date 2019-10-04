namespace Exercise2
{
    public class ChessPiece
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PieceType Type { get; }
        
        public PieceColor Color { get; }

        public ChessPiece(int x, int y, PieceType type, PieceColor color)
        {
            X = x;
            Y = y;
            Type = type;
            Color = color;
        }
    }
}