using System;

namespace CSExercises
{
    //Modify the Perfect Number C# program to print out 
    //all the perfect numbers from 1 to 1000.

    public class ExE6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //Hint: you can use ExE4.IsPerfectNumber() method here
            int count = 0;
            for (int index = 1; index <= 1000; index++)
            {
                if (ExE4.IsPerfectNumber(index))
                {
                    count++;
                    Console.Write("{0}\t", index);
                }
            }
            //Console.WriteLine("Total Perfect Numbers: {0}", count);
        }
    }
}
