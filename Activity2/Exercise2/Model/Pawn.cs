using System;
using System.Collections.Generic;

namespace Exercise2
{
    public class Pawn : IChessPiece
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PieceType Type { get; }

        public PieceColor Color { get; }

        public Pawn(int x, int y, PieceColor color)
        {
            X = x;
            Y = y;
            Type = PieceType.Pawn;
            Color = color;
        }

        public int getDirection()
        {
            var direction = 1;

            if (Color == PieceColor.Black)
            {
                direction = -1;
            }

            return direction;
        }

        public List<ChessTile> getAvailablePositions()
        {
            var availablePositions = new List<ChessTile> { };
            availablePositions.Add(new ChessTile(X + 1 * getDirection(), Y));
            availablePositions.Add(new ChessTile(X + 1 * getDirection(), Y + 1));
            availablePositions.Add(new ChessTile(X + 1 * getDirection(), Y - 1));
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
