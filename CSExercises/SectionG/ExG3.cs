using System;

namespace CSExercises
{
    //The C# language gives facilities for changing cases all to upper or lower - 
    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
    //Example
    //“institute of systems science”   =>   “Institute Of System Science”

    public class ExG3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string newphrase = ToTitleCase(phrase);

            Console.WriteLine(newphrase);
        }

        public static string ToTitleCase(string phrase)
        {
            //YOUR CODE HERE
            string[] words = phrase.Trim( ).Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string titleCasePhrase = string.Empty;
            for (int index = 0; index < words.Length; index++)
            {
                string titleWord = words[index];
                string ch = titleWord[0].ToString().ToUpper();
                if (titleWord.Length > 1)
                    titleCasePhrase += String.Format("{0}{1} ", ch, titleWord.Substring(1, titleWord.Length - 1));
                else
                    titleCasePhrase += String.Format("{0} ", ch);
            }
            return titleCasePhrase;
        }
    }
}
