//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////3.Check occurrences of particular  characters, how many times it’s there and which diff positions.
//namespace StringPractiseQue
//{
//    internal class Occurance
//    {
//        public static void countoccurance(string s)
//        {
//            char[] ch = s.ToCharArray();

//            for (int i = 0; i < ch.Length; i++)
//            {
//                int count = 0;
//                int pos = ch[i];
//                for (int j = 0; j < ch.Length; j++)
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
//                if (count > 0)
//                {
//                    Console.WriteLine("OCCURANCE OF " + ch[i] + ">--" + count );
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            String s = "RAMMAMRAM";
//            countoccurance(s);
//        }
//    }
//}
