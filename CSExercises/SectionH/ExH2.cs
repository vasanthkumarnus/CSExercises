using System;
namespace CSExercises
{
    public class ExH2
    {
        //Write a static method: FindWord(string s1, string s2) that would return an integer.  
        //The method should find if the string s2 occurs in s1 and return an integer that would 
        //indicate the starting position of the word s2 in s1.  If the word does not occur 
        //the return value should be –1.

        public static void Main()
        {
            Console.Write("String 1:");
            string s1 = Console.ReadLine();
            Console.Write("String 2:");
            string s2 = Console.ReadLine();
            Console.WriteLine("{0}", FindWord(s1.ToLower(), s2.ToLower()));
        }

        public static int FindWord(string s1, string s2)
        {
            //YOUR CODE HERE
            int index = -1;
            //string[] seperator = new string[1] { s2 };
            //string[] stArr = s1.Split(seperator, StringSplitOptions.None);
            //match = stArr.Length > 1;

            for (int s1Index = 0; s1Index < s1.Length; s1Index++)
            {
                if ((s1Index + s2.Length) <= s1.Length)
                {
                    string s1Temp = s1.Substring(s1Index, s2.Length);
                    if (s1Temp == s2)
                    {
                        index = s1Index;
                        break;
                    }
                }
            }
            return index;
        }
    }
}
