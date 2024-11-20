//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////2.Calculate no of vowels, consonants, digits and special symbol from given String
//namespace StringPractiseQue
//{
//    internal class Calculatevowlesconsonents
//    {

//        public static void calculate(string s)
//        {
//            int v = 0, c = 0, sc = 0, n = 0;
//            char[] ch =s.ToCharArray();

//            for(int i=0;i<ch.Length;i++)
//            {
//                if (ch[i]=='a' || ch[i]=='e' || ch[i]=='o' || ch[i]=='u' || ch[i]=='A' || ch[i] == 'E' || ch[i] == 'I' || ch[i] == 'O' || ch[i] == 'U' )
//                {
//                    v++;
//                }
//                else if( (ch[i]>='a' && ch[i]<='z' ) || (ch[i] >= 'A' && ch[i] <= 'Z'))
//                {
//                    c++;
//                }
//                else if (ch[i] >= '0' && ch[i] <= '9')
//                {
//                    n++;
//                }
//                else
//                {
//                    sc++;
//                }
//            }
//            Console.WriteLine("NO OF VOWLES ARE:" + v);
//            Console.WriteLine("NO OF CONSONENTS ARE:" + c);
//            Console.WriteLine("NO OF NUM ARE:" + n);
//            Console.WriteLine("NO SPECIAL CHARACTER ARE:" + sc);
//        }
//        static void Main(string[] args)
//        {
//            String s = "HELLO#U@*#R12//";
//            calculate(s);
//        }
//    }
//}
