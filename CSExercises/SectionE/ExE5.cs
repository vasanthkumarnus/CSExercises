﻿using System;

namespace CSExercises
{

    //Modify the Prime Number C# program to print out all 
    //the prime numbers from 5 to 10000.


    public class ExE5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //Hint: you can call ExE3.IsPrime method (from previous exercise) 
            //to check whether a number is a prime or not.
            int count = 0;
            for (int index = 5; index <= 10000; index++)
            {
                if (ExE3.IsPrime(index))
                {
                    count++;
                    Console.Write("{0}\t", index);
                }
            }
            //Console.WriteLine("Total Primes: {0}", count);
        }
    }
}
