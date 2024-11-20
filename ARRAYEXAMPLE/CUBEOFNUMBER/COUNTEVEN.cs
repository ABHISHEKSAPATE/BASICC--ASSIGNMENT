using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUBEOFNUMBER
{
    public class COUNTEVEN
    {
        public void evencount(int[]num)
        {
            int count = 0;
            for(int i = 0;i<num.Length;i++)
            {
                if(num[i]%2==0)
                {
                    count++;
                    
                }
            }
            Console.WriteLine("EVEN NUMBERS IN ARRAY :" + count);
        }
        //static void Main(string[] args)
        //{
        //    int[] num = { 10, 12, 13, 14, 15, 16, 17,2 };
        //    COUNTEVEN c=new COUNTEVEN();
        //    c.evencount(num);

        //}
    }
}
