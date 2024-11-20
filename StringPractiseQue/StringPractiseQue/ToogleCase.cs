//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////9.  Write a Java program to toggle case of each character of a string
//namespace StringPractiseQue
//{
//    internal class ToogleCase
//    {
//        public static void tooglecase(string s)
//        {
//            char[] ch = s.ToCharArray();
//            for(int i=0;i<ch.Length;i++)
//            {
//                char c = s[i];
//                if(char.IsLower(c))
//                {
//                    ch[i] = char.ToUpper(c);
//                }
//                else if(char.IsUpper(c))
//                {
//                    ch[i] = char.ToLower(c);
//                }
//            }
//            Console.WriteLine($"GIVEN STRING :"+s);
//            Console.WriteLine("TOGGLE STRING: " + new string(ch));

//        }
//        static void Main(string[] args)
//        {
//            string s = "AbHiShEk";
//            tooglecase(s);
//        }
//    }
//}
