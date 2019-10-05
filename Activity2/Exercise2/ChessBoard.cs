using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Exercise2
{
    public class ChessBoard
    {
        public List<IChessPiece> Pieces { get; }

        public ChessBoard(List<IChessPiece> pieces)
        {
            Pieces = pieces;
        }

        public bool IsMovementAvailable(IChessPiece piece, int x, int y)
        {
            foreach (ChessTile posibleOption in piece.getAvailablePositions())
            {
                if (posibleOption.X == x && posibleOption.Y == y)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsPathClear(IChessPiece piece, int x, int y)
        {
            List<ChessTile> path = piece.getPath(x, y);

            foreach (ChessTile pathTile in path)
            {
                if (!IsEmpty(pathTile.X, pathTile.Y))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsPawnValid(IChessPiece piece, int x, int y)
        {
            ChessTile chessTile = piece.getActualPosition();

            if (IsEmpty(x, y))
            {
                if (chessTile.Y != y) return false;
            }
            else
            {
                if (chessTile.Y == y) return false;
            }

            return true;
        }

        public bool IsMovementValid(IChessPiece piece, int x, int y)
        {

            Console.WriteLine("1");

            if (!isInbound(x, y)) return false;

            Console.WriteLine("2");

            if (!IsMovementAvailable(piece, x, y)) return false;

            Console.WriteLine("3");

            if (!IsPathClear(piece, x, y)) return false;

            Console.WriteLine("4");

            if (IsSameColor(piece, x, y)) return false;

            Console.WriteLine("5");

            //pawn condition (outlier)
            if (!IsPawnValid(piece, x, y)) return false;

            Console.WriteLine("6");

            return true;
        }

        private IChessPiece GetPieceAtPosition(int x, int y)
        {
            foreach (var piece in Pieces)
            {
                ChessTile chessTile = piece.getActualPosition();
                if (chessTile.X == x && chessTile.Y == y)
                {
                    return piece;
                }
            }

            return null;
        }

        private bool IsSameColor(IChessPiece piece, int x, int y)
        {
            if (!IsEmpty(x, y))
            {
                if (GetPieceAtPosition(x, y).GetPieceColor() != piece.GetPieceColor()) return false;
            }
            return true;
        }

        private bool IsEmpty(int x, int y)
        {
            return GetPieceAtPosition(x, y) == null;
        }

        private bool isInbound(int x, int y)
        {
            return x >= 0 && x <= 7 && y >= 0 && y <= 7;
        }
    }
}