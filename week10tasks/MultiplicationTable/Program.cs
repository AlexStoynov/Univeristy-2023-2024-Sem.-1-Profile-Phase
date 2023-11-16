namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            Console.WriteLine($"The average is - {nums.Average()}");
            Console.WriteLine($"The highest number is - {nums.Max()}");
            Console.WriteLine($"The lowest number is - {nums.Min()}");
            Console.WriteLine($"The sum is - {nums.Sum()}");
            double result = 1;
            
            foreach(int num in nums) {
                result *= num;
            }

            Console.WriteLine($"The multiplication is - {result}");
        }
    }
}