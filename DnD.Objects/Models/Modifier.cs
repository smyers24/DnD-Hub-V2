using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Objects
{
    public class Modifier
    {
        public ModifierType ModifierType { get; set; }

        public int Value { get; set; }

        public string GetModifierCode(ModifierType type)
        {
            switch (type)
            {
                case ModifierType.Charisma:
                    return "CHA";

                case ModifierType.Constitution:
                    return "CON";

                case ModifierType.Dexterity:
                    return "DEX";

                case ModifierType.Intelligence:
                    return "INT";

                case ModifierType.Strength:
                    return "STR";

                case ModifierType.Wisdom:
                    return "WIS";

                default:
                    break;
            }

            return string.Empty;
        }

        public override string ToString()
        {
            return ModifierType.ToString();
        }
    }
}
