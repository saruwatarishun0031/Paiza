namespace D254
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var line2 = Console.ReadLine();
            int x = int.Parse(line);
            int y = int.Parse(line2);
            if (x < y)
            {
                Console.WriteLine(y - x);
            }
            else
            {
                Console.WriteLine(x - y);
            }

        }
    }
}
