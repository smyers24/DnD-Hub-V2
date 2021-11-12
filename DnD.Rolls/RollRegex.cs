using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Smyers.Extensions;

namespace DnD.Rolls
{
    public static class RollRegex
    {
        public static void ParseRoll (String roll)
        {
            roll = roll.RemoveSpaces();
            var rx = new Regex("([1-9]\\d*)?d([1-9]\\d*)([/x][1-9]\\d*)?([+-]\\d+)?");
            Match RegexMatch = Regex.Match(roll, "([1-9]\\d*)?d([1-9]\\d*)([/x][1-9]\\d*)?([+-]\\d+)?");
            MatchCollection matches = rx.Matches(roll);
            Console.WriteLine(matches.ToString());
        }

        public static int FindDieValue (string controlName)
        {
            return int.Parse(Regex.Match(controlName, @"\d+").Value);
        }
    }
}
