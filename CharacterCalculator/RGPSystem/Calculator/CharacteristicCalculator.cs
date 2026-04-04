using CharacterCalculator.RGPSystem.Meta;

namespace CharacterCalculator.RGPSystem.Calculator
{
    internal class CharacteristicCalculator
    {
        private readonly IPersistentData _data;

        public CharacteristicCalculator(IPersistentData data)
        {
            _data = data;
        }
    }
}
