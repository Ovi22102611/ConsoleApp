
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App01
{
  
    public class DistanceConverter
    {   public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        private double miles;
        private double feets;
        private double metres;
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles To Feet"); //Heading prompt value
            miles = InputDistance("Please Enter The Number Of Miles");// input distance() prompt value
            CalculateFeet();
            OutputFeet();
        }
        public void FeetToMiles()
        {
            OutputHeading("Converting Feet To miles"); // ''
            feets = InputDistance("Please Enter The Number Of Feet");// ''
            CalculateMiles();
            OutputMiles();
        }
        public void MilesToMetres()
        {
            OutputHeading("Converting Miles To Metres"); // ''
            miles = InputDistance("Please Enter The Number Of Miles");// ''
            CalculateMetres();
            OutputMetres();
        }


        private void OutputHeading(string prompt) // creating a string parameter for the Heading;
        {
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("   Convert Miles to feet  ");
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
        


        private void CalculateFeet() 
        {
            feets = miles * FEET_IN_MILES;
        }
        private void CalculateMiles()
        {
            miles = feets / FEET_IN_MILES;
        }
        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }






        private void OutputFeet()
        {
            Console.WriteLine(miles + " mile is " + feets + " feet!");
        }
        private void OutputMiles()
        {
            Console.WriteLine(feets + " feet is " + miles + " mile! ");
        }
        private void OutputMetres()
        {
            Console.WriteLine(miles + " mile is " + metres + " metres! ");
        }

    }
}
