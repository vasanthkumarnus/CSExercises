using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE

            //bool enoughEntries = false;
            //do
            //{
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Marks: ");
            //    int mark = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Anymore students: Y/N: ");
            //    if (Console.ReadLine().ToLower() == "n")
            //        enoughEntries = true;
            //} while (!enoughEntries);
            int[] marks = new int[5] { 63, 29, 75, 82, 55 };
            OrderMarksByDescending(marks);
            PrintMarks(marks);
            string[] names = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            OrderNamesByAscending(names);
            PrintNames(names);
        }

        private static void OrderMarksByDescending(int[] marks)
        {
            for (int i = 0; i < marks.Length - 1; i++)
            {
                for (int j = i + 1; j < marks.Length; j++)
                {
                    if (marks[i].CompareTo(marks[j]) < 0)
                    {
                        int temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;
                    }
                }
            }
        }

        private static void OrderNamesByAscending(string[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = i + 1; j < names.Length; j++)
                {
                    if (names[i].CompareTo(names[j]) > 0)
                    {
                        string temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;
                    }
                }
            }
        }

        public static void PrintMarks(int[] marks)
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }

        public static void PrintNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
