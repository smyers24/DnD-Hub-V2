using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DnD.Objects
{
    public static class DieRegex
    {
        public static void parseRoll (String roll)
        {

            Regex rx = new Regex("([1-9]\\d*)?d([1-9]\\d*)([/x][1-9]\\d*)?([+-]\\d+)?");
            Match RegexMatch = Regex.Match(roll, "([1-9]\\d*)?d([1-9]\\d*)([/x][1-9]\\d*)?([+-]\\d+)?");
            MatchCollection matches = rx.Matches(roll);
            Console.WriteLine(matches.ToString());
        }

        public static int findDieValue (string controlName)
        {
            return int.Parse(Regex.Match(controlName, @"\d+").Value);
        }

        public static void main(String args)
        {
            //  int amount, die, mult = 1, add = 0;
            //
            //  Regex rx = new Regex("([1-9]\\d*)?d([1-9]\\d*)([/x][1-9]\\d*)?([+-]\\d+)?");
            // Match RegexMatch = Regex.Match(roll, "([1-9]\\d*)?d([1-9]\\d*)([/x][1-9]\\d*)?([+-]\\d+)?");
            ///  // MatchCollection matches = rx.Matches(roll);
            //    Console.WriteLine(matches);
            /*
            matches m = p.matcher("d20");
            if (m.matches())
            {
                amount = (m.group(1) != null) ? Integer.parseInt(m.group(1)) : 1;
                die = Integer.parseInt(m.group(2));
                if (m.group(3) != null)
                {
                    boolean positive = m.group(3).startsWith("x");
                    int val = Integer.parseInt(m.group(3).substring(1));
                    mult = positive ? val : -val;
                }
                if (m.group(4) != null)
                {
                    boolean positive = m.group(4).startsWith("+");
                    int val = Integer.parseInt(m.group(4).substring(1));
                    add = positive ? val : -val;
                }
            }
            else
                System.out.println("No match"); // Do whatever you need
        }
        */
        }


    }
}
