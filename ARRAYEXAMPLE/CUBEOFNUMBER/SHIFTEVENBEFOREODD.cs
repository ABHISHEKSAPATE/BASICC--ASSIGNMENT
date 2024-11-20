using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUBEOFNUMBER
{
    public class SHIFTEVENBEFOREODD
    {
        public static void shiftzeroatstart(int[] num)
        {
            int i, j;
            int temp;
            for (i = 0; i < num.Length; i++)
            {
                if (num[i]%2 == 0)
                    continue;
                else
                {
                    for (j = num.Length - 1; j > 0 && i < j; j--)
                    {
                        if (num[j] %2== 0)
                        {
                            temp = num[i];
                            num[i] = num[j];
                            num[j] = temp;
                            break;
                        }
                    }
                }
            }
        }
        //static void Main(string[] args)
        //{
        //    int[] num = { 1, 2, 3, 4, 8, 6, 13, 17 };
        //    shiftzeroatstart(num);
        //    Console.WriteLine("new arr :" + string.Join(" ", num));
        //}
    }
}
