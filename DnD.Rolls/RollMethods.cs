using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Objects
{
    static class RollFunctions
    {       
        public static int RollCalc(string qty, int dieValue, string modifier)
        {
            bool validRollQty = int.TryParse(qty, out int rollQty);
            int rollQuantity = 1;

            if (validRollQty)
            {
                rollQuantity = rollQty;
            }

            int result = Roll(rollQuantity, dieValue);

            if (!string.IsNullOrEmpty(qty))
            {
                int.TryParse(modifier, out int modValue);
                result += modValue;
            }
            return result;
        }

        public static int Roll(int numberOfRolls, int dieValue)
        {
            Random rollSeed = new Random();
            int result = 0;

            for (int i = 0; i < numberOfRolls; i++)
            {
                result += rollSeed.Next(1, dieValue + 1);
            }
            
            return result;
        }
    }
}
