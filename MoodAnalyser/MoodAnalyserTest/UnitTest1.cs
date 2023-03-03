using MoodAnalyser;
namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMood_WhenAnalyzed_ShouldReturnSad()
        {
            MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem("I Am In Sad Mood");
            string result = moodAnalyzer.AnalyseMood();
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenHappyMood_WhenAnalyzed_ShouldReturnHappy()
        {
            MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem("I Am In Any Mood");
            string result = moodAnalyzer.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMood_WhenAnalyzed_ShouldReturnHappy()
        {
            MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem(null);
            string result = moodAnalyzer.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
    }
}