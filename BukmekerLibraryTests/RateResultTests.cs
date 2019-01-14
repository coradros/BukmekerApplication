using Microsoft.VisualStudio.TestTools.UnitTesting;
using BukmekerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukmekerLibrary.Tests
{
    [TestClass()]
    public class RateResultTests
    {
        Game newGame;
        Rate newRate;

        //public void Prepare()
        //{
        //    newGame = new Game("Зенит", "Крылья советов", 3, 6);
        //    newRate = new Rate(0, newGame);
        //    newRate.Params = new RateParams(100);
        //}

        [TestMethod]
        public void TestResultCount()
        {
            newGame = new Game("Зенит", "Крылья советов", 3, 6);
            newRate = new Rate(0, newGame);
            newRate.Params = new RateParams(100);

            string[] result = new RateResult().GetResultInfo(newGame, newRate);
            Assert.AreEqual(result.Length, 2);
        }

        //[TestMethod]
        //public void TestResultMessageFirst()
        //{
        //    string[] result = new RateResult().GetResultInfo(newGame, newRate);
        //    Assert.AreEqual(result[0], "Победила команда: " + newGame.NameTeamB);
        //}

        //[TestMethod]
        //public void TestResultMessageSecond()
        //{
        //    string[] result = new RateResult().GetResultInfo(newGame, newRate);
        //    Assert.AreEqual(result[1], "Увы, в этот раз вы проиграли, приходите к нам еще");
        //}
    }
}