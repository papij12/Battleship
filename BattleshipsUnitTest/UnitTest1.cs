using Microsoft.VisualStudio.TestTools.UnitTesting;
using Battleship;

namespace BattleshipsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyStringsShouldReturnZero()
        {

            Assert.AreEqual(0, Program.Add(""));
        }

        [TestMethod]
        public void OneStringsShouldReturnTheString()
        {

            Assert.AreEqual(20, Program.Add("20"));
        }
        [TestMethod]
        public void TwoStringsShouldReturnTheSumOfTheStrings()
        {

            Assert.AreEqual(4, Program.Add("2,2"));
        }
        [TestMethod]
        public void MoreThanTwoStringsShouldReturnTheSumOfTheStrings()
        {

            Assert.AreEqual(16, Program.Add("3,4,1,8"));
        }
        [TestMethod]
        public void AMoreThanOneDigitStringsShouldReturnTheSumOfTheStrings()
        {

            Assert.AreEqual(38, Program.Add("11,27"));
        }
        [TestMethod]
        public void NegativeStringsShouldBeIgnored()
        {

            Assert.AreEqual(14, Program.Add("11,-27,3"));
        }
        [TestMethod]
        public void NumbersGreaterThanOneThousandShouldBeIgnored()
        {

            Assert.AreEqual(11, Program.Add("11,1001"));
        }
        [TestMethod]
        public void DifferentDelimitersShouldBeIgnored()
        {

            Assert.AreEqual(17, Program.Add("!3!4!10"));
        }
        [TestMethod]
        public void TheLengthOfTheDelimitersShouldBeIgnored()
        {

            Assert.AreEqual(17, Program.Add("!!!3!!!4!!!10"));
        }
        [TestMethod]
        public void AllTypeOfDelimitersShouldBeIgnored()
        {

            Assert.AreEqual(17, Program.Add("![*]3![*]4![*]10"));
        }
    }
}
    