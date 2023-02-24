using Chess_Framework.PieceTypes;

namespace Chess_Framework
{
    public class Board
    {
        private readonly Square[,] _board;
        private int _turnCount;
        private readonly List<Piece> _whitePieces;
        private readonly List<Piece> _blackPieces;
        private string _lastMove;
        private bool _whiteOnTurn;
        private bool _status;

        public Board()
        {
            _board = new Square[8, 8];
            _turnCount = 0;
            _whitePieces = new List<Piece>();
            _blackPieces = new List<Piece>();
            _lastMove = null;
            _whiteOnTurn = true;
            _status = true;
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    _board[i, j] = new Square(i, j);
                }
            }
            Setup();
        }

        private void Setup()
        {
            //Pawns
            for (int j = 0; j < 8; j++)
            {
                _board[6, j].SetPiece(new Pawn(6, j,Side.White));
                _board[1, j].SetPiece(new Pawn(1, j, Side.Black));
            }
            //Rest of the white pieces
            _board[7, 0].SetPiece(new Rook(7, 0, Side.White));
            _board[7, 7].SetPiece(new Rook(7, 7, Side.White));
            _board[7, 1].SetPiece(new Knight(7, 1, Side.White));
            _board[7, 6].SetPiece(new Knight(7, 6, Side.White));
            _board[7, 2].SetPiece(new Bishop(7, 2, Side.White));
            _board[7, 5].SetPiece(new Bishop(7, 5, Side.White));
            _board[7, 4].SetPiece(new King(7, 4, Side.White));
            _board[7, 3].SetPiece(new Queen(7, 3, Side.White));
            //Ostale crne figure
            _board[0, 0].SetPiece(new Rook(0, 0, Side.Black));
            _board[0, 7].SetPiece(new Rook(0, 7, Side.Black));
            _board[0, 1].SetPiece(new Knight(0, 1, Side.Black));
            _board[0, 6].SetPiece(new Knight(0, 6, Side.Black));
            _board[0, 2].SetPiece(new Bishop(0, 2, Side.Black));
            _board[0, 5].SetPiece(new Bishop(0, 5, Side.Black));
            _board[0, 4].SetPiece(new King(0, 4, Side.Black));
            _board[0, 3].SetPiece(new Queen(0, 3, Side.Black));
        }

        public string GetVisualRepresentationOfTheBoard()
        {
            string vizualnaReprezentacija = "";
            vizualnaReprezentacija += "a b c d e f g h\n";
            vizualnaReprezentacija += "---------------\n";
            for(int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (_board[i, j].Piece != null)
                    {
                        if (_board[i, j].Piece.Side == Side.White) vizualnaReprezentacija += _board[i, j].Piece.Name[0].ToString().ToUpper() + " ";
                        else vizualnaReprezentacija += _board[i, j].Piece.Name[0].ToString().ToLower() + " ";
                    }
                    else vizualnaReprezentacija += " ";
                }
                vizualnaReprezentacija += "\n";
            }
            return vizualnaReprezentacija;
        }

        private void SumAllPieces()
        {
            foreach(Square square in _board)
            {
                if (square.Piece != null && square.Piece.Side == Side.White) _whitePieces.Add(square.Piece);
                if (square.Piece != null && square.Piece.Side == Side.Black) _blackPieces.Add(square.Piece);
            }
        }

        private void CalculatePossibleMoves(Side side)
        {
            SumAllPieces();

            if(side == Side.White)
            {
                foreach(Piece piece in _whitePieces)
                {
                    piece.CalculatePossibleMoves(side,_board);
                }
            }
            if(side == Side.Black)
            {
                foreach(Piece piece in _blackPieces)
                {
                    piece.CalculatePossibleMoves(side,_board);
                }
            }
        }

        public bool CheckGameStatus()
        {
            return _status;
        }
    }
}