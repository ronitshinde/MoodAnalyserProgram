using MoodAnalyser;
namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem();

        [Test]
        public void GivenSadMood_WhenAnalyzed_ShouldReturnSad()
        {
            string result = moodAnalyzer.AnalyseMood("I Am In Sad Mood");
            Assert.AreEqual(result, "Sad");
        }
    }
}