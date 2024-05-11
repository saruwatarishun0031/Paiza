namespace Isit5ormorebut4orless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            int x = int.Parse(line);
            if (x >= 5)
            {
                Console.WriteLine("high");
            }
            else
            {
                Console.WriteLine("low");
            }
        }
    }
}
