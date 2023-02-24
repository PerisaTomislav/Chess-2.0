using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Framework.PieceTypes
{
    internal class Queen : Piece
    {
        public Queen(int row, int col, Side side) : base(row, col, side)
        {
            Name = "queen";
        }

        internal override void CalculatePossibleMoves(Side side, Square[,] board)
        {
            throw new NotImplementedException();
        }
    }
}
