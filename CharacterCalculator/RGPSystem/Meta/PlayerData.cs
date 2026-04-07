using CharacterCalculator.RGPSystem.Characteristcs;

namespace CharacterCalculator.RGPSystem.Meta
{
    internal class PlayerData
    {
        public List<Rate> Rates { get; set; }
        public List<Branch> Branches { get; set; }
        public List<Buff> Buffs { get; set; }

        public PlayerData()
        {

        }

        public static PlayerData CreateDefault()
        {
            PlayerData playerData = new PlayerData();

            playerData.Rates =
            [
                new Rate(Characteristics.HP),
                new Rate(Characteristics.INSPIRATION_HP),
                new Rate(Characteristics.POISON_RESISTENCE),
                new Rate(Characteristics.ARMOR),
                new Rate(Characteristics.ACTION_POINTS),
                new Rate(Characteristics.STRESS_RESISTENCE),
                new Rate(Characteristics.MP),
                new Rate(Characteristics.MANA_POOL_DURABILITY),
                new Rate(Characteristics.MAGIC_LEARNING_SPEED),
                new Rate(Characteristics.INVENTION_SPEED),
                new Rate(Characteristics.LANGUAGE_LEARNING_SPEED),
                new Rate(Characteristics.DISCARD),
                new Rate(Characteristics.CELL_MAGIC),
            ];

            playerData.Branches = new List<Branch>();
            playerData.Branches.Add(new Branch()
            {
                Name = Characteristcs.Branches.BODY,
                Characteristics = new List<Characteristic>()
                    {
                        new Characteristic()
                        {
                            Name = Characteristics.STRENGTH,
                            Coef = 1f,
                            Level = 1,
                            TotalLevel = 1,
                        },
                        new Characteristic()
                        {
                            Name = Characteristics.AGILITY,
                            Coef = 1f,
                            Level = 1,
                            TotalLevel = 1,
                        },
                        new Characteristic()
                        {
                            Name = Characteristics.STAMINA,
                            Coef = 1f,
                            Level = 1,
                            TotalLevel = 1,
                        },
                        new Characteristic()
                        {
                            Name = Characteristics.REPRODUCTION,
                            Coef = 1f,
                            Level = 1,
                            TotalLevel = 1,
                        },
                    }
            });

            playerData.Branches.Add(new Branch()
            {
                Name = Characteristcs.Branches.MIND,
                Characteristics = new List<Characteristic>()
                    {
                        new Characteristic()
                        {
                            Name = Characteristics.ORATORY,
                            Coef = 1f,
                            Level = 1,
                            TotalLevel = 1,
                        },
                        new Characteristic()
                        {
                            Name = Characteristics.INTELLIGENCE,
                            Coef = 1f,
                            Level = 1,
                            TotalLevel = 1,
                        },
                        new Characteristic()
                        {
                            Name = Characteristics.MEMORY,
                            Coef = 1f,
                            Level = 1,
                            TotalLevel = 1,
                        },
                        new Characteristic()
                        {
                            Name = Characteristics.ATTENTIVENESS,
                            Coef = 1f,
                            Level = 1,
                            TotalLevel = 1,
                        },
                    }
            });

            playerData.Branches.Add(new Branch()
            {
                Name = Characteristcs.Branches.SPIRIT,
                Characteristics = new List<Characteristic>()
                    {
                         new Characteristic()
                        {
                            Name = Characteristics.MAGIC,
                            Coef = 1f,
                            Level = 1,
                            TotalLevel = 1,
                        },
                        new Characteristic()
                        {
                            Name = Characteristics.COMPOSURE,
                            Coef = 1f,
                            Level = 1,
                            TotalLevel = 1,
                        },
                        new Characteristic()
                        {
                            Name = Characteristics.STABILITY,
                            Coef = 1f,
                            Level = 1,
                            TotalLevel = 1,
                        },
                        new Characteristic()
                        {
                            Name = Characteristics.MANA_POOL,
                            Coef = 1f,
                            Level = 1,
                            TotalLevel = 1,
                        },
                    }
            });

            playerData.Buffs = new List<Buff>();
            playerData.Buffs.Add(new Buff()
            {
                Characteristics = new List<string>()
                    {
                        Characteristics.STRENGTH,
                        Characteristics.AGILITY,
                    },
                Name = "TestBuff",
                Amount = 2f
            });

            return playerData;
        }

        public Characteristic GetCharacteristic(string name)
        {
            foreach (var branch in Branches)
            {
                foreach (var characteristic in branch.Characteristics)
                {
                    if (characteristic.Name == name)
                    {
                        return characteristic;
                    }
                }
            }

            return null;
        }

        public List<Buff> GetBuffsToCharacteristic(string name)
        {
            return Buffs
                .Where(buff => buff.Characteristics.Contains(name))
                .ToList();
        }
    }
}
