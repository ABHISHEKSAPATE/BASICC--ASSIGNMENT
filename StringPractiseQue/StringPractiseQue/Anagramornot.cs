//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////*logic:
//// * 1:length must be same
//// * 2:must be in same case
//// * 3:sort
//// * 4;compare
//namespace StringPractiseQue
//{
//    internal class Anagramornot
//    {
//        public static void anagramornot(string s1 ,string s2)
//        {
//            if (s1.Length != s2.Length)
//            {
//                Console.WriteLine("LENGTH MUST BE EQUAL");
//                return;
//            }
//            else
//            {
//                s1 = s1.ToLower();
//                s2 = s2.ToLower();

//                char[] ch1 = s1.ToCharArray();

//                char[] ch2 = s2.ToCharArray();

//                Array.Sort(ch1);
//                Array.Sort(ch2);

//                if( new string (ch1)== new string(ch2))
//                {
//                    Console.WriteLine($"{s1} and {s2} are anagrams.");
//                }
//                else
//                {
//                    Console.WriteLine($"{s1} and {s2} are not anagrams.");
//                }


//            }
               
//        }
//        static void Main(string[] args)
//        {
//            string str1 = "listen";
//            string str2 = "silent";

//            anagramornot(str1, str2);
//        }
//    }
//}
