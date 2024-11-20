//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StringPractiseQue
//{
//	internal class Wordbywordreverse
//	{
//		//wordbywordreverse
//		public static void WordByWordRev(string s)
//		{
//			string[] words = s.Split(' ');
//			string rev = "";
//			for(int i=words.Length-1;i>=0;i--)
//			{
//				rev = rev + words[i]+" ";
//			}
//			Console.WriteLine("ORIGINAL STRING :"+s);
//			Console.WriteLine("WORD BY WORD REV IS:"+rev);
//		}

//		//wordscharrev
//		public static void reverseWordsCharacters(string s)
//		{
//			string[] w = s.Split(' ');
//			string revw = "";
//			for (int j=0;j<w.Length;j++)
//			{
//				string rword = w[j];
//				for(int k=rword.Length-1;k>=0;k--)
//				{
//					revw = revw + rword[k];
//				}
//				revw = revw + " ";
//			}
//			Console.WriteLine("ORIGINAL STRING :" + s);
//			Console.WriteLine("WORD CHAR REV IS:" + revw);
//		}
//		static void Main(string[] args)
//		{
//			string s = "CRICKET IS LOVE";
//			WordByWordRev(s);
//			reverseWordsCharacters(s);
//		}
//	}
//}
