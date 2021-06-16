using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Objects
{
    public class Action
    {
        public string Name { get; set; }
    
        public string RollString { get; set; }

        public string Description { get; set; }

        public int Damage { get; set; }
    }
}
