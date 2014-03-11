using NUnit.Framework;

namespace TicTacToe
{
    class TicTacToeTableTest
    {
        private static readonly TicTacToeTable TicTacToeTable = new TicTacToeTable();

        [Test]
        public void TestHorizontalWin()
        {
            TicTacToeTable.NewGame();
            Assert.That(TicTacToeTable.MakeAMove(0, 0, 1), Is.EqualTo(0));
            Assert.That(TicTacToeTable.MakeAMove(0, 1, 1), Is.EqualTo(0));
            Assert.That(TicTacToeTable.MakeAMove(0, 2, 1), Is.EqualTo(1));
        }

        [Test]
        public void TestVerticalWin()
        {
            TicTacToeTable.NewGame();
            Assert.That(TicTacToeTable.MakeAMove(0, 0, 1), Is.EqualTo(0));
            Assert.That(TicTacToeTable.MakeAMove(1, 0, 1), Is.EqualTo(0));
            Assert.That(TicTacToeTable.MakeAMove(2, 0, 1), Is.EqualTo(1));
        }

        [Test]
        public void TestDiagonalWin()
        {
            TicTacToeTable.NewGame();
            Assert.That(TicTacToeTable.MakeAMove(0, 0, 1), Is.EqualTo(0));
            Assert.That(TicTacToeTable.MakeAMove(1, 1, 1), Is.EqualTo(0));
            Assert.That(TicTacToeTable.MakeAMove(2, 2, 1), Is.EqualTo(1));
        }

        [Test]
        public void TestBadIntegerInput()
        {
            TicTacToeTable.NewGame();
            Assert.That(TicTacToeTable.MakeAMove(0, 0, 9), Is.EqualTo(99));
            Assert.That(TicTacToeTable.MakeAMove(1, 9, 1), Is.EqualTo(99));
            Assert.That(TicTacToeTable.MakeAMove(9, 2, 1), Is.EqualTo(99));
        }

    }
}
