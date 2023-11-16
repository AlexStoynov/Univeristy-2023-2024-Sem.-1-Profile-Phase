namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a whole number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}