using System.Runtime.InteropServices;

namespace WorkingWithAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personsNum = int.Parse(Console.ReadLine());
            string[] names = new string[personsNum];
            int[] ages = new int[personsNum];

            for (int i = 0; i < personsNum; i++)
            {
                Console.Write($"Please enter person {i + 1} name: ");
                names[i] = Console.ReadLine();
                Console.Write($"Please enter person {i + 1} age: ");
                ages[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You have inputted the following data: ");
            for (int i = 0;i < personsNum; i++)
            {
                Console.WriteLine($"{names[i]} ({ages[i]} year(s) old)");
            }
        }
    }
}