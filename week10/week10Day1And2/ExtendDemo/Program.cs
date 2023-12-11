namespace ExtendDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Please enter a number of multiplications : ");
            int multiplications = int.Parse(Console.ReadLine());
            int multiplicator = 1;

            for (int i = 0; i < multiplications; i++)
            {
                int result = num * multiplicator;
                Console.WriteLine($"{multiplicator} x {num} = {result}");
                multiplicator++;
            }

        }
    }
}