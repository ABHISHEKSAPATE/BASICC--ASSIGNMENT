using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Pair of elements in arrays whose sum is equivalent to given number
namespace CUBEOFNUMBER
{
    public class PAIROFELEMENT
    {
        public static void pairofelement(int[]num,int n)
        {
          for(int i=0;i<num.Length;i++)
            {
                for(int j=0;j<num.Length;j++)
                {
                    if (n == num[i] + num[j])
                    {
                        if (i > j)
                            break;
                        Console.WriteLine("PAIR OF ELEMENTS IS" + "[" + num[i] + "," + num[j]+"]");
                    }
                }
            }
        }
        //static void Main(string[] args)
        //{
        //    int[] num = { 1, 2, 3, 4, 5, 6 };
        //    pairofelement(num, 6);
        //}
    }
}
