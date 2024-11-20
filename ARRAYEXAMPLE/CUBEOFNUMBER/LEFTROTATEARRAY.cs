using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUBEOFNUMBER
{
    public class LEFTROTATEARRAY
    {
        public static void  leftrotate(int[]num)
        {
           
            int first = num[0]; 
            for(int i=0;i<num.Length-1;i++)
            {
                num[i] = num[i + 1];
            }
            num[num.Length-1] = first;

        }
        //static void Main(string[] args)
        //{
           
        //    int[] num = { 1, 2, 3, 4, 5 };
        //    Console.WriteLine("ORIGINAL ARR IS:" + string.Join(" ", num));
        //    for (int i=1;i<=2;i++)
        //    {
        //        leftrotate(num);
                
        //    }
        //    Console.WriteLine("LEFT ROTATED ARR IS:"+string.Join(" ", num));
        //}
    }
}
