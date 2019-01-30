using System;
namespace Fr.CodingFactory.ChessMate.Pieces
{
    public class Cavalier : Piece
    {

        public bool IsValidMove (int xD, int yD, int xA, int yA)
        {
            int xMove = xA - xD;
            int yMove = yA - yD;

            if ((xMove == 2 && yMove == 1) || (xMove == 2 & yMove == -1) || (xMove == -2 & yMove == 1) || (xMove == -2 & yMove == -1) || (xMove == 1 & yMove == 2) || (xMove == -1 & yMove == 2) || (xMove == 1 & yMove == -2) || (xMove == -1 & yMove == -2) {
                return true;
            } else {
                return false;
            }
        }

    }
}
