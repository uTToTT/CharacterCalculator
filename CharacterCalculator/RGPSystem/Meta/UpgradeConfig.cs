namespace CharacterCalculator.RGPSystem.Meta
{
    internal class UpgradeConfig
    {
        public List<Upgrade> Upgrades { get; set; }

        public UpgradeConfig()
        {

        }

        public static UpgradeConfig CreateDefault()
        {
            UpgradeConfig config = new UpgradeConfig();

            config.Upgrades = new List<Upgrade>();


            /// Body ///

            #region STRENGTH

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.STRENGTH,
                EveryLevel = 1,
            });

            #endregion

            #region AGILITY

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.AGILITY,
                EveryLevel = 1,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.AGILITY,
                        Amount = 10,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.ACTION_POINTS,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.AGILITY,
                EveryLevel = 5,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.AGILITY,
                        Amount = 20,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.ACTION_POINTS,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.AGILITY,
                EveryLevel = 10,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.AGILITY,
                        Amount = 50,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.ACTION_POINTS,
                        }
                    }
                }
            });

            #endregion

            #region STAMINA

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.STAMINA,
                EveryLevel = 1,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.STAMINA,
                        Amount = 10,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.HP,
                        }
                    },
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.STAMINA,
                        Amount = 1,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.POISON_RESISTENCE,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.STAMINA,
                EveryLevel = 5,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.STAMINA,
                        Amount = 20,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.HP,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.STAMINA,
                EveryLevel = 10,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.STAMINA,
                        Amount = 50,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.HP,
                        }
                    },
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.STAMINA,
                        Amount = 1,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.ARMOR,
                        }
                    }
                }
            });

            #endregion

            #region REPRODUCTION

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.REPRODUCTION,
                EveryLevel = 1,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.REPRODUCTION,
                        Amount = 0.01f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.STRENGTH,
                            Characteristcs.Characteristics.AGILITY,
                            Characteristcs.Characteristics.STAMINA,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.REPRODUCTION,
                EveryLevel = 10,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.REPRODUCTION,
                        Amount = 0.1f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.STRENGTH,
                            Characteristcs.Characteristics.AGILITY,
                            Characteristcs.Characteristics.STAMINA,
                        }
                    },
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.REPRODUCTION,
                        Amount = 0.3f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.BODY,
                        }
                    }
                }
            });

            #endregion

            /// Mind

            #region ORATORY 

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.ORATORY,
                EveryLevel = 1,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.ORATORY,
                        Amount = 1f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.DISCARD,
                        }
                    }
                }
            });

            #endregion

            #region INTELLIGENCE

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.INTELLIGENCE,
                EveryLevel = 2,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.INTELLIGENCE,
                        Amount = 1f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.INVENTION_SPEED,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.INTELLIGENCE,
                EveryLevel = 5,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.INTELLIGENCE,
                        Amount = 0.1f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.MIND,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.INTELLIGENCE,
                EveryLevel = 10,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.INTELLIGENCE,
                        Amount = 0.05f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.ORATORY,
                            Characteristcs.Characteristics.MEMORY,
                            Characteristcs.Characteristics.ATTENTIVENESS,
                        }
                    },
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.INTELLIGENCE,
                        Amount = 0.03f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.MAGIC,
                            Characteristcs.Characteristics.COMPOSURE,
                            Characteristcs.Characteristics.STABILITY,
                            Characteristcs.Characteristics.MANA_POOL,
                        }
                    }
                }
            });

            #endregion

            #region MEMORY

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.MEMORY,
                EveryLevel = 1,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.MEMORY,
                        Amount = 1f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.CELL_MAGIC,
                        }
                    },
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.MEMORY,
                        Amount = 0.1f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.LANGUAGE_LEARNING_SPEED,
                        }
                    }
                }
            });

            #endregion

            #region ATTENTIVENESS

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.ATTENTIVENESS,
                EveryLevel = 0,
            });

            #endregion

            /// Spirit

            #region MAGIC

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.MAGIC,
                EveryLevel = 1,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.MAGIC,
                        Amount = 0.01f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.COMPOSURE,
                            Characteristcs.Characteristics.STABILITY,
                            Characteristcs.Characteristics.MANA_POOL,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.MAGIC,
                EveryLevel = 10,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.MAGIC,
                        Amount = 0.1f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.COMPOSURE,
                            Characteristcs.Characteristics.STABILITY,
                            Characteristcs.Characteristics.MANA_POOL,
                            Characteristcs.Characteristics.SPIRIT,
                        }
                    }
                }
            });

            #endregion

            #region COMPOSURE

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.COMPOSURE,
                EveryLevel = 1,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.COMPOSURE,
                        Amount = 10f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.STRESS_RESISTENCE,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.COMPOSURE,
                EveryLevel = 5,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.COMPOSURE,
                        Amount = 20f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.STRESS_RESISTENCE,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.COMPOSURE,
                EveryLevel = 10,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.COMPOSURE,
                        Amount = 50f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.STRESS_RESISTENCE,
                        }
                    }
                }
            });

            #endregion

            #region STABILITY

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.STABILITY,
                EveryLevel = 1,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.STABILITY,
                        Amount = 5f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.INSPIRATION_HP,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.STABILITY,
                EveryLevel = 5,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.STABILITY,
                        Amount = 10f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.INSPIRATION_HP,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.STABILITY,
                EveryLevel = 10,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.STABILITY,
                        Amount = 25f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.INSPIRATION_HP,
                        }
                    }
                }
            });

            #endregion

            #region MANA_POOL

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.MANA_POOL,
                EveryLevel = 1,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.MANA_POOL,
                        Amount = 5f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.MP,
                        }
                    },
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.MANA_POOL,
                        Amount = 1f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.MANA_POOL_DURABILITY,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.MANA_POOL,
                EveryLevel = 5,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.MANA_POOL,
                        Amount = 20f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.MP,
                        }
                    },
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.MANA_POOL,
                        Amount = 3f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.MANA_POOL_DURABILITY,
                        }
                    }
                }
            });

            config.Upgrades.Add(new Upgrade()
            {
                Owner = Characteristcs.Characteristics.MANA_POOL,
                EveryLevel = 10,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.MANA_POOL,
                        Amount = 50f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.MP,
                        }
                    },
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.MANA_POOL,
                        Amount = 5f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.MANA_POOL_DURABILITY,
                        }
                    },
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.MANA_POOL,
                        Amount = 0.01f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.MAGIC_LEARNING_SPEED,
                        }
                    }
                }
            });

            #endregion

            return config;
        }

        public List<Buff> GetBuffsToCharacteristic(string name)
        {
            return Upgrades
                .SelectMany(upgrade => upgrade.Buffs)
                .Where(buff => buff.Characteristics.Contains(name))
                .ToList();
        }

        public List<Upgrade> GetUpgradesToCharacteristic(string name)
        {
            return Upgrades
                .Where(upgrade => upgrade.Buffs
                    .Any(buff => buff.Characteristics.Contains(name)))
                .ToList();
        }
    }
}
