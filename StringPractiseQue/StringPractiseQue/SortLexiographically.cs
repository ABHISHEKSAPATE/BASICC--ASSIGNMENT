using System;
//2. Write a program to sort string arrays on the basis of length and if length is same
//then lexicographically

namespace StringPractiseQue
{
    internal class SortLexiographically
    {
        public static void sortlexiography(string[] s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].Length == s[j].Length)
                    {
                        if (s[i].CompareTo(s[j]) > 0)////lexicographically--Dictionary wise order
                        {
                            string temp = s[i];
                            s[i] = s[j];
                            s[j] = temp;
                        }


                    }

                    else if (s[i].Length > s[j].Length)
                    {
                        String temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;

                    }

                }

            }
        }
        static void Main(string[] args)
        {
            string[] s = { "Java", "c", "Html", "Angular", "Python", "Spring" };
            sortlexiography(s);
            Console.WriteLine("sorted arraystring:" + string.Join(" ", s));//join to convert array back to string 
        }
    }
}

