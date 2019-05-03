using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static int[] RandomIntegers;

        static void Main(string[] args)
        {
            Random random = new Random();
            RandomIntegers = new int[10000000];

            for (int i = 0; i < RandomIntegers.Length; i++)
            {
                RandomIntegers[i] = random.Next(100, 10000000);
            }

            Stopwatch swSort = new Stopwatch();
            swSort.Start();
            Array.Sort(RandomIntegers);
            swSort.Stop();
            Console.WriteLine("Sort: {0}", swSort.ElapsedMilliseconds);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Found: {0}", BinarySearch(555));
            sw.Stop();
            Console.WriteLine("Binary Search: {0}", sw.ElapsedMilliseconds);

            Console.ReadLine();

        }

        static bool BinarySearch(int find)
        {
            int mid;
            int upper = RandomIntegers.Length;
            int lower = 0;

            while(lower <= upper)
            {
                mid = lower + (upper-lower) / 2;
                if (RandomIntegers[mid] == find)
                    return true;
                else if (find < RandomIntegers[mid])
                    upper = mid - 1;
                else
                    lower = mid + 1;
            }

            return false;
        }
    }
}
