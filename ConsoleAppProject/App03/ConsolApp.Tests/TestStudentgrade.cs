using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsolApp.Tests;


namespace ConsolApp.Tests
{
    [TestClass]
    public class StudentgradeTest
    {
        private readonly StudentGrades converter = new StudentGrades();
        private int[] testMarks;
        public TestStudentgrade()
        {
            testMarks = new int[]
            {
                10,
                20,
                30,
                40,
                50,
                60,
                70,
                80,
                90,
                100
            };
        }
        [TestMethod]

        public void TestConvert0toGradeF()
        {
            ///Arrange
            Grades expectedGrade = new Grades.F;

            //Act
            Grades ActualGrade = converter.ConvertToGrade(0);

            //Assert
            Assert.AreEqual(expectedGrade, ActualGrade);
        }
        
       

            [TestMethod]

            public void TestConvert39toGradeF()
            {
                ///Arrange
                Grades expectedGrade = new Grades.F;

                //Act
                Grades ActualGrade = converter.ConvertToGrade(39);

                //Assert
                Assert.AreEqual(expectedGrade, ActualGrade);
            }

        [TestMethod]
        public void TestCalculateMean()
        {
            converter.Marks = testMarks;
            double expectatedMean = 55.0;
            converter.CalculateStats();
            Assert.AreEqual(expectatedMean, converter.Mean);
        }


        [TestMethod]
        public void TestGradeProfile()
        {
            StudentGrades.Marks = StatMarks;
            bool expectedProfile = false;

            StudentGrades.CalculateGradeProfile();
            expectedProfile = (StudentGrades.GradeProfile[0] == 3) &&
                             (StudentGrades.GradeProfile[1] == 1) &&
                             (StudentGrades.GradeProfile[2] == 1) &&
                             (StudentGrades.GradeProfile[3] == 1) &&
                             (StudentGrades.GradeProfile[4] == 4);

            Assert.IsTrue(expectedProfile);
        }

}