using System;

namespace CUBEOFNUMBER
{
    public class SECONDHIGHESTNUM
    {
        public static void secondmaxnumber(int[] num)
        {
            // Initialize max and second max
            int max = num[0];
            int smax = int.MinValue; // A small value for second max

            for (int i = 1; i < num.Length; i++) 
            {
                if (num[i] > max)
                {
                    smax = max;  // Update second max to previous max
                    max = num[i]; // Update max to current number
                }
                else if (num[i] > smax && num[i] != max)
                {
                    smax = num[i]; // Update second max if the number is between max and second max
                }
            }

            Console.WriteLine("SECOND MAX NUMBER IS: " + smax);
        }

        //static void Main(string[] args)
        //{
        //    int[] num = { 1, 2, 3, 6, 8, 9, 100, 56,57 };
        //    secondmaxnumber(num);
        //}
    }
}
