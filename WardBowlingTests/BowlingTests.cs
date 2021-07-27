using WardBowling;
using Xunit;

namespace WardBowlingTests
{
    public class BowlingTests
    {
        Game game = new Game();

        public void FillGame(int throws, int pins)
        {
            for (int i = 0; i < throws; i++)
            {
                game.Throw(pins);
            }
        }

        [Fact]
        public void TestGutterGame_ScoreShouldBe0()
        {
            FillGame(20, 0);

            int expected = 0;
            int actual = game.CalculateTotalScore();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAllOneGame_ScoreShouldBe20()
        {
            FillGame(20, 1);

            int expected = 20;
            int actual = game.CalculateTotalScore();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPerfectGame_ScoreShouldBe300()
        {
            FillGame(12, 10);

            int expected = 300;
            int actual = game.CalculateTotalScore();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSpareFollowedByThree_ScoreShouldBe16()
        {
            game.Throw(5);
            game.Throw(5);
            game.Throw(3);

            int expected = 16;
            int actual = game.CalculateTotalScore();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStrikeFollowedBySeven_ScoreShouldBe24()
        {
            game.Throw(10);
            game.Throw(3);
            game.Throw(4);

            int expected = 24;
            int actual = game.CalculateTotalScore();

            Assert.Equal(expected, actual);
        }
    }
}
