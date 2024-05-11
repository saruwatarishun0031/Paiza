using System.Linq;
namespace SumOfArrayElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ary = new List<int>() { 1, 3, 5, 6, 3, 2, 5, 23, 2 };
            int value = 0;
            for (int i = 0; i < ary.Count; i++)
            {
                value += ary[i];
            }
            Console.WriteLine(value);

        }
    }
}
