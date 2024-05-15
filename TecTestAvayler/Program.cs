namespace TecTestAvayler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to find its elemental forms:");

            var results = Elements.ElementalForms(Console.ReadLine());

            if (results.Length == 0)
            {
                Console.WriteLine("No valid elemental forms found.");
            }
            else
            {
                Console.WriteLine("Possible elemental forms:");
                foreach (var result in results)
                {
                    Console.WriteLine(string.Join(", ", result));
                }
            }
        }
    }
}
