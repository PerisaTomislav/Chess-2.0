using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Framework.PieceTypes
{
    internal class Bishop : Piece
    {
        public Bishop(int row, int col, Side side) : base(row, col, side)
        {
            Name = "bishop";
        }

        internal override void CalculatePossibleMoves(Side side, Square[,] board)
        {
            throw new NotImplementedException();
        }
    }
}
