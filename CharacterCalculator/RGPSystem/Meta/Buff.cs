using System.Text;

namespace CharacterCalculator.RGPSystem.Meta
{
    internal class Buff
    {
        public string Name { get; set; }
        public float Amount { get; set; }
        public List<string> Characteristics { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\tBuff");
            sb.AppendLine($"\tName: [{Name}];");
            sb.AppendLine($"\tAmount: [{Amount}];");
            sb.AppendLine($"\tTo Characteristic:[");

            foreach (var characteristic in Characteristics)
            {
                sb.AppendLine($"\t\t[{characteristic}],");
            }

            sb.AppendLine("\t];");

            return sb.ToString();
        }

        public string ToShortString()
        {
            return $"([{Amount}] - {Name});";
        }
    }
}
