using System;
using System.Collections.Generic;
namespace Exercise2
{
    public interface IChessPiece
    {
        List<ChessTile> getAvailablePositions();
    }
}
