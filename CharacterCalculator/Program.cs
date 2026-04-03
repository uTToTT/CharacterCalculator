using CharacterCalculator.Interface;
using CharacterCalculator.RGPSystem.Characteristcs;
using CharacterCalculator.RGPSystem.Meta;
using CharacterCalculator.Save_Load;

namespace CharacterCalculator
{
    internal class Program
    {
        private const string PATH = "player.txt";

        private static IPersistentData _persistentData;
        private static IDataProvider _dataProvider;
        private static InterfaceController _interface;

        static void Main(string[] args)
        {
            InitInterface();
            InitData();

            _interface.PrintCharacterInfo();

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
                data.PlayerData.Characteristics = new List<Characteristic>();
                data.PlayerData.Characteristics.Add(new Characteristic()
                {
                    Name = Characteristics.STREGTH,
                    Coef = 1.4f,
                    Level = 65,
                    TotalLevel = 0,
                });
                data.PlayerData.Buffs = new List<Buff>();
                data.PlayerData.Buffs.Add(new Buff()
                {
                    Characteristics = new List<string>()
                    {
                        Characteristics.STREGTH,
                        Characteristics.AGILITY,
                    },
                    Name = "TestBuff",
                    Coeff = 2f
                });

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
