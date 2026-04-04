using CharacterCalculator.RGPSystem.Characteristcs;

using Branches = CharacterCalculator.RGPSystem.Characteristcs.Branches;

namespace CharacterCalculator.RGPSystem.Meta
{
    internal class PlayerData 
    {
        public List<Branch> Branches {  get; set; }
        public List<Buff> Buffs { get; set; }

        public PlayerData()
        {
            Branches = new List<Branch>();
            Branches.Add(new Branch()
            {
                Name = Characteristcs.Branches.BODY,
                Characteristics = new List<Characteristic>()
                    {
                        new Characteristic()
                        {
                            Name = Characteristics.STREGTH,
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

            Branches.Add(new Branch()
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

            Branches.Add(new Branch()
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

            Buffs = new List<Buff>();
            Buffs.Add(new Buff()
            {
                Characteristics = new List<string>()
                    {
                        Characteristics.STREGTH,
                        Characteristics.AGILITY,
                    },
                Name = "TestBuff",
                Amount = 2f
            });
        }
    }
}
