using System;

namespace CSExercises
{
    public class ExH1
    {

        public static void Main()
        {
            Console.Write("String 1:");
            string s1 = Console.ReadLine();
            Console.Write("String 2:");
            string s2 = Console.ReadLine();
            Console.WriteLine("{0}", InString(s1.ToLower(), s2.ToLower()) ? "Matches" : "Doesn't Match");
        }


        public static bool InString(string s1, string s2)
        {
            //YOUR CODE HERE
            bool match = false;
            //string[] seperator = new string[1] { s2 };
            //string[] stArr = s1.Split(seperator, StringSplitOptions.None);
            //match = stArr.Length > 1;

            for (int s1Index = 0; s1Index < s1.Length; s1Index++)
            {
                if((s1Index + s2.Length) <= s1.Length)
                {
                    string s1Temp = s1.Substring(s1Index, s2.Length);
                    if (s1Temp == s2)
                    {
                        match = true;
                        break;
                    }
                }
            }

            return match;
        }
    }
}
