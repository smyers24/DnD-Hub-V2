using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Objects
{
    public class Skill
    {
        public string Name { get; set; }

        public int Bonus { get; set; }

        public Modifier Modifier  {get; set; }

        public bool Proficient { get; set; }
    }
}
