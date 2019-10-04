using System;
using System.Collections.Generic;

namespace Exercise2
{
    public class Knight : IChessPiece
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PieceType Type { get; }

        public PieceColor Color { get; }

        public Knight(int x, int y, PieceColor color)
        {
            X = x;
            Y = y;
            Type = PieceType.Pawn;
            Color = color;
        }

        public List<ChessTile> getAvailablePositions()
        {
            var availablePositions = new List<ChessTile> { };
            // Llenar codigo
            return availablePositions;
        }
    }
}
