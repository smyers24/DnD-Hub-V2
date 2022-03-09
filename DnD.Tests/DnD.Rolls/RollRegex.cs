using Microsoft.VisualStudio.TestTools.UnitTesting;
using DnD.Rolls;

namespace DnD.Tests
{
    [TestClass]
    public class RollRegexTests
    {
        [TestMethod]
        public void FindDieValue_AreDiceValuesParsedCorrectly()
        {
            var val1 = "1d4";
            var val1Int = RollRegex.FindDieValue(val1);
            Assert.IsTrue(1 == val1Int);

            var val10 = "10d6";
            var val10Int = RollRegex.FindDieValue(val10);
            Assert.IsTrue(6 == val10Int);
        }
    }
}