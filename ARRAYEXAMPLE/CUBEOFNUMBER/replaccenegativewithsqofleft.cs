using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7.WAP to replace the negative elements in an array with immediate left elements square
//ar ={ 1,2,-3,2,-4,-6}
//o / p ={ 1,2,4,2,4,16}
namespace CUBEOFNUMBER
{
    public class replaccenegativewithsqofleft
    {
        public static void replace(int[]num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if(num[i] < 0)
                {
                    num[i] = num[i - 1] * num[i - 1];
                }
            }
            
        }
        //static void Main(string[] args)
        //{
        //    int[] num = { 1, 2, -3, 2, -4, -6 };
        //    Console.WriteLine("original ARR :" + string.Join(" ", num));
        //    replace(num);
        //    Console.WriteLine("REPLACE ARR :"+string.Join(" ",num));
        //}
    }
}
