using System;
using System.Collections.Generic;

namespace Exercise2
{
    public class Bishop : IChessPiece
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PieceType Type { get; }

        private PieceColor Color;

        public Bishop(int x, int y, PieceColor color)
        {
            X = x;
            Y = y;
            Type = PieceType.Bishop;
            Color = color;
        }

        public List<ChessTile> getAvailablePositions()
        {
            var availablePositions = new List<ChessTile> { };
            for (int row = 0; row <= 7; row++)
            {
                for (int col = 0; col <= 7; col++)
                {
                    if (Math.Abs(Y - col) == Math.Abs(X - row))
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
            if (X < x && Y < y)
            {
                var pathX = X++;
                var pathY = Y++;
                while (pathX < x && pathY < y)
                {
                    path.Add(new ChessTile(pathX, pathY));
                    pathX++;
                    pathY++;
                }
            }
            else if (X < x && Y > y)
            {
                var pathX = X++;
                var pathY = Y--;
                while (pathX < x && pathY > y)
                {
                    path.Add(new ChessTile(pathX, pathY));
                    pathX++;
                    pathY--;
                }
            }
            else if (X > x && Y > y)
            {
                var pathX = X--;
                var pathY = Y--;
                while (pathX > x && pathY > y)
                {
                    path.Add(new ChessTile(pathX, pathY));
                    pathX--;
                    pathY--;
                }

            }
            else if (X > x && Y < y)
            {
                var pathX = X--;
                var pathY = Y++;
                while (pathX > x && pathY < y)
                {
                    path.Add(new ChessTile(pathX, pathY));
                    pathX--;
                    pathY++;
                }
            }
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
