using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Objects
{
    public class Modifier
    {
        public AbilityType AbilityType { get; set; }

        public int Value { get; set; }

        public string GetModifierCode(AbilityType type)
        {
            switch (type)
            {
                case AbilityType.Charisma:
                    return "CHA";

                case AbilityType.Constitution:
                    return "CON";

                case AbilityType.Dexterity:
                    return "DEX";

                case AbilityType.Intelligence:
                    return "INT";

                case AbilityType.Strength:
                    return "STR";

                case AbilityType.Wisdom:
                    return "WIS";

                default:
                    break;
            }

            return string.Empty;
        }

        public override string ToString()
        {
            return AbilityType.ToString();
        }
    }
}
