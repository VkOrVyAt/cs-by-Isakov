using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Program
    {
        public static void PrintEvenNumber(int m, int n)
        {
            if (m > n) return;
            if (m % 2 == 0) Console.Write($"{m}\t");
            PrintEvenNumber(m + 1, n);
        }

        public static int SumInRange(int m, int n)
        {
            if (m == n) return m;
            return SumInRange(m, n -1) + n;
        }

        public static int Ackermann(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (n == 0)
                return Ackermann(m - 1, 1);
            else
                return Ackermann(m - 1, Ackermann(m, n - 1));
        }

        public static void Main(string[] args)
        {
            PrintEvenNumber(1, 8);
            Console.WriteLine();
            Console.WriteLine(SumInRange(4, 6));
            Console.WriteLine();
            Console.WriteLine(Ackermann(3, 4));
        }

    }
}
