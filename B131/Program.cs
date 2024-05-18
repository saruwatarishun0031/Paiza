using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace B131
{
    internal class Program
    {
        static void Main()
        {

            var StationN = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int x = StationN[0];
            int y = StationN[1];
            int z = 0;
            //int w = 0;
            int d = 0;
            int ans = 0;
            List<List<int>> date = new List<List<int>>();
            for (int i = 0; i < x; i++)
            {
                var row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                date.Add(new List<int>(row));
            }
            var Stops =int.Parse(Console.ReadLine());
            for (int i = 0;i < Stops; i++)
            {
                var line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int s = line[0];
                int e = line[1];
                if (i == 0)
                {
                    ans += date[s - 1][e - 1];
                }
                else
                {
                    if (date[s - 1][z] < date[s - 1][e - 1])
                    {
                        d = date[s - 1][e - 1] - date[s - 1][z];
                        ans += d;
                    }
                    else if (date[s - 1][z] > date[s - 1][e - 1])
                    {
                        d = date[s - 1][z] - date[s - 1][e - 1];
                        ans += d;
                    }
                    
                }
                z = e - 1;

            }
            Console.WriteLine(ans);
            //foreach (var row in date)
            //{
            //    Console.WriteLine(string.Join(" ", row));
            //}
        }
    }
}
