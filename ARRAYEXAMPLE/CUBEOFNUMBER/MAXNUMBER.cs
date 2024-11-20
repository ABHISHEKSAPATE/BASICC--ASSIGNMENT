using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4. Find the maximum number in an array
namespace CUBEOFNUMBER
{
    public class MAXNUMBER
    {
        public static void findmaxnumber(int[]num)
        {
            int max = num[0];
            for(int i=0;i<num.Length;i++)
            {
                if(num[i] > max)
                    max = num[i];
            }
            Console.WriteLine(max);
        }

        //static void Main(string[] args)
        //{
        //    int[]num = { 1, 2, 3,6,8,9,100,56 }; 
        //    findmaxnumber(num);

        //}

    }
}
