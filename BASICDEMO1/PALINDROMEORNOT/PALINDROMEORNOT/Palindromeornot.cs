using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALINDROMEORNOT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 119, rev = 0;
            for (int i = num; i != 0; i = i / 10)
            {
                int digit = i % 10;
                rev = rev * 10 + digit;
            }
            if (num == rev)
            {
                Console.WriteLine("Number is Palindrome ");
            }
            else
            {
                Console.WriteLine("Number is Not Palindrome ");
            }
        }
    }
}
