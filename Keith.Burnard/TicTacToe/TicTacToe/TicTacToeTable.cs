namespace TicTacToe
{
    class TicTacToeTable
    {
        private const int Player1 = 1;
        private const int Player2 = 2;

        public bool PlayerOneWins { get; private set; }
        public bool PlayerTwoWins { get; private set; }

        public string ReturnMessage { get; private set; }

        int[,] _ticTacToeTable = new int[3,3];

        public void NewGame()
        {
            _ticTacToeTable = new int[3, 3];
            PlayerOneWins = false;
            PlayerTwoWins = false;
            ReturnMessage = "";
        }

        public int MakeAMove(int row, int column, int player)
        {
            bool isTheInputGood = ValidateTheInput(row, column, player);

            if (!isTheInputGood) return 99;

            _ticTacToeTable[row, column] = player;

            CheckForAWinner();
            if (PlayerOneWins)
            {
                return Player1;
            }
            return PlayerTwoWins ? Player2 : 0;
        }

        private bool ValidateTheInput(int row, int column, int player)
        {
            if (row < 0 || row > 2)
            {
                ReturnMessage = "The row must be 0, 1, or 2";
                return false;
            }
            if (column < 0 || column > 2)
            {
                ReturnMessage = "The column must be 0, 1, or 2";
                return false;
            }
            if (player == Player1 || player == Player2) return true;
            ReturnMessage = "The game only has 2 players";
            return false;
        }

        private void CheckForAWinner()
        {
            CheckForHorizontalWinner();
            CheckForVerticalWinner();
            CheckForDiagonalWinner();
        }

        private void CheckForDiagonalWinner()
        {
            if ((_ticTacToeTable[0, 0] == Player1 && _ticTacToeTable[1, 1] == Player1 && _ticTacToeTable[2, 2] == Player1) ||
            (_ticTacToeTable[0, 2] == Player1 && _ticTacToeTable[1, 1] == Player1 && _ticTacToeTable[2, 0] == Player1))
            {
                PlayerOneWins = true;
            }
            if ((_ticTacToeTable[0, 0] == Player2 && _ticTacToeTable[1, 1] == Player2 && _ticTacToeTable[2, 2] == Player2) ||
            (_ticTacToeTable[0, 2] == Player2 && _ticTacToeTable[1, 1] == Player2 && _ticTacToeTable[2, 0] == Player2))
            {
                PlayerTwoWins = true;
            }
        }

        private void CheckForVerticalWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (_ticTacToeTable[0, i] == Player1 && _ticTacToeTable[1, i] == Player1 && _ticTacToeTable[2, i] == Player1)
                {
                    PlayerOneWins = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (_ticTacToeTable[0,i] == Player2 && _ticTacToeTable[1, i] == Player2 && _ticTacToeTable[2, i] == Player2)
                {
                    PlayerTwoWins = true;
                }
            }
        }

        private void CheckForHorizontalWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (_ticTacToeTable[i, 0] == Player1 && _ticTacToeTable[i, 1] == Player1 && _ticTacToeTable[i, 2] == Player1)
                {
                    PlayerOneWins = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (_ticTacToeTable[i, 0] == Player2 && _ticTacToeTable[i, 1] == Player2 && _ticTacToeTable[i, 2] == Player2)
                {
                    PlayerTwoWins = true;
                }
            }
        }
    }
}
