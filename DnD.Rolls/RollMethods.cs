using DnD.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Rolls
{
    public static class RollFunctions
    {       
        public static int RollCalc(int diceQuantity, int diceValue, int modifier)
        {          
            int result = Roll(diceQuantity, diceValue);

            result += modifier;

            return result;
        }

        public static int Roll(int numberOfRolls, int dieValue)
        {
            Random rollSeed = new();
            var result = 0;

            for (int i = 0; i < numberOfRolls; i++)
            {
                result += rollSeed.Next(1, dieValue + 1);
            }
            
            return result;
        }

        public static RollResults GetRollResults(string[] rollData)
        {
            var results = new RollResults
            {
                IndividualRolls = new int[rollData.Length]
            };

            for (var i =0; i < rollData.Length; i++)
            {
                var rollInfo = ParseRoll.GetRollInformation(rollData[i]);

                results.IndividualRolls[i] = ProcessRollInfo(rollInfo);
            }

            results.Total = results.IndividualRolls.Sum();

            return results;
        }

        private static int ProcessRollInfo(RollInformation rollInfo)
        {
            var sign = rollInfo.IsPositive ? 1 : 0;

            if (rollInfo.Modifier is not null)
            {
                return (int)rollInfo.Modifier * sign;
            }
            if (rollInfo.DieValue is not null && rollInfo.NumberOfDice is not null)
            {
                return Roll((int)rollInfo.NumberOfDice, (int)rollInfo.DieValue) * sign;
            }

            return 0;
        }
    }
}
