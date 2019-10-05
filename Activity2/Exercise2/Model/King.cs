using System.Collections.Generic;
using System;

namespace Exercise2
{
    public class King: IChessPiece
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PieceType Type { get; }

        public PieceColor Color { get; }

        public King(int x, int y, PieceColor color)
        {
            X = x;
            Y = y;
            Type = PieceType.King;
            Color = color;
        }
        public List<ChessTile> getAvailablePositions()
        {
            var availablePositions = new List<ChessTile> { };
            for (int row = 0; row <= 1; row++)
            {
                for (int col = 0; col <= 1; col++)
                {
                    if (((Y == col) || (X == row)) || (Math.Abs(Y - col) == Math.Abs(X - row)))
                    {
                        availablePositions.Add(new ChessTile(row, col));
                    }
                }
            }
            return availablePositions;
        }

        public List<ChessTile> getPath(int x, int y)
        {
            var path = new List<ChessTile> { };
            return path;
        }

        public ChessTile getActualPosition()
        {
            return new ChessTile(X, Y);
        }

        public PieceColor GetPieceColor()
        {
            return Color;
        }
    }
}
