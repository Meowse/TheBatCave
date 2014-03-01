using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToeTable
    {
        private const int Player1 = 1;
        private const int Player2 = 2;

        public bool PlayerOneWins { get; private set; }
        public bool PlayerTwoWins { get; private set; }

        int[,] _ticTacToeTable = new int[3,3];

        public void NewGame()
        {
            _ticTacToeTable = new int[3, 3];
            PlayerOneWins = false;
            PlayerTwoWins = false;
        }

        public int MakeAMove(int row, int column, int player)
        {
            _ticTacToeTable[row, column] = player;

            CheckForAWinner();

            if (PlayerOneWins)
            {
                return Player1;
            }
            return PlayerTwoWins ? Player2 : 0;
        }

        private void CheckForAWinner()
        {
            CheckForHorizontalWinner();
            CheckForVerticalWinner();
            //CheckForDiagonalWinner();
        }

        private void CheckForDiagonalWinner()
        {
            throw new NotImplementedException();
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
