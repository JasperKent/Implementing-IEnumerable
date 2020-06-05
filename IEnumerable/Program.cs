using System;
using System.Collections.Generic;

namespace IEnumerable
{
    class Program
    {
        static void Main()
        {
            List<int> ints = new List<int> { 3, 56, 78, 21, 34, 98, 45, 22 };

            using (IEnumerator<int> en = ints.GetEnumerator())
            {
                while (en.MoveNext())
                    Console.WriteLine(en.Current);
            }

            Console.WriteLine();

            foreach (int i in ints)
                Console.WriteLine(i);
        }
    }
}
