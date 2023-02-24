using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Framework.PieceTypes
{
    internal class Knight : Piece
    {
        public Knight(int row, int col, Side side) : base(row, col, side)
        {
            Name = "knight";
        }

        internal override void CalculatePossibleMoves(Side side, Square[,] board)
        {
            throw new NotImplementedException();
        }
    }
}
