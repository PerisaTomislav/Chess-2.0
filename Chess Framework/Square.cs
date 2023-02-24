using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Framework
{
    public class Square
    {
        internal int Row;
        internal int Column;
        internal Piece Piece;

        public Square(int row, int col)
        {
            Row= row;
            Column= col;
        }

        public void SetPiece(Piece piece)
        {
            Piece= piece;
        }
    }
}
