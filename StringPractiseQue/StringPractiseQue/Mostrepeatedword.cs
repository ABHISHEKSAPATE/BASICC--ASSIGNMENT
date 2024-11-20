//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////3.WAP to find the most repeated word in a string
//namespace StringPractiseQue
//{
//    internal class Mostrepeatedword
//    {
//        public static void mostrepeatedword(string s)
//        {
//            string[] word = s.Split(' ');
//            int maxcount = 0;
//            int count = 0;
//            string mstr = " ";

//            for(int i=0;i<word.Length;i++)
//            {
//                count = 0;
//                for (int j = 0;j<word.Length;j++)
//                {
//                    if (word[i] == word[j])
//                    {
//                        if (i > j)
//                            break;
//                        else
//                        {
//                            count++;
//                        }
//                    }
//                }
//                //if(count >0)
//                //{
//                //    Console.WriteLine($"REPEATED WORD IN STRING IS {word[i]} {count} times");
//                //}
//                if(count >maxcount)
//                {
//                    maxcount = count;
//                    mstr = word[i];
//                }
               
//            }
//            Console.WriteLine($"MOST REPEATED WORD IN STRING IS {mstr} {maxcount} times");
//        }
//        static void Main(string[] args)
//        {
//            string s = "I AM BOY I LOVE CRICKET I PLAY CRICKET I AM GOOD BOY";
//            mostrepeatedword(s);
//        }
//    }
//}
