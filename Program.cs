using RandomNameGenerator;

namespace RandomNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomName = NamesGenerator.GenerateName();
            Console.WriteLine(randomName);

            Console.ReadLine();
        }
    }
}