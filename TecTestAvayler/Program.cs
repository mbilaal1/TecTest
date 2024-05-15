namespace TecTestAvayler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to find its elemental forms:");

            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No valid elemental forms found.");
                return;
            }

            var results = Elements.ElementalForms(input);
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
