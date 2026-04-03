namespace CharacterCalculator.Save_Load
{
    internal interface IDataProvider
    {
        bool TryLoad();
        void Save();
    }
}
