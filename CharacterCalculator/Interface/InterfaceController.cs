using CharacterCalculator.RGPSystem.Characteristcs;
using CharacterCalculator.RGPSystem.Meta;
using System.Reflection.PortableExecutable;
using System.Text;

namespace CharacterCalculator.Interface
{
    internal class InterfaceController
    {
        private readonly IPersistentData _persistentData;

        public InterfaceController(IPersistentData data)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            _persistentData = data;
        }

        public void PrintCharacterInfo()
        {
            PrintPlayerRates();
            InterfaceEx.PrintSpliter();
            PrintPlayerCharacteristics();
        }

        private void PrintPlayerCharacteristics()
        {
            InterfaceEx.PrintCharacteristicTableTip();

            foreach (var branch in _persistentData.PlayerData.Branches)
            {
                InterfaceEx.PrintBranch(
                    branch.Name,
                    branch.Level,
                    branch.Coef,
                    _persistentData.PlayerData.GetBuffsToCharacteristic(branch.Name));

                Console.WriteLine();

                foreach (var characteristic in branch.Characteristics)
                {
                    InterfaceEx.PrintCharacteristic(
                        characteristic.Name,
                        characteristic.Level,
                        characteristic.Coef,
                        characteristic.TotalLevel,
                        _persistentData.PlayerData.GetBuffsToCharacteristic(characteristic.Name));
                }

                InterfaceEx.PrintSpliter();
            }
        }

        private void PrintPlayerRates()
        {
            InterfaceEx.PrintRateTableTip();

            foreach (var rate in _persistentData.PlayerData.Rates)
            {
                InterfaceEx.PrintRate(
                    rate.Name,
                    rate.Value,
                    _persistentData.PlayerData.GetBuffsToCharacteristic(rate.Name));
            }
        }
    }
}
