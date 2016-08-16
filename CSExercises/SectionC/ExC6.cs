using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            string tvQty, dvdQty, mp3Qty;
            Console.Write("Enter the TV quantity: ");
            tvQty = Console.ReadLine();
            Console.Write("Enter the DVD quantity: ");
            dvdQty = Console.ReadLine();
            Console.Write("Enter the MP3 quantity: ");
            mp3Qty = Console.ReadLine();
            if (ValidateNumber(tvQty) && ValidateNumber(dvdQty) && ValidateNumber(mp3Qty))
                Console.WriteLine(CalculateTotalPrice(Convert.ToInt32(tvQty), Convert.ToInt32(dvdQty), Convert.ToInt32(mp3Qty)));
            else
                Console.WriteLine("**Error**");
        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            //YOUR CODE HERE
            double tvPrice = 900, dvdPrice = 500, mp3Price = 700;
            double tempSum = ((tvQty * tvPrice) + (dvdQty * dvdPrice));
            double totalSum = tempSum + (mp3Qty * mp3Price);
            double discount10Amt = 5000;
            double discount15Amt = 10000;
            double totalPrice = totalSum;
            if (totalSum > discount15Amt)
                totalPrice = (tempSum * 0.85) + (mp3Qty * mp3Price);
            else if (totalSum > discount10Amt)
                totalPrice = (tempSum * 0.9) + (mp3Qty * mp3Price);
            return totalPrice;
        }

        public static bool ValidateNumber(string strInput)
        {
            int doubleInput;
            return int.TryParse(strInput, out doubleInput);
        }
    }
}