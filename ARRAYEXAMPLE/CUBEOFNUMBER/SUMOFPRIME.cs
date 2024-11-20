using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUBEOFNUMBER
{
    public class SUMOFPRIME
    {
        public static void sumofprime(int[]num)
        {
            int sum = 0;
            Console.WriteLine("PRIME NUMBER ARE:");
            for (int i = 0;i<num.Length;i++)
            {
               if(isprime(num[i]))
                {
                    sum += num[i];
                    Console.WriteLine(num[i]);

                }
            }
            Console.WriteLine("SUM OF PRIME NUMBER IS:"+sum);
        }

        public static bool isprime(int n)
        {
            if(n<=1)
                return false;
            for (int i = 2;i<=n/2;i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        //static void Main(string[] args)
        //{
        //    int[] num = { 1, 2, 3, 4, 5, 6 };
        //    sumofprime(num);
        //}
    }
}
