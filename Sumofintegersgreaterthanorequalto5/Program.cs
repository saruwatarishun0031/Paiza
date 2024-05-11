namespace Sumofintegersgreaterthanorequalto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            int n = int.Parse(line);
            int vecter = 0;
            for (int i = 0; i < n; i++)
            {
                int x = Console.Read();
                if (x <= 5)
                {
                    vecter += i;
                }
            }
            Console.WriteLine(vecter);
        }
    }
}
