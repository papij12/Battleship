using Microsoft.VisualStudio.TestTools.UnitTesting;
using Battleship;


namespace BattleshipsUnitTest
{
    [TestClass]

    public class UnitTest1
    {
        int x = 0;
        int y = 0;
        private Game g;
       

        [TestInitialize]
        public void InitializeTheGame()
        {
            g = new Game();
        }

        [TestMethod]
        public void TestSetBattleship()
        {  
            Assert.AreEqual('B', g.SetBattleship(x, y));
        }
        [TestMethod]
        public void TestSetDestroyers()
        {
            Assert.AreEqual('D', g.SetDestroyers(x, y));
        }
        [TestMethod]
        public void TestMissShot()
        { 
            Assert.AreEqual('M', g.IsMissShot(x, y));
        }
        [TestMethod]
        public void TestHitShot()
        {
            Assert.AreEqual('H', g.IsHitShot(x, y));
        }
    }
}
    