using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUBEOFNUMBER
{
    public class RIGHTROTATE
    {
        public static void rightrotate(int[] num)
        {

            int last = num[num.Length-1];
            for (int i = num.Length - 1;i>0; i--)
            {
                num[i] = num[i - 1];
            }
            num[0] = last;

        }
        //static void Main(string[] args)
        //{

        //    int[] num = { 1, 2, 3, 4, 5 };
        //    Console.WriteLine("ORIGINAL ARR IS:" + string.Join(" ", num));
        //    for (int i = 1; i <= 3; i++)
        //    {
        //        rightrotate(num);

        //    }
        //    Console.WriteLine("LEFT ROTATED ARR IS:" + string.Join(" ", num));
        //}
    }
}
