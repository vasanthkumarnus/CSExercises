using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please enter the number: ");
            string strNumber = Console.ReadLine();
            if (ValidateNumber(strNumber))
                Console.WriteLine("The given number is {0}an Armstrong Number.", IsArmstrongNumber(Convert.ToInt32(strNumber)) ? string.Empty : "not ");
            else
                Console.WriteLine("**Error**");
        }


        public static bool IsArmstrongNumber(int number)
        {
            //YOUR CODE HERE
            bool isArmstrong = false;
            int copyNum = number;
            int numLength = copyNum.ToString().Length;
            int baseNumSystem = 10;
            int Sum = 0, temp = 0;
            temp = Convert.ToInt32(Math.Pow(baseNumSystem, numLength - 1));
            while (copyNum != 0 && temp > 0)
            {
                int tempDigit = copyNum / temp;
                Sum += Convert.ToInt32(Math.Pow(tempDigit, numLength));
                copyNum -= (tempDigit * temp);
                temp = temp / 10;
            }
            if (number == Sum)
                isArmstrong = true;
            return isArmstrong;
        }

        public static bool ValidateNumber(string strInput)
        {
            int doubleInput;
            return int.TryParse(strInput, out doubleInput);
        }

    }
}