using NUnit.Framework;

namespace TicTacToe
{
    class TicTacToeTableTest
    {
        private static readonly TicTacToeTable _TicTacToeTable = new TicTacToeTable();

        [Test]
        public void TestHorizontalWin()
        {
            Assert.That(_TicTacToeTable.MakeAMove(0, 0, 1), Is.EqualTo(0));
            Assert.That(_TicTacToeTable.MakeAMove(0, 1, 1), Is.EqualTo(0));
            Assert.That(_TicTacToeTable.MakeAMove(0, 2, 1), Is.EqualTo(1));
        }

        [Test]
        public void TestVerticalWin()
        {
            _TicTacToeTable.NewGame();
            Assert.That(_TicTacToeTable.MakeAMove(0, 0, 1), Is.EqualTo(0));
            Assert.That(_TicTacToeTable.MakeAMove(1, 0, 1), Is.EqualTo(0));
            Assert.That(_TicTacToeTable.MakeAMove(2, 0, 1), Is.EqualTo(1));
        }
    }
}
