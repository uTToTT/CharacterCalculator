using CharacterCalculator.Interface;
using CharacterCalculator.RGPSystem.Characteristcs;
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

        static void Main(string[] args)
        {
            InitInterface();
            InitData();

            _interface.PrintCharacterInfo();

            var config =  new UpgradeConfig();
            var json = JsonConvert.SerializeObject(config, Formatting.Indented);

            File.WriteAllText(UPGRADE_PATH, json);

            Console.ReadKey();
        }

        private static void InitInterface()
        {
            _interface = new InterfaceController();
            _interface.InitEcoding();
        }

        private static void InitData()
        {
            var data = new PersistentData();
            var provider = new DataLocalProvider(PATH, data);

            if (!provider.TryLoad())
            {
                data.PlayerData = new PlayerData();
                provider.Create();
            }

            _persistentData = data;
            _dataProvider = provider;
        }

        private static void LoadData()
        {

        }
    }
}
