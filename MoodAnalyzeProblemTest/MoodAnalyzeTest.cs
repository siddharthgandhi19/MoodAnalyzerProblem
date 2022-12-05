using MoodAnalyzerProblem;

namespace MoodAnalyzerProblemTest
{
    public class MoodAnalyzerTest
    {
        [Test] //TC1.1
        public void GivenSadMood_WhenAnalyze_ShouldReturnSad()
        {
            MoodAnalyzer analyzer = new MoodAnalyzer("I am in a Sad Mood"); //Arrange
            string result = analyzer.AnalyzeMood(); //Act
            Assert.AreEqual(result, "Sad");
        }

        [Test] //TC1.2
        public void GivenAnyMood_WhenAnalyze_ShouldReturnHappy()
        {
            MoodAnalyzer analyzer = new MoodAnalyzer("I am in a Any Mood"); //Arrange
            string result = analyzer.AnalyzeMood(); //Act
            Assert.AreEqual(result, "Happy");
        }

        [Test]
        public void GivenNullMood_WhenAnalyze_ShouldReturnHappy()
        {
            MoodAnalyzer analyzer = new MoodAnalyzer(null); //Arrange
            string result = analyzer.AnalyzeMood(); //Act
            Assert.AreEqual(result, "Happy");
        }
    }
}