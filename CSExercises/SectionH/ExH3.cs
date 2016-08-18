using System;
namespace CSExercises
{
    public class ExH3
    {
        //Write a function (static method) that would take in an integer and 
        //return the hexadecimal.  Print out the Hex of all numbers 1 to 100 and 
        //compare your answer with that of the built in function.

        public static void Main()
        {
            Console.Write("Enter an integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", Reverse(Hex(num)));
        }

        public static string Reverse(string str)
        {
            string reverse = string.Empty;
            for (int index = str.Length - 1; index > -1; index--)
            {
                reverse += str[index];
            }
            return reverse;
        }

        public static string Hex(int i)
        {
            //YOUR CODE HERE
            string hexaConversion = string.Empty;
            int quot = i;

            if (i < 16)
            {
                return hexaConversion = quot.ToString();
            }

            while (quot != 0)
            {
                int rem = quot % 16;
                string hexaChar = rem.ToString();
                hexaChar = GetHexChar(rem);
                hexaConversion += hexaChar;
                quot = quot / 16;
            }
            return hexaConversion;
        }

        private static string GetHexChar(int rem)
        {
            string hexaChar = rem.ToString();
            if (rem > 9)
            {
                switch (rem)
                {
                    case 10:
                        hexaChar = "A";
                        break;
                    case 11:
                        hexaChar = "B";
                        break;
                    case 12:
                        hexaChar = "C";
                        break;
                    case 13:
                        hexaChar = "D";
                        break;
                    case 14:
                        hexaChar = "E";
                        break;
                    case 15:
                        hexaChar = "F";
                        break;
                    default:
                        hexaChar = string.Empty;
                        break;
                }
            }
            return hexaChar;
        }
    }
}
