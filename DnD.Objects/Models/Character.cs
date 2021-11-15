using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Objects
{
    public class Character
    {
        public string Name { get; set; }

        public int CurrentHP { get; set; }

        public int MaximumHP { get; set; }

        public int Level { get; set; }

        public int Initiative { get; set; }

        public IEnumerable<SavingThrow> SavingThrows { get; set; }

        public IEnumerable<Skill> Skills { get; set; }

        public IEnumerable<Action> Actions { get; set; }

        public IEnumerable<Ability> Abilities { get; set; }

        public int PassivePerception { get; set; }

        public int WalkingSpeed { get; set; }

        public int ArmorClass { get; set; }

        public int ProficiencyBonus { get; set; }
    }
}
