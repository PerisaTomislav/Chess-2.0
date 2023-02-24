using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chess_Framework.PieceTypes
{
    internal class Rook : Piece
    {
        public Rook(int row, int col, Side side) : base(row,col,side)
        {
            Name = "rook";
        }

        internal override void CalculatePossibleMoves(Side side, Square[,] board)
        {
            throw new NotImplementedException();
        }
    }
}
