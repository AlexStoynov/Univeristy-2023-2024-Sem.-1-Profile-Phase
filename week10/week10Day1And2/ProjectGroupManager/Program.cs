namespace ProjectGroupManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people are in your group?");
            int peopleNum = int.Parse(Console.ReadLine());
            string[] peopleNames = new string[peopleNum];
            int counter = 1;

            for (int i = 0; i < peopleNum; i++) {
                peopleNames[i] = Console.ReadLine();
            }

            for (int i = 0;i < peopleNames.Length; i++)
            {
                Console.Write($"Member {counter}: ");
                Console.WriteLine(peopleNames[i]);
                counter++;
            }
        }
    }
}