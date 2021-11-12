using Microsoft.VisualStudio.TestTools.UnitTesting;
using DnD.Rolls;

namespace DnD.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RollParseRegex_MultipleDice_AssociatesOperators()
        {
            var rollString = "1d6 + 2d4 - 1d12 + 6";
            var parsedRolls = rollString.ParseAsRoll();
            Assert.IsTrue(parsedRolls.Length == 4);
            Assert.IsTrue(parsedRolls[2][0] == '-');
        }
    }
}