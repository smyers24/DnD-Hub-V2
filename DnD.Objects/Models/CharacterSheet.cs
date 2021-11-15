using System.Collections.Generic;
using System.ComponentModel;

namespace DnD.Objects
{
    public class CharacterSheet
    {
        public Character Character { get; set; }

        public BindingList<Action> Actions { get; set; }
        
        public BindingList<Skill> Skills { get; set; }
        
        public BindingList<SavingThrow> SavingThrows { get; set; }

        public BindingList<Ability> Abilities { get; set; }
    }
}