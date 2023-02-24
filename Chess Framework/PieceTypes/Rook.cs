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
            PossibleMoves.Clear();
            foreach (Square square in board)
            {
                if (side == Side.White)
                {
                    if (square.Piece == null && square.Column == _posCol && square.Row == _posRow - 1)
                    {
                        PossibleMoves.Add(square.Row.ToString() + square.Column.ToString());
                        if (_posRow == 6 && square.Piece == null)
                        {
                            foreach (Square squareBehind in board)
                            {
                                if (squareBehind.Column == square.Column && squareBehind.Row == square.Row - 1 && squareBehind.Piece == null)
                                {
                                    PossibleMoves.Add(squareBehind.Row.ToString() + squareBehind.Column.ToString());
                                }
                            }
                        }
                    }
                    if (square.Row == _posRow - 1 && ((square.Column == _posCol - 1) || (square.Column == _posCol + 1)) && square.Piece != null && square.Piece.Side == Side.Black)
                    {
                        PossibleMoves.Add(square.Row.ToString() + square.Column.ToString());
                    }
                }
                if (side == Side.Black)
                {
                    if (square.Piece == null && square.Column == _posCol && square.Row == _posRow + 1)
                    {
                        PossibleMoves.Add(square.Row.ToString() + square.Column.ToString());
                        if (_posRow == 1 && square.Piece == null)
                        {
                            foreach (Square squareBehind in board)
                            {
                                if (squareBehind.Column == square.Column && squareBehind.Row == square.Row + 1 && squareBehind.Piece == null)
                                {
                                    PossibleMoves.Add(squareBehind.Row.ToString() + squareBehind.Column.ToString());
                                }
                            }
                        }
                    }
                    if (square.Row == _posRow + 1 && ((square.Column == _posCol - 1) || (square.Column == _posCol + 1)) && square.Piece != null && square.Piece.Side == Side.White)
                    {
                        PossibleMoves.Add(square.Row.ToString() + square.Column.ToString());
                    }
                }
            }
        }
    }
}
