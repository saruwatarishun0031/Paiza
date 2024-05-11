namespace MultilineInputAndOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = Console.ReadLine();
            int x = int.Parse(line);
            for (int i = 0; i < x; i++)
            {
                var y = Console.ReadLine();
                Console.WriteLine(y);
            }

        }
    }
}
