namespace C142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool trye = false;
            var line = Console.ReadLine();
            var line2 = Console.ReadLine();
            int y = int.Parse(line2);
            var line3 = Console.ReadLine().Split(' ');
            for (int i = 0; i < line3.Length; i++)
            {
                if (line3[i] == line)
                {
                    trye = true;
                }
                
            }
            if (trye == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
}
