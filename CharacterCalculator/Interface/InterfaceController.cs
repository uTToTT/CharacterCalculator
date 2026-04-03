using CharacterCalculator.RGPSystem.Characteristcs;
using System.Text;

namespace CharacterCalculator.Interface
{
    internal class InterfaceController
    {
        private const int CHARACTERISTIC_PAD = -25;
        private const int LEVEL_PAD = 10;
        private const int COEFF_PAD = 15;
        private const int TOTAL_LEVEL_PAD = 15;

        public void InitEcoding()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
        }

        public void PrintCharacterInfo()
        {
            Console.WriteLine("Загальне");
            Console.WriteLine("Ім'я: ");
            Console.WriteLine("Досягення:");
            Console.WriteLine("Раса:");
            Console.WriteLine("Стать:");
            Console.WriteLine("Вік: ");
            Console.WriteLine("Титул: ");
            Console.WriteLine("Клас:");
            Console.WriteLine("");
            Console.WriteLine("Показники");
            Console.WriteLine("Життя: (ХП) (ХПН)");
            Console.WriteLine("Броня: (БР)");
            Console.WriteLine("Очки дії: (ОД)");
            Console.WriteLine("Мана: (МР)");
            Console.WriteLine("Міцність мано-врат: ");
            Console.WriteLine("Швидкість розв'язання вузлів: ");
            Console.WriteLine("Швидкість винаходження: (РВ)");
            Console.WriteLine("Знижка: (Продаж/Купівля)");
            Console.WriteLine("Пам'ять");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            PrintTableTip();
            InterfaceEx.PrintSpliter();
            PrintBodyInfo();
            InterfaceEx.PrintSpliter();
            PrintMindInfo();
            InterfaceEx.PrintSpliter();
            PrintSpiritInfo();
            InterfaceEx.PrintSpliter();
        }



        public void PrintBodyInfo()
        {
            PrintCharacteristic(Characteristics.STREGTH, level: 999, coef: 999.00f, totalLevel: 99999);
            PrintCharacteristic(Characteristics.AGILITY, level: 999, coef: 999.00f, totalLevel: 99999);
            PrintCharacteristic(Characteristics.STABILITY, level: 999, coef: 999.00f, totalLevel: 99999);
            PrintCharacteristic(Characteristics.REPRODUCTION, level: 999, coef: 999.00f, totalLevel: 99999);
        }

        public void PrintMindInfo()
        {
            PrintCharacteristic(Characteristics.ORATORY, level: 999, coef: 999.00f, totalLevel: 99999);
            PrintCharacteristic(Characteristics.INTELLIGENCE, level: 999, coef: 999.00f, totalLevel: 99999);
            PrintCharacteristic(Characteristics.MEMORY, level: 999, coef: 999.00f, totalLevel: 99999);
            PrintCharacteristic(Characteristics.ATTENTIVENESS, level: 999, coef: 999.00f, totalLevel: 99999);
        }

        public void PrintSpiritInfo()
        {
            PrintCharacteristic(Characteristics.MAGIC, level: 999, coef: 999.00f, totalLevel: 99999);
            PrintCharacteristic(Characteristics.COMPOSURE, level: 999, coef: 999.00f, totalLevel: 99999);
            PrintCharacteristic(Characteristics.STABILITY, level: 999, coef: 999.00f, totalLevel: 99999);
            PrintCharacteristic(Characteristics.MANA_POOL, level: 999, coef: 999.00f, totalLevel: 99999);
        }

        private void PrintTableTip()
        {
            string nameTip = "CHARACTERISTIC";
            string lvlTip = "LEVEL";
            string CfTip = "COEFFICIENT";
            string totalTip = "RESULT";

            Console.WriteLine(
                $"{nameTip,CHARACTERISTIC_PAD}" +
                $"{lvlTip,LEVEL_PAD}" +
                $"{CfTip,COEFF_PAD}" +
                $"{totalTip,TOTAL_LEVEL_PAD}");
        }

        private void PrintCharacteristic(string characteristic, int level, float coef, int totalLevel)
        {
            string name = characteristic;
            string lvl = $"[{level}]";
            string cf = $"[X{coef:F2}]";
            string total = $"[{totalLevel}]";

            Console.WriteLine(
                $"{name,CHARACTERISTIC_PAD}" +
                $"{lvl,LEVEL_PAD}" +
                $"{cf,COEFF_PAD}" +
                $"{total,TOTAL_LEVEL_PAD}");
        }
    }
}
