using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;


namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary> 
    public class StudentGrades
    {   //constants
        

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestMGradeA = 70;
        public const int HighestMark = 100;

        //properties
        public string[] Students {  get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public double Mean { get; set; }

        //Attributes



    public StudentGrades()
        {

            Students = new string[]
            {
              "Junaed", "Ovi", "Mohammad",
                "Hasan", "Ahmed", "Siddiqe",
                "Ashish", "Imad", "Kumar", 
                "Russel",

            }
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.length];
        }
/// 

        /// <summary>
        /// 
        /// </summary>
        public void MarkOutput()
        {
            GradeProfile grade = grade.X;
            ConsoleAppProject.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.length;
                ConsoleAppProject.WriteLine($"Grade{grade}{percentage}% Count {count}");
                grade++;
            }
            ConsoleAppProject.WriteLine();


        }



        /// <summary>
        /// 
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if(mark>=LowestGradeD&& mark< LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark < HighestMark)
            {
                return Grades.A;
            }
            return StudentGrades.F;

        }


        public void CalculateGradeProfile()
        {
            for (int i = 0;i< GradeProfile.length;i++)
            {
                GradeProfile[i] = 0;
            }
            foreach(int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)gra de]++;
            }

        }



        /// <summary>
        /// 
        /// </summary>
        /// 


        public void CalculateStats()
        {
            Minimum = HighestMark;
            Maximum = 0;
            double total = 0;
            foreach (int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if(mark < Minimum) Minimum = mark;
                  total += mark;
            }
            Mean = total / Marks.length;
        }

       
    }
}
