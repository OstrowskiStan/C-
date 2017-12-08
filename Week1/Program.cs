using System;

namespace Week1
    {
    /// <summary>
    /// Class that calculates asks for user input and calculated
    /// output based on the input.
    /// </summary>
    class Program
    {
        /// <summary>
        /// This program will ask for user input in order to calculate
        /// the distance between two points as well as th angle using
        /// the pythagorean therom
        /// </summary>
        /// <param name="args">command-Line args</param>
        static void Main(string[] args)
        {
            //Print a welcome and descriptive message
            Console.WriteLine("Welcome!  This program will calculate will "
                                + "\ncalculate the distance between two points, "
                                + "\nand the angle between those points.");
            Console.WriteLine();

            ///Obtains the first x and Y points from user input
            Console.Write("Please enter the \"x\" value for the first point: ");
            float pointOneX = float.Parse(Console.ReadLine());
            Console.Write("Please enter the \"y\" value for the first point: ");
            float pointOneY = float.Parse(Console.ReadLine());

            ///Obtains the second x and Y points from user input
            Console.Write("Please enter the \"x\" value for the second point: ");
            float pointTwoX = float.Parse(Console.ReadLine());
            Console.Write("Please enter the \"y\" value for the second point: ");
            float pointTwoY = float.Parse(Console.ReadLine());

            ///Calculates delta x(a) and delta y(b)
            float deltaX = pointTwoX - pointOneX;
            float deltaY = pointTwoY - pointOneY;

            //Calculates a^2, b^2 and c^2
            float a = deltaX * deltaX;
            float b = deltaY * deltaY;
            float cSquared = a + b;
            double c = Math.Sqrt(cSquared);
            
            //Converts radians to degrees to obtain angle
            double radians = Math.Atan2(deltaY, deltaX);
            double angle = radians * (180 / Math.PI);

            //Output c, radians, angle in degrees
            Console.WriteLine("The distince between point x and point y is: " + (c.ToString("f3")));
            Console.WriteLine("The radians are: " + (radians.ToString("f3")));
            Console.WriteLine("The angle is  " + angle + " degrees.");
         }
    }
}