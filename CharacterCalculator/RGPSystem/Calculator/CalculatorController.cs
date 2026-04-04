using CharacterCalculator.RGPSystem.Meta;

namespace CharacterCalculator.RGPSystem.Calculator
{
    internal class CalculatorController
    {
        private readonly IPersistentData _data;

        public CalculatorController(IPersistentData data)
        {
            _data = data;
        }


    }
}
