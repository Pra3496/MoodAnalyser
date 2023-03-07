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

        
        public void GivenNull_WhenAnalzer_ShouldReturnHappy()
        {
            MoodAnalyzerProblem mood = new MoodAnalyzerProblem(null);
            string result = mood.AnalseMood();
            Assert.AreEqual("HAPPY", result);
        }

        [Test]
        public void GivenNullMessage_ThrowMoodAnalyserException_NullMessage()
        {
            try
            {
                MoodAnalyzerProblem mood = new MoodAnalyzerProblem(null);
                string result = mood.AnalseMood();

            }
            catch (MoodAnalyzerException moodAnlzerException)
            {
                Assert.AreEqual("Message Should Not be Null", moodAnlzerException.Message);
            }
        }

        public void GivenEmptyMessage_ThrowMoodAnalyserException_EmptyMessage()
        {
            try
            {
                MoodAnalyzerProblem mood = new MoodAnalyzerProblem(string.Empty);
                string result = mood.AnalseMood();

            }
            catch (MoodAnalyzerException moodAnlzerException)
            {
                Assert.AreEqual("Message should not be Empty", moodAnlzerException.Message);
            }
        }

    }
}