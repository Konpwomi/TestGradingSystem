using TestGrading;

namespace TestGrading2.NUnit
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            //Arrange
            int score = 80;

            //Act
            String grade = Grading.GradeCalculator(score);

            //Assert
            Assert.AreEqual(grade, "A");
        }
        [Test]
        public void Test2()
        {
            int score = 75;
            String grade = Grading.GradeCalculator(score);
            Assert.AreEqual(grade, "B");

        }
    }
}