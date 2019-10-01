using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coin;
using System;

namespace Coin.Tests
{
    [TestClass]
    public class CoinTest : IDisposable
    {
        public void Dispose()
        {
            CoinCal.ClearAll();
        }
        
        [TestMethod]
        public void GetQuarters_RetrievesQuartersFromCoins_True()
        {
            //arrange

            //act
            CoinCal.SetQuarter(5);

            //assert
            Assert.AreEqual(5, CoinCal.GetQuarters());
        }
        [TestMethod]
        public void CalculateCoins_AddAQuarter_True()
        {
            //arrange
            
            //act
            CoinCal.CalculateCoins(55);
            
            //assert
            Assert.AreEqual(2,CoinCal.GetQuarters());
        }
        [TestMethod]
        public void CalculateCoins_AddADime_True()
        {
            //arrange

            //act
            CoinCal.CalculateCoins(10);

            //assert
            Assert.AreEqual(1, CoinCal.GetDimes());
        }
        [TestMethod]
        public void CalculateCoins_AddANickel_True()
        {
            //arrange

            //act
            CoinCal.CalculateCoins(5);

            //assert
            Assert.AreEqual(1, CoinCal.GetNickels());
        }
        [TestMethod]
        public void CalculateCoins_AddAPenny_True()
        {
            //arrange

            //act
            CoinCal.CalculateCoins(4);

            //assert
            Assert.AreEqual(4, CoinCal.GetPennies());
        }
        [TestMethod]
        public void CalculateCoins_AddCoins_True()
        {
            //arrange

            //act
            CoinCal.CalculateCoins(37);

            //assert
            Assert.AreEqual(1, CoinCal.GetQuarters());
            Assert.AreEqual(1, CoinCal.GetDimes());
            Assert.AreEqual(2, CoinCal.GetPennies());
        }
    }
}