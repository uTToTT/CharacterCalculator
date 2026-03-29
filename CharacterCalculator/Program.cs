using CharacterCalculator.Interface;
using System.Text;

namespace CharacterCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            var @interface = new InterfaceController();

            @interface.PrintCharacterInfo();

            Console.ReadKey();
        }
    }
}
