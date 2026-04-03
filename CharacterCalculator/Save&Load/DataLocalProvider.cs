using CharacterCalculator.RGPSystem.Meta;
using Newtonsoft.Json;

namespace CharacterCalculator.Save_Load
{
    internal class DataLocalProvider : IDataProvider
    {
        private readonly string _path;
        private readonly IPersistentData _persistentData;

        public DataLocalProvider(string path, IPersistentData persistentData)
        {
            _path = path;
            _persistentData = persistentData;
        }

        public void Save()
        {
        }

        public bool TryLoad()
        {
            if (!File.Exists(_path))
            {
                return false;
            }

            var text = File.ReadAllText(_path);

            var data = JsonConvert.DeserializeObject<PersistentData>(text);

            if (data == null)
            {
                return false;
                throw new Exception("Failed to deserialize PlayerCharacteristic");
            }

            _persistentData.PlayerData = data.PlayerData;
            return true;
        }

        public void Create()
        {
            if (File.Exists(_path))
                return;

            var defaultData = _persistentData;

            var json = JsonConvert.SerializeObject(defaultData, Formatting.Indented);

            File.WriteAllText(_path, json);
        }
    }
}
