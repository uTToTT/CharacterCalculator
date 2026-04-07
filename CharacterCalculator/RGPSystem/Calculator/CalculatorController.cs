using CharacterCalculator.RGPSystem.Meta;

namespace CharacterCalculator.RGPSystem.Calculator
{
    internal class CalculatorController
    {
        private readonly IPersistentData _data;
        private readonly CharacteristicCalculator _characteristicCalculator;
        private readonly UpgradeConfig _upgradeConfig;

        public CalculatorController(IPersistentData data, UpgradeConfig upgradeConfig)
        {
            _data = data;
            _upgradeConfig = upgradeConfig;

            _characteristicCalculator = new CharacteristicCalculator(data, upgradeConfig);
        }

        public void Calc()
        {
            _characteristicCalculator.SetPlayerCoefDefault();
            _characteristicCalculator.SetRatesDefault();

            _characteristicCalculator.CalcTotalLevel();
            _characteristicCalculator.CalcPlayerBuffs();
            _characteristicCalculator.CalcCoef();

            _characteristicCalculator.CalcTotalLevel();
            _characteristicCalculator.CalcPlayerBuffs();

            _characteristicCalculator.CalcRates();
        }
    }
}
