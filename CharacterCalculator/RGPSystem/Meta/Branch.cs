namespace CharacterCalculator.RGPSystem.Meta
{
    internal class Branch
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public float Coef { get; set; }
        public List<Characteristic> Characteristics { get; set; }
    }
}
