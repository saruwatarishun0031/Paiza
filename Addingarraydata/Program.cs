using System.Collections.Generic;
namespace Addingarraydata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ary = new List<int>() { 4, 0, 5, -1, 3, 10, 6, -8 };
            int value = 0;
            for (int i = 0; i < ary.Count; i++)
            {
                if (ary[i] >= 5)
                {
                    value += ary[i];
                }
            }
            Console.WriteLine(value);
        }
    }
}
