using System.Collections.Generic;

namespace Exercise2

{
    public class King: IChessPiece
    {
        public List<ChessTile> getAvailablePositions()
        {
            var availablePositions = new List<ChessTile> { };
            for (int row = 0; row <= 1; row++)
            {
                for (int col = 0; col <= 1; col++)
                {
                    if (((Y == col) || (X == row)) || (Math.Abs(Y - col) == Math.Abs(X - row)))
                    {
                        availablePositions.Add(new ChessTile(col, row));
                    }
                }
            }
            return availablePositions;
        }
    }
}
