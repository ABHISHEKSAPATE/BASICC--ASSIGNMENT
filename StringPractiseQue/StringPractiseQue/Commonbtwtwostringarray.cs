//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StringPractiseQue
//{
//    internal class Commonbtwtwostringarray
//    {
//        public static void commonElement(string[] s1, string[] s2)
//        {
//         for(int i=0;i<s1.Length;i++)
//            {
//                for(int j=0; j<s2.Length;j++)
//                {
//                    if (s1[i] == s2[j])
//                    {
//                        if (i > j)
//                            break;
//                        else
//                        {
//                            Console.WriteLine($"COMMON WORD ARE:{s1[i]}");
//                        }
//                    }
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            string[]s1 = { "cow", "goat", "chicken", "hen", "horse" };
//            string[]s2 = { "wolf", "goat", "cow", "man", "hat" };
//            commonElement(s1, s2);
//        }
//    }
//}
