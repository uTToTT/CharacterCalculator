using CharacterCalculator.Interface;
using CharacterCalculator.RGPSystem.Calculator;
using CharacterCalculator.RGPSystem.Meta;
using CharacterCalculator.Save_Load;
using Newtonsoft.Json;

namespace CharacterCalculator
{
    internal class Program
    {
        private const string PATH = "player.json";
        private const string UPGRADE_PATH = "UpgradeConfiguration.json";

        private static IPersistentData _persistentData;
        private static IDataProvider _dataProvider;
        private static InterfaceController _interface;
        private static UpgradeConfig _upgradeConfig;
        private static CalculatorController _calculatorController;

        static void Main(string[] args)
        {
            while (true)
            {
                InitData();
                LoadData();
                InitInterface();
                InitCalculator();

                _calculatorController.Calc();

                _interface.PrintCharacterInfo();
                _dataProvider.Save();

                Console.WriteLine("Press any button to recalc");
                Console.ReadKey();
                _calculatorController.Calc();
            }
        }

        #region Init

        private static void InitInterface()
        {
            _interface = new InterfaceController(_persistentData);
        }

        private static void InitCalculator()
        {
            _calculatorController = new CalculatorController(_persistentData, _upgradeConfig);
        }

        private static void InitData()
        {
            var data = new PersistentData();
            _persistentData = data;

            var provider = new DataLocalProvider(PATH, _persistentData);

            if (!provider.TryLoad())
            {
                _persistentData.PlayerData = PlayerData.CreateDefault();
                provider.Create();
            }

            _dataProvider = provider;
        }

        #endregion

        private static void LoadData()
        {
            if (!File.Exists(UPGRADE_PATH))
            {
                var config = UpgradeConfig.CreateDefault();
                var json = JsonConvert.SerializeObject(config, Formatting.Indented);

                File.WriteAllText(UPGRADE_PATH, json);
            }

            var text = File.ReadAllText(UPGRADE_PATH);
            var data = JsonConvert.DeserializeObject<UpgradeConfig>(text);
            _upgradeConfig = data;
        }
    }
}
