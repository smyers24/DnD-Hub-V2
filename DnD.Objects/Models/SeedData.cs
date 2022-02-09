using System;
using System.Collections.Generic;
using System.Text;

namespace DnD.Objects
{
    public static class SeedData
    {
        public static IList<Skill> GenerateSkillsSeedData()
        {
            var skillsList = new List<Skill>
            {
                new Skill()
                {
                    Name = "Acrobatics",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Dexterity
                    }
                },
                new Skill()
                {
                    Name = "Animal Handling",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Wisdom
                    }
                },
                new Skill()
                {
                    Name = "Arcana",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Intelligence
                    }
                },
                new Skill()
                {
                    Name = "Athletics",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Strength
                    }
                },
                new Skill()
                {
                    Name = "Deception",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Charisma
                    }
                },
                new Skill()
                {
                    Name = "History",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Intelligence
                    }
                },
                new Skill()
                {
                    Name = "Insight",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Wisdom
                    }
                },
                new Skill()
                {
                    Name = "Intimidation",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Charisma
                    }
                },
                new Skill()
                {
                    Name = "Investigation",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Intelligence
                    }
                },
                new Skill()
                {
                    Name = "Medicine",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Wisdom
                    }
                },
                new Skill()
                {
                    Name = "Nature",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Intelligence
                    }
                },
                new Skill()
                {
                    Name = "Perception",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Wisdom
                    }
                },
                new Skill()
                {
                    Name = "Performance",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Charisma
                    }
                },
                new Skill()
                {
                    Name = "Persuasion",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Charisma
                    }
                },
                new Skill()
                {
                    Name = "Religion",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Intelligence
                    }
                },
                new Skill()
                {
                    Name = "Sleight of Hand",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Dexterity
                    }
                },
                new Skill()
                {
                    Name = "Stealth",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Dexterity
                    }
                },
                new Skill()
                {
                    Name = "Survival",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Wisdom
                    }
                }
            };

            return skillsList;
        }

        public static IList<SavingThrow> GenerateSavingThrowsSeedData()
        {
            var savingThrowsList = new List<SavingThrow>
            {
                new SavingThrow()
                {
                    Name = "Strength",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Strength,
                        Value = 0
                    },
                    Value = 12
                },
                new SavingThrow()
                {
                    Name = "Dexterity",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Dexterity,
                        Value = 0
                    },
                    Value = 12
                },
                new SavingThrow()
                {
                    Name = "Constitution",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Constitution,
                        Value = 0
                    },
                    Value = 12
                },
                new SavingThrow()
                {
                    Name = "Intelligence",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Intelligence,
                        Value = 0
                    },
                    Value = 12
                },
                new SavingThrow()
                {
                    Name = "Wisdom",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Wisdom,
                        Value = 0
                    },
                    Value = 12
                },
                new SavingThrow()
                {
                    Name = "Charisma",
                    Modifier = new Modifier
                    {
                        AbilityType = AbilityType.Charisma,
                        Value = 0
                    },
                    Value = 12
                },
            };

            return savingThrowsList;
        }
        public static IList<Action> GenerateActionsSeedData()
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

        public static IList<Ability> GenerateAbilitiesSeedData()
        {
            var abilitiesList = new List<Ability>();

            foreach (var type in Enum.GetValues(typeof(AbilityType)))
            {
                abilitiesList.Add(new Ability
                {
                    Name = type.ToString(),
                    AbilityType = (AbilityType)type,
                    Modifier = 0,
                    Value = 12
                });
            }

            return abilitiesList;
        }
    }
}
