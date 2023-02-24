using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Framework
{
    public abstract class Piece
    {
        internal string Name;
        internal Side Side;
        protected int _posRow;
        protected int _posCol;
        internal List<string> PossibleMoves;

        public Piece(int row, int col, Side side)
        {
            Side = side;
            _posRow = row;
            _posCol = col;
            PossibleMoves= new List<string>();
        }

        internal abstract void CalculatePossibleMoves(Side side, Square[,] board);
    }
}
