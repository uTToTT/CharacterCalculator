namespace CharacterCalculator.RGPSystem.Meta
{
    internal class UpgradeConfig
    {
        public List<Upgrade> Upgrades { get; set; }

        public UpgradeConfig()
        {
            Upgrades = new List<Upgrade>();


            /// Body ///
            
            #region STRENGTH

            Upgrades.Add(new Upgrade());

            #endregion

            #region AGILITY

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
                EveryLevel = 1,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.REPRODUCTION,
                        Amount = 0.01f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.STREGTH,
                            Characteristcs.Characteristics.AGILITY,
                            Characteristcs.Characteristics.STAMINA,
                        }
                    }
                }
            });

            Upgrades.Add(new Upgrade()
            {
                EveryLevel = 10,
                Buffs = new List<Buff>()
                {
                    new Buff()
                    {
                        Name = Characteristcs.Characteristics.REPRODUCTION,
                        Amount = 0.1f,
                        Characteristics = new List<string>
                        {
                            Characteristcs.Characteristics.STREGTH,
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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
                            Characteristcs.Characteristics.SPIRIT,
                        }
                    }
                }
            });

            #endregion

            #region MEMORY

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade());

            #endregion

            /// Spirit

            #region MAGIC

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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

            Upgrades.Add(new Upgrade()
            {
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
        }
    }
}
