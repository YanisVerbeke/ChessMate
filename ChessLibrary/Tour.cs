using System;
namespace Fr.CodingFactory.ChessMate.Pieces
{
    public class Tour : Piece
    {
        public override bool IsTrajectoireLibre(int xD, int yD, int xA, int yA, object[][] Piece)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidMove(int xD, int yD, int xA, int yA)
        {
            int xMove = xA - xD;
            int yMove = yA - yD;

            if ((xMove > 0 && xMove <= 7 && yMove == 0) || 
                (xMove < 0 && xMove >= -7 && yMove == 0) || 
                (xMove == 0 && yMove > 0 && yMove <= 7) || 
                (xMove == 0 && yMove < 0 && yMove >= -7))
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
