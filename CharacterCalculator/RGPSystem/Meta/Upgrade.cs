using System.Text;

namespace CharacterCalculator.RGPSystem.Meta
{
    internal class Upgrade
    {
        public string Owner { get; set; }
        public int EveryLevel { get; set; }

        public List<Buff> Buffs { get; set; }


        public Upgrade()
        {
            Buffs = new List<Buff>();
            EveryLevel = 1;
        }

        public List<Buff> Apply(Characteristic toBuff, Characteristic buffOwner)
        {
            var totalLevel = buffOwner.TotalLevel;
            int countToUpgrade = (int)(totalLevel / EveryLevel);

            if(countToUpgrade == 0) { return null; }

            var buffs = Buffs.Where(buff => buff.Characteristics.Contains(toBuff.Name)).ToList();
            var totalBuff = buffs.Sum(buff => buff.Amount);

            toBuff.Coef += totalBuff * countToUpgrade;
            return buffs;
            //Console.WriteLine(
            //    $"Add [{totalBuff} * {countToUpgrade} = {totalBuff*countToUpgrade}] to [{toBuff.Name}] by [{Owner}].\n" +
            //    $"[{toBuff.Name}] coef is [{toBuff.Coef}]\n" +
            //    $"[{toBuff.Name}] totalLevel is [{toBuff.TotalLevel}]\n" +
            //    $"Every level upgrade is [{EveryLevel}]\n");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Upgrade");
            sb.AppendLine($"Every {EveryLevel}");
            sb.AppendLine($"Buffs:[");

            foreach (var buff in Buffs)
            {
                sb.AppendLine(buff.ToString());
                sb.AppendLine();
            }

            sb.AppendLine($"]");

            return sb.ToString();
        }
    }
}
