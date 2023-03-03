using messageAnalyzer;
using MoodAnalyzer;

namespace MoodAnalyzerTest
{
    public class Tests
    {
     
        

        [Test]
        public void GivenSadMood_WhenAnalzer_ShouldReturnSad()
        {
            MoodAnalyzerProblem mood = new MoodAnalyzerProblem("I am in sad mood");
            string result = mood.AnalseMood();
            Assert.AreEqual("SAD",result);
        }

        [Test]
        public void GivenSadMood_WhenAnalzer_ShouldReturnHappy()
        {
            MoodAnalyzerProblem mood = new MoodAnalyzerProblem("I am in happy mood");
            string result = mood.AnalseMood();
            Assert.AreEqual("HAPPY", result);
        }

        [Test]
        public void GivenNull_WhenAnalzer_ShouldReturnHappy()
        {
            MoodAnalyzerProblem mood = new MoodAnalyzerProblem(null);
            string result = mood.AnalseMood();
            Assert.AreEqual("HAPPY", result);
        }
    }
}