using System;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges based on the kilometres travelled.

    //Minimum charge:  $2.40  (first 0.5 km no additional charges apply)
    //For the next 8.5 kms the rate is 4 cents for every 100 meters
    //After that:   5 cents for evey 100 meters

    //In the above example you should assume that the meter falls every 100 meters.So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:

    //$ 2.40 (first 0.5 km) +
    //$ 85 * 0.04 (next 8.5 km) +
    //$ (122 -90) * 0.05 (for distance over 9.0 km)
    //=  $7.40


    public class ExC4
    {
        public static void Main(string[] args)
        {

            //Your code here

            Console.Write("Please enter the distance travelled: ");
            string strDistance = Console.ReadLine();
            if (ValidateDouble(strDistance))
                Console.WriteLine("Fare: {0:C2}", CalculateFare(Convert.ToDouble(strDistance)));
            else
                Console.WriteLine("**Error**");
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double totalFare = 0;
            double minFare = 2.40;
            double minDist = 0.5;
            double firstSlabDist = 8.5;
            double chargeAtFirstSlab = 0.04;
            double chargeAtSecondSlab = 0.05;
            double chargePer = 10;  // charge per indicates kms to meters and rate per meter. In this case (kms * 1000)/100
            double secondSlabDist = minDist + firstSlabDist;
            totalFare = minFare;
            if (distance > minDist && distance <= (minDist + firstSlabDist))
                totalFare += (Math.Ceiling((distance - minDist) * chargePer) * chargeAtFirstSlab);
            else if (distance > minDist && distance > (minDist + firstSlabDist))
                totalFare += (((firstSlabDist * chargePer) * chargeAtFirstSlab) + (Math.Ceiling((distance - secondSlabDist) * chargePer) * chargeAtSecondSlab));
            return totalFare;
        }

        public static bool ValidateDouble(string strInput)
        {
            double doubleInput;
            return double.TryParse(strInput, out doubleInput);
        }
    }
}