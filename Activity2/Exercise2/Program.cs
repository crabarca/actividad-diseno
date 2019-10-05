using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new ChessBoard(new List<IChessPiece>
            {
                new Queen(0, 0, PieceColor.White),
                new Pawn(0, 1, PieceColor.White),
                new Pawn(1, 1, PieceColor.Black)
            });

            bool test = board.IsMovementValid(board.Pieces[0], 1, 1);
            
            Console.WriteLine($"Test: {test}");
        }
    }
}