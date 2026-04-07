using CharacterCalculator.Interface;
using System.Xml.Linq;

namespace CharacterCalculator.RGPSystem.Meta
{
    internal class Characteristic
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public float Coef { get; set; }
        public int TotalLevel { get; set; }

        public override string ToString()
        {
            return
                $"{($"Name [{Name}]"),InterfaceConstants.CHARACTERISTIC_PAD} | " +
                $"{($"Level [{Level}]"),InterfaceConstants.LEVEL_PAD} | " +
                $"{($"Coef [{Coef:0.##}]"),InterfaceConstants.COEFF_PAD} | " +
                $"{($"TotalLevel [{TotalLevel}]"),InterfaceConstants.TOTAL_LEVEL_PAD}";
        }
    }
}
