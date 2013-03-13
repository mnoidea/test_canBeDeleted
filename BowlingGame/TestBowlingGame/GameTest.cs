using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace TestBowlingGame
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void CreateGame()
        {
            Game game = new Game();
        }

        [TestMethod]
        public void RollOnePinGame()
        {
            Game game = new Game();
            game.Roll(1);
        }

        [TestMethod]
        public void Game_RollAllZeros_ShouldReturnZero()
        {
            var game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }
            Assert.AreEqual(0, game.Score());
        }

        [TestMethod]
        public void Game_RollAllOnes_ShouldReturn20()
        {
            var game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }
            Assert.AreEqual(20,game.Score());
        }
    }
}
