using CharacterCalculator.RGPSystem.Meta;

namespace CharacterCalculator.RGPSystem.Calculator
{
    internal class CharacteristicCalculator
    {
        private readonly IPersistentData _data;
        private readonly UpgradeConfig _upgradeConfig;

        public CharacteristicCalculator(IPersistentData data, UpgradeConfig upgradeConfig)
        {
            _data = data;
            _upgradeConfig = upgradeConfig;
        }

        public void CalcTotalLevel()
        {
            foreach (var branch in _data.PlayerData.Branches)
            {
                foreach (var characteristic in branch.Characteristics)
                {
                    characteristic.TotalLevel = (int)Math.Round(
                        (double)characteristic.Level * (double)characteristic.Coef,
                        MidpointRounding.AwayFromZero);
                }
            }
        }

        public void SetPlayerCoefDefault()
        {
            foreach (var branch in _data.PlayerData.Branches)
            {
                branch.Coef = 1f;
                foreach (var characteristic in branch.Characteristics)
                {
                    characteristic.Coef = 1f;
                }
            }
        }

        public void CalcPlayerBuffs()
        {
            _data.PlayerData.Buffs.Clear();

            foreach (var upgrade in _upgradeConfig.Upgrades)
            {
                if (upgrade.EveryLevel <= 0)
                    continue;

                var owner = _data.PlayerData.GetCharacteristic(upgrade.Owner);
                var count = owner.TotalLevel / upgrade.EveryLevel;

                if (count <= 0)
                    continue;

                _data.PlayerData.Buffs.AddRange(
                    upgrade.Buffs.Select(buff => new Buff
                    {
                        Name = buff.Name,
                        Amount = MathF.Round(buff.Amount * count, 2),
                        Characteristics = new List<string>(buff.Characteristics)
                    })
                );
            }
        }

        public void CalcCoef()
        {
            foreach (var branch in _data.PlayerData.Branches)
            {
                foreach (var characteristic in branch.Characteristics)
                {
                    var buffs = _data.PlayerData.GetBuffsToCharacteristic(characteristic.Name);

                    if (buffs.Count == 0)
                        continue;

                    foreach (var buff in buffs)
                    {
                        characteristic.Coef += buff.Amount;
                    }
                }
            }

            foreach (var branch in _data.PlayerData.Branches)
            {
                var buffs = _data.PlayerData.GetBuffsToCharacteristic(branch.Name);

                if (buffs.Count == 0)
                    continue;

                foreach (var buff in buffs)
                {
                    branch.Coef += buff.Amount;
                }
            }
        }

        public void SetRatesDefault()
        {
            foreach (var rate in _data.PlayerData.Rates)
            {
                rate.Value = 0;
            }
        }

        public void CalcRates()
        {
            foreach (var rate in _data.PlayerData.Rates)
            {
                var buffs = _data.PlayerData.GetBuffsToCharacteristic(rate.Name);

                if (buffs.Count == 0)
                    continue;

                foreach (var buff in buffs)
                {
                    rate.Value += buff.Amount;
                }
            }
        }
    }
}
