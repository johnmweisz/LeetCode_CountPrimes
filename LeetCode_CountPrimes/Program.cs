using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CountPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.CountPrimes(10));
        }
    }
    public class Solution
    {
        public static int CountPrimes(int n)
        {
            if (n < 2) return 0;
            var notPrimes = new bool[n + 1];
            var count = 0;
            notPrimes[0] = true;
            notPrimes[1] = true;
            for (var i = 2; i < n; i++)
            {
                if (notPrimes[i]) continue;
                count++;
                for (var j = 2; j * i <= n; j++)
                {
                    notPrimes[i * j] = true;
                }
            }
            return count;
        }
    }
}
