using System;
using System.Collections.Generic;
using System.Text;

namespace DnD.Objects
{
    public static class SeedData
    {
        public static IEnumerable<Skill> GenerateSkillsSeedData()
        {
            var skillsList = new List<Skill>
            {
                new Skill()
                {
                    Name = "Acrobatics",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Dexterity
                    }
                },
                new Skill()
                {
                    Name = "Animal Handling",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Wisdom
                    }
                },
                new Skill()
                {
                    Name = "Arcana",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Intelligence
                    }
                },
                new Skill()
                {
                    Name = "Athletics",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Strength
                    }
                },
                new Skill()
                {
                    Name = "Deception",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Charisma
                    }
                },
                new Skill()
                {
                    Name = "History",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Intelligence
                    }
                },
                new Skill()
                {
                    Name = "Insight",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Wisdom
                    }
                },
                new Skill()
                {
                    Name = "Intimidation",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Charisma
                    }
                },
                new Skill()
                {
                    Name = "Investigation",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Intelligence
                    }
                },
                new Skill()
                {
                    Name = "Medicine",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Wisdom
                    }
                },
                new Skill()
                {
                    Name = "Nature",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Intelligence
                    }
                },
                new Skill()
                {
                    Name = "Perception",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Wisdom
                    }
                },
                new Skill()
                {
                    Name = "Performance",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Charisma
                    }
                },
                new Skill()
                {
                    Name = "Persuasion",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Charisma
                    }
                },
                new Skill()
                {
                    Name = "Religion",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Intelligence
                    }
                },
                new Skill()
                {
                    Name = "Sleight of Hand",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Dexterity
                    }
                },
                new Skill()
                {
                    Name = "Stealth",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Dexterity
                    }
                },
                new Skill()
                {
                    Name = "Survival",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Wisdom
                    }
                }
            };

            return skillsList;
        }

        public static IEnumerable<SavingThrow> GenerateSavingThrowsSeedData()
        {
            var savingThrowsList = new List<SavingThrow>
            {
                new SavingThrow()
                {
                    Name = "Strength",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Strength
                    }
                },
                new SavingThrow()
                {
                    Name = "Dexterity",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Dexterity
                    }
                },
                new SavingThrow()
                {
                    Name = "Constitution",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Constitution
                    }
                },
                new SavingThrow()
                {
                    Name = "Intelligence",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Intelligence
                    }
                },
                new SavingThrow()
                {
                    Name = "Wisdom",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Wisdom
                    }
                },
                new SavingThrow()
                {
                    Name = "Charisma",
                    Modifier = new Modifier
                    {
                        ModifierType = ModifierType.Charisma
                    }
                },
            };

            return savingThrowsList;
        }
        public static IEnumerable<Action> GenerateActionsSeedData()
        {
            var actionsList = new List<Action>
            {
                new Action()
                {
                    Name = "Unarmed Strike",
                    Description = "Melee attack, basic hit",
                    RollString = "1d4 + 3"
                }
            };

            return actionsList;
        }
    }
}
