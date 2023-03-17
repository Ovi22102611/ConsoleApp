
using ConsoleAppProject.Helpers;
using System;
using System.Runtime.CompilerServices;

namespace ConsoleAppProject.App01
{




    public class DistanceConverter
    {
        // distance conversion constants
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        // distance variables 
        private double fromDistance;
        private double toDistance;
        // Unit variables 
        private string fromUnit;
        private string toUnit;
        // distance units names
        public const string FEET = "Feet";
        public const string MILES = "Miles";
        public const string METRES = "Metres";

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = METRES;
        }

        public void ConvertDistance()
        {

            fromUnit = SelectUnit("Please select the form distance unit = ");
            toUnit = SelectUnit("Please select the to distance unit = ");
            OutputHeading($"Converting {fromUnit} to {toUnit}"); //Heading prompt value
            fromDistance = InputDistance($"Please Enter The Number Of {fromUnit} ");// input distance() prompt value
            CalculateDistance();
            OutputDistance();

        }


        private void OutputHeading(string prompt) // creating a string parameter for the Heading;
        {
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("   DISTANCE CONVERTER  ");
            Console.WriteLine("   By MD JUNAEDUR RAHAMAN OVI");
            Console.WriteLine(" =================================================");
            Console.WriteLine(prompt);
            Console.WriteLine();

        }



        private double InputDistance(string prompt) // Creating parameter for taking input number for distance
        {
            Console.Write(prompt);
            Console.Write(" = ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);

        }


        private void OutputDistance()
        {
            Console.WriteLine(($"{fromDistance} {fromUnit}" +
                    $" is {toDistance} {toUnit}!"));
        }

        private string SelectUnit(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.WriteLine(prompt);

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice == "3")
            {
                return MILES;
            }
            return null;

        }

       private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }


            }

        
    }
}

