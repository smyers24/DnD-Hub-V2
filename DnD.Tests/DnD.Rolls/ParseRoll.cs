using Microsoft.VisualStudio.TestTools.UnitTesting;
using DnD.Rolls;

namespace DnD.Tests
{
    [TestClass]
    public class ParseRollTests
    {
        [TestMethod]
        public void GetRollResultsFromString_IndividualRollsCorrespondToDieValue()
        {
            var rollString = "1d6 + 2d4 - 1d12 + 6";
            var parsedRolls = Rolls.ParseRoll.GetRollResultsFromString(rollString);
            Assert.IsTrue(parsedRolls.IndividualRolls.Length == 4);
            Assert.IsTrue(parsedRolls.IndividualRolls[0] <= 6);
            Assert.IsTrue(parsedRolls.IndividualRolls[1] <= 8);
            Assert.IsTrue(parsedRolls.IndividualRolls[2] <= 12);
            Assert.IsTrue(parsedRolls.IndividualRolls[3] == 6);
        }

        [TestMethod]
        public void GetRollResultsFromString_TotalIsEqualToSumOfIndividualrolls()
        {
            var rollString = "1d6 + 2d4 - 1d12 + 6";
            var parsedRolls = Rolls.ParseRoll.GetRollResultsFromString(rollString);

            var sum = 0;
            for (var i = 0; i < parsedRolls.IndividualRolls.Length; i++)
            {
                sum += parsedRolls.IndividualRolls[i];
            }

            Assert.IsTrue(sum == parsedRolls.Total);
        }

        [TestMethod]
        public void CheckForSign_AreSignsParsedCorrectly()
        {
            var positiveNoSign = "5";

            (var noSign, _) = Rolls.ParseRoll.IsRollPositive(positiveNoSign);
            Assert.IsTrue(noSign);

            var positiveWithSign = "+5";
            (var sign, _) = Rolls.ParseRoll.IsRollPositive(positiveWithSign);
            Assert.IsTrue(sign);

            var negative = "-5";
            (var negativeSign, _) = Rolls.ParseRoll.IsRollPositive(negative);
            Assert.IsFalse(negativeSign);
        }
    }
}