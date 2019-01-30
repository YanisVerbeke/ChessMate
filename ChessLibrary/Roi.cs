using System;
namespace Fr.CodingFactory.ChessMate.Pieces
{
    public class Roi : Piece
    {
        public override bool IsTrajectoireLibre(int xD, int yD, int xA, int yA, object[][] Piece)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidMove(int xD, int yD, int xA, int yA)
        {
            int xMove = xA - yA;
            int yMove = yA - yD;

            if((xMove > 0 && xMove <= 1 && yMove == 0) || (yMove > 0 && yMove <= 1 && xMove == 0) || (xMove < 0 && xMove >= -1 && yMove == 0) || (yMove < 0 && yMove >= -1 && xMove == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
