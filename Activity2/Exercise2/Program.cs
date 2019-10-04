using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new ChessBoard(new List<ChessPiece>
            {
                new ChessPiece(0, 0, PieceType.Queen, PieceColor.White),
                new ChessPiece(0, 1, PieceType.Pawn, PieceColor.White),
                new ChessPiece(1, 1, PieceType.Pawn, PieceColor.Black)
            });

            bool test = board.IsMovementValid(board.Pieces[0], 0, 1);
            
            Console.WriteLine($"Test: {test}");
        }
    }
}