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

        public bool IsMovementValid(IChessPiece piece, int x, int y)
        {
            if (!isInbound(x, y)) return false;
            // validacion deberia ser un method distinto

            if (!IsMovementAvailable(piece, x, y)) return false;
            
            foreach(ChessTile posibleOption in piece.getAvailablePositions())
            {
                // check if there is somethign between destination and origin
                if (isEmpty(posibleOption.X, posibleOption.Y))
                {
                    return true;
                }
                else
                {
                    if ()
                }
            }
            
            // A pawn can move forward one tile if it is empty, or can capture opposing pieces diagonally one tile away.
            if (piece.Type == PieceType.Pawn)
            {
                foreach (ChessTile posibleOption in piece.getAvailablePositions())
                {

                }
                if (y == piece.Y + 1 * piece.DirectionMultiplier() && x == piece.X && GetPieceAtPosition(x, y) == null) return true;
                if (y == piece.Y + 1 && x == piece.X - 1 &&
                    !isEmpty(x,y) && !isSameColor(piece, x, y)) return true;
                if (y == piece.Y + 1 && x == piece.X + 1 &&
                    GetPieceAtPosition(x, y) != null &&
                    GetPieceAtPosition(x, y).Color == PieceColor.Black) return true;

            }

            // Bishops move diagonally. They cannot move through other pieces.
            if (piece.Type == PieceType.Bishop)
            {
                for (var i = 0; i < 4; i++)
                {
                    var testX = piece.X;
                    var testY = piece.Y;

                    while (isInbound(testX, testY)
                    {
                        if (i == 0)
                        {
                            testX += 1;
                            testY += 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 1)
                        {
                            testX += 1;
                            testY -= 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 2)
                        {
                            testX -= 1;
                            testY += 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 3)
                        {
                            testX -= 1;
                            testY -= 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                    }
                OUTERLOOP1:;
                }
            }

            // Towers move vertically and horizontally. The cannot move through other pieces.
            if (piece.Type == PieceType.Tower)
            {
                for (var i = 0; i < 4; i++)
                {
                    var testX = piece.X;
                    var testY = piece.Y;

                    while (testX >= 0 && testX <= 7 && testY >= 0 && testY <= 7)
                    {
                        if (i == 0)
                        {
                            testX += 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 1)
                        {
                            testX -= 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 2)
                        {
                            testY += 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 3)
                        {
                            testY -= 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                    }
                OUTERLOOP1:;
                }
            }

            // Queens move vertically, horizontally and diagonally. They cannot move through other pieces.
            if (piece.Type == PieceType.Queen)
            {
                for (var i = 0; i < 8; i++)
                {
                    var testX = piece.X;
                    var testY = piece.Y;

                    while (testX >= 0 && testX <= 7 && testY >= 0 && testY <= 7)
                    {
                        if (i == 0)
                        {
                            testX += 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 1)
                        {
                            testX -= 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 2)
                        {
                            testY += 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 3)
                        {
                            testY -= 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 4)
                        {
                            testX += 1;
                            testY += 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 5)
                        {
                            testX += 1;
                            testY -= 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 6)
                        {
                            testX -= 1;
                            testY += 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                        else if (i == 7)
                        {
                            testX -= 1;
                            testY -= 1;

                            var chessPiece = GetPieceAtPosition(testX, testY);
                            if (testX == x && testY == y && (chessPiece == null || piece.Color == chessPiece.Color.Opposite())) return true;
                            if (chessPiece != null) goto OUTERLOOP1;
                        }
                    }
                OUTERLOOP1:;
                }
            }

            // Kings can move one tile in any direction.
            if (piece.Type == PieceType.King)
            {
                if (x == piece.X - 1 && y == piece.Y - 1 &&
                    (GetPieceAtPosition(x, y) == null || piece.Color == GetPieceAtPosition(x, y).Color.Opposite()))
                    return true;
                if (x == piece.X && y == piece.Y - 1 &&
                    (GetPieceAtPosition(x, y) == null || piece.Color == GetPieceAtPosition(x, y).Color.Opposite()))
                    return true;
                if (x == piece.X + 1 && y == piece.Y - 1 &&
                    (GetPieceAtPosition(x, y) == null || piece.Color == GetPieceAtPosition(x, y).Color.Opposite()))
                    return true;
                if (x == piece.X + 1 && y == piece.Y &&
                    (GetPieceAtPosition(x, y) == null || piece.Color == GetPieceAtPosition(x, y).Color.Opposite()))
                    return true;
                if (x == piece.X + 1 && y == piece.Y + 1 &&
                    (GetPieceAtPosition(x, y) == null || piece.Color == GetPieceAtPosition(x, y).Color.Opposite()))
                    return true;
                if (x == piece.X && y == piece.Y + 1 &&
                    (GetPieceAtPosition(x, y) == null || piece.Color == GetPieceAtPosition(x, y).Color.Opposite()))
                    return true;
                if (x == piece.X - 1 && y == piece.Y + 1 &&
                    (GetPieceAtPosition(x, y) == null || piece.Color == GetPieceAtPosition(x, y).Color.Opposite()))
                    return true;
                if (x == piece.X - 1 && y == piece.Y &&
                    (GetPieceAtPosition(x, y) == null || piece.Color == GetPieceAtPosition(x, y).Color.Opposite()))
                    return true;
            }

            return false;
        }

        private ChessPiece GetPieceAtPosition(int x, int y)
        {
            foreach (var piece in Pieces)
            {
                if (piece.X == x && piece.Y == y)
                {
                    return piece;
                }
            }

            return null;
        }

        private bool isSameColor(IChessPiece piece, int x, int y)
        {
            return GetPieceAtPosition(x, y).Color == piece.Color;
        }

        private bool isEmpty(int x, int y)
        {
            return GetPieceAtPosition(x, y) == null;
        }

        private bool isInbound(int x, int y)
        {
            return x >= 0 && x <= 7 && y >= 0 && y <= 7;
        }
    }
}