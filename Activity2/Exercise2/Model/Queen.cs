using System;
using System.Collections.Generic;

namespace Exercise2
{
    public class Queen
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PieceType Type { get; }

        public PieceColor Color { get; }

        public Queen(int x, int y, PieceColor color)
        {
            X = x;
            Y = y;
            Type = PieceType.Pawn;
            Color = color;
        }

        public List<ChessTile> getAvailablePositions()
        {
            var availablePositions = new List<ChessTile> { };
            for (int row = 0; row <= 7; row++)
            {
                for (int col = 0; col <= 7; col++)
                {
                    if (((Y == col) || (X == row)) || (Math.Abs(Y - col) == Math.Abs(X - row)))
                    {
                        availablePositions.Add(new ChessTile(col, row));
                    }
                }
            }
            return availablePositions;
        }
    }
}
