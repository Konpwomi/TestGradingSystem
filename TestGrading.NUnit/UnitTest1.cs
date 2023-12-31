using System.Threading.Tasks.Dataflow;
using TestGrading;

namespace TestGradingNUnit
{
    public class UnitTest1
    {

        [Test]
        public void TS101_GradeBelowZero()
        {
            // Arrange
            int score = -2;
            // Act
            string grade = Grading.GradeCalculator(score);

            // Assert
            Assert.AreEqual("Invalid", grade);
        }

        [Test]
        public void TS102_GradeA()
        {
            int score = 84;
            String grade = Grading.GradeCalculator(score);
            Assert.AreEqual("A", grade);
        }

        [Test]
        public void TS103_GradeB()
        {
            int score = 75;
            String grade = Grading.GradeCalculator(score);
            Assert.AreEqual("B", grade);
        }

        [Test]
        public void TS104_GradeC()
        {
            int score = 65;
            String grade = Grading.GradeCalculator(score);
            Assert.AreEqual("C", grade);
        }

        [Test]
        public void TS105_GradeD()
        {
            int score = 55;
            String grade = Grading.GradeCalculator(score);
            Assert.AreEqual("D", grade);
        }

        [Test]
        public void TS106_GradeF()
        {
            int score = 45;
            String grade = Grading.GradeCalculator(score);
            Assert.AreEqual("F", grade);
        }

        [Test]
        public void TS106_GradeAbovehundred()
        {
            int score = 101;
            String grade = Grading.GradeCalculator(score);
            Assert.AreEqual("Invalid", grade);
        }

        [Test]
        public void TS201_OutputBelowZero()
        {
            int score = -2;
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Grading.PrintOut(score);
            string exp = "Error: Score is lower than zero\r\n";
            Assert.AreEqual(exp, sw.ToString());
        }

        [Test]
        public void TS202_OutputAboveHundred()
        {
            int score = 101;
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Grading.PrintOut(score);
            string exp = "Error: Score is higher than 100\r\n";
        }

        [Test]
        public void TS203_OutputCorrectGrade()
        {
            int score = 80;
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Grading.PrintOut(score);
            string exp = ("Grade is ");
        }

    }
}