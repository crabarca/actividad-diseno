using System;
using System.Collections.Generic;
namespace Exercise2
{
    public interface IChessPiece
    {
        List<ChessTile> getAvailablePositions();
        List<ChessTile> getPath(int x, int y);
        ChessTile getActualPosition();
        PieceColor GetPieceColor();
    }
}
