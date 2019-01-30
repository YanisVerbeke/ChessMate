using System;
namespace Fr.CodingFactory.ChessMate.Pieces
{
    public abstract class Piece
    {
        public bool Couleur { get; set; }
        public string Nom { get; set; }

        public abstract bool IsValidMove(int xD, int yD, int xA, int yA);
        public abstract bool IsTrajectoireLibre(int xD, int yD, int xA, int yA, object[][] Piece);
    }
}
