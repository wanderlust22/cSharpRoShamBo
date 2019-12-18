using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoShamBo.Models;
using System.Collections.Generic;

namespace RoShamBo.Tests
{
    [TestClass]
    public class RoShamBoTester
    {
        [TestMethod]
        public void RockBeatScissors_Round_True()
        {
            Player player1 = new Player("rock");
            Player player2 = new Player("scissors");
            Assert.AreEqual(Player.WhoWins(player1, player2), player1);
        }
 
    }
}