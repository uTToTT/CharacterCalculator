using CharacterCalculator.RGPSystem.Meta;

namespace CharacterCalculator.RGPSystem.Calculator
{
    internal class BuffCalculator
    {
        private readonly IPersistentData _data;

        public BuffCalculator(IPersistentData data)
        {
            _data = data;
        }
    }
}
