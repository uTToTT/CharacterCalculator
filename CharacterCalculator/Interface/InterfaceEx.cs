using CharacterCalculator.RGPSystem.Meta;
using System;
using System.Reflection.Emit;
using System.Text;

namespace CharacterCalculator.Interface
{
    internal static class InterfaceEx
    {
        public static void PrintSpliter()
        {
            Console.WriteLine();
            Console.WriteLine("=================");
            Console.WriteLine();
        }

        public static void PrintCharacteristicTableTip()
        {
            string nameTip = "CHARACTERISTIC";
            string lvlTip = "LEVEL";
            string CfTip = "COEFFICIENT";
            string totalTip = "RESULT";

            Console.WriteLine(
                $"{nameTip,InterfaceConstants.CHARACTERISTIC_PAD}" +
                $"{lvlTip,InterfaceConstants.LEVEL_PAD}" +
                $"{CfTip,InterfaceConstants.COEFF_PAD}" +
                $"{totalTip,InterfaceConstants.TOTAL_LEVEL_PAD}");
        }

        public static void PrintRateTableTip()
        {
            string nameTip = "RATE";
            string valueTip = "VALUE";

            Console.WriteLine(
                $"{nameTip,InterfaceConstants.RATE_PAD}" +
                $"{valueTip,InterfaceConstants.RATE_VALUE_PAD}");
        }

        public static void PrintBranch(string name, int level, float coef, List<Buff> buffs)
        {
            int maxBuffs = buffs.Count;

            string lvl = $"[{level}]";
            string cf = $"[X{coef:F3}]";
            string total = $"[---]";

            string str =
               $"{name,InterfaceConstants.CHARACTERISTIC_PAD}" +
               $"{lvl,InterfaceConstants.LEVEL_PAD}" +
               $"{cf,InterfaceConstants.COEFF_PAD}" +
               $"{total,InterfaceConstants.TOTAL_LEVEL_PAD}";

            Console.Write(str);

            for (int i = 0; i < maxBuffs; i++)
            {
                if (i < buffs.Count)
                {
                    PrintBuff(buffs[i]);
                }
                else
                {
                    Console.Write("".PadRight(InterfaceConstants.BUFF_PAD));
                }
            }

            Console.WriteLine();
        }

        public static void PrintCharacteristic(string characteristic, int level, float coef, int totalLevel, List<Buff> buffs)
        {
            int maxBuffs = buffs.Count;

            string name = characteristic;
            string lvl = $"[{level}]";
            string cf = $"[X{coef:F3}]";
            string total = $"[{totalLevel}]";

            string str =
                $"{name,InterfaceConstants.CHARACTERISTIC_PAD}" +
                $"{lvl,InterfaceConstants.LEVEL_PAD}" +
                $"{cf,InterfaceConstants.COEFF_PAD}" +
                $"{total,InterfaceConstants.TOTAL_LEVEL_PAD}";


            Console.Write(str);

            for (int i = 0; i < maxBuffs; i++)
            {
                if (i < buffs.Count)
                {
                    PrintBuff(buffs[i]);
                }
                else
                {
                    Console.Write("".PadRight(InterfaceConstants.BUFF_PAD));
                }
            }

            Console.WriteLine();
        }

        public static void PrintRate(string rate, float value, List<Buff> buffs)
        {
            int maxBuffs = buffs.Count;

            // RATE
            Console.Write($"{rate,InterfaceConstants.RATE_PAD}");

            // VALUE (green)
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{($"[{value:0.###}]"),InterfaceConstants.RATE_VALUE_PAD}");
            Console.ResetColor();

            for (int i = 0; i < maxBuffs; i++)
            {
                if (i < buffs.Count)
                {
                    PrintBuff(buffs[i]);
                }
                else
                {
                    Console.Write("".PadRight(InterfaceConstants.BUFF_PAD));
                }
            }

            Console.WriteLine();
        }

        private static void PrintBuff(Buff buff)
        {
            string left = "(";
            string right = $" - {buff.Name.Substring(0, 6)});";

            int contentLength =
                left.Length +
                buff.Amount.ToString("0.##").Length +
                right.Length;

            int padding = InterfaceConstants.BUFF_PAD - contentLength;
            if (padding < 0) padding = 0;

            Console.Write(left);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(buff.Amount.ToString("0.##"));
            Console.ResetColor();

            Console.Write(right);

            Console.Write(new string(' ', padding));
        }
    }
}
