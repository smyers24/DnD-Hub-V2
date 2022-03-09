using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using DnD.Models.Models;
using Smyers.Extensions;

namespace DnD.Rolls
{
    public static class ParseRoll
    {
        public static string[] ParseAsRoll(this string rollString)
        {
            // Remove spaces to ensure the regex works properly
            // Positive lookahead to split string based on +/- and include it with the respective group
            // Example input: 1d4 + 2d6 + 3
            // Output: 1d4, +2d6, +3
            return Regex.Split(rollString.RemoveSpaces(), @"(?=[+-])");
        }

        public static RollInformation GetRollInformation(string roll)
        {
            var rollInfo = new RollInformation();
            (var isPositive, var rollNoSign) = IsRollPositive(roll);
            rollInfo.IsPositive = isPositive;

            var diceInfo = rollNoSign.Split('d');          
            
            if (diceInfo.Length == 1)
            {
                int.TryParse(rollNoSign, out var modifier);
                rollInfo.Modifier = modifier;
            }
            else
            {
                int.TryParse(diceInfo[0], out var numberOfDice);
                int.TryParse(diceInfo[1], out var dieValue);
                rollInfo.DieValue = dieValue;
                rollInfo.NumberOfDice = numberOfDice;
            }

            return rollInfo;
        }


        public static RollResults GetRollResultsFromString(string inputRoll)
        {
            var parsedRoll = inputRoll.ParseAsRoll();
            return RollFunctions.GetRollResults(parsedRoll);
        }

        public static (bool, string) IsRollPositive(string roll)
        {
            if (roll.Contains('-'))
            {
                return (false, roll.Substring(1));
            }
            
            if (roll.Contains('+'))
            {
                return (true, roll.Substring(1));
            }

            return (true, roll);
        }
    }
}
