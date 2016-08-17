using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Day4
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Bank of ISS");
            string actualPIN = "123456";
            //for(int index = 0; index < 4; index++)
            //{
            //    Console.WriteLine("Enter you PIN: ");
            //    string inputPIN = Console.ReadLine();
            //    if(inputPIN == actualPIN)
            //    {
            //        Console.WriteLine("PIN accepted. You can access your account now.");
            //        break;
            //    }
            //    else if(index <2)
            //        Console.WriteLine("Incorrect PIN. Please try again");
            //    else
            //    {
            //        Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
            //        break;
            //    }
            //}

            int maxAttempts = 3;
            while (maxAttempts > 0)
            {
                maxAttempts--;
                Console.WriteLine("Enter you PIN: ");
                string inputPIN = Console.ReadLine();
                if (inputPIN == actualPIN)
                {
                    Console.WriteLine("PIN accepted. You can access your account now.");
                    break;
                }
                else if (maxAttempts == 0)
                    Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
                else
                    Console.WriteLine("Incorrect PIN. Please try again");
            }

        }
    }
}
