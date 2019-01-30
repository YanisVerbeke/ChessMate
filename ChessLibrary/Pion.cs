using System;

namespace Fr.CodingFactory.ChessMate.Pieces
{
    public class Pion : Piece
    {
        public bool IsValidMove(int xD, int yD, int xA, int yA)
        {
            int xMove = xA - xD;
            int yMove = yA - yD;

            if (xMove == 0 && yMove == 1) {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
