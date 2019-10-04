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

        public List<ChessTile> getAvailablePositions()
        {
            var availablePositions = new List<ChessTile> { };
            availablePositions.Add(new ChessTile(Y + 1 * getDirection(), X));
            availablePositions.Add(new ChessTile(Y + 1 * getDirection(), X + 1));
            availablePositions.Add(new ChessTile(Y + 1 * getDirection(), X - 1));
            return availablePositions;
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
    }
}
