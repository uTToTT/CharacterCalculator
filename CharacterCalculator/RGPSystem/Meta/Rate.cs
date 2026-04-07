namespace CharacterCalculator.RGPSystem.Meta
{
    internal class Rate
    {
        public string Name { get; set; }
        public float Value { get; set; }

        public Rate() { }

        public Rate(string name)
        {
            Name = name;
            Value = 0;
        }
    }
}
