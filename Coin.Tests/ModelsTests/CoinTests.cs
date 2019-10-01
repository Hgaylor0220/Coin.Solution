using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coin;

namespace Coin.Tests
{
    [TestClass]
    public class CoinTest
    {
        [TestMethod]
        public void GetQuarters_RetrievesQuartersFromCoins_True()
        {
            //arrange

            //act
            CoinCal.SetQuarter(5);

            //assert
            Assert.AreEqual(5, CoinCal.GetQuarters());
        }
        // [TestMethod]
        // public void CalculateCoins_AddAQuarter_True()
        // {
        //     //arrange
            
        //     //act
        //     CoinCal.CalculateCoins(25);
            
        //     //assert
        //     Assert.AreEqual(1,CoinCal.GetQuarters());
        // }
    }
}