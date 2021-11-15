using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Objects
{
    public class Ability
    {
        public string Name { get; set; }
    
        public AbilityType AbilityType { get; set; }

        public int Value { get;set; }   

        public int Modifier { get; set; }
    }
}
