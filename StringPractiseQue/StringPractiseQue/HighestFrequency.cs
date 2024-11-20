//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StringPractiseQue
//{
//    internal class HighestFrequency
//    {
        
//        public static void highestfrequency(string s)
//        {
//            int max = 0;
//            char mch = ' ';
//            int count = 0;
//            char[] ch = s.ToCharArray();
//            for(int i=0;i<ch.Length;i++)
//            {
//                count = 0;
//                for(int j=0;j<ch.Length;j++)
//                {
//                    if (ch[i] == ch[j])
//                    {
//                        if (i > j)
//                            break;
//                        else
//                        {
//                            count++;
//                        }
//                    }
//                }
//                if(count >0)
//                {
//                    Console.WriteLine($"OCCURANCE OF   {ch[i]} >--  {count}");
//                }
//                if(count >max)
//                {
//                    max = count;
//                    mch = ch[i];
//                }
//            }
//            Console.WriteLine($"CHARACTER {mch} WITH HIGHEST FREQUENCY {max}");
//        }
//        static void Main(string[] args)
//        {
//            String s = "ABHIHHB";
//            highestfrequency(s);
//        }

//    }
//}
