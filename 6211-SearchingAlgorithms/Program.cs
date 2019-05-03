using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6211_SearchingAlgorithms
{
    class Program
    {

        static int[] RandomIntegers;

        static void Main(string[] args)
        {
            Random random = new Random();
            RandomIntegers = new int[100000000];

            for (int i = 0; i < RandomIntegers.Length; i++)
            {
                RandomIntegers[i] = random.Next(1000, 1000000);
            }

            // ~610ms
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Found: {0}", Search<int>(999)); // Will not find 999
            sw.Stop();
            Console.WriteLine("Generic Linear Search: {0}", sw.ElapsedMilliseconds);

            // ~210ms
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            Console.WriteLine("Found: {0}", SearchInt(999)); // Will not find 999
            sw2.Stop();
            Console.WriteLine("Int Linear Search: {0}", sw2.ElapsedMilliseconds);

            Console.ReadLine();
        }

        // Generic Linear Search
        static bool Search<T>(T toFind)
        {
            for (int i = 0; i < RandomIntegers.Length; i++)
            {
                if (RandomIntegers[i].Equals(toFind))
                    return true;
            }
            return false;
        }

        // Integer linear search
        static bool SearchInt(int toFind)
        {
            for (int i = 0; i < RandomIntegers.Length; i++)
            {
                if (RandomIntegers[i] == toFind)
                    return true;
            }
            return false;
        }

    }
}
