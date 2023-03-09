
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
        [Test]
        public void GivenEmptyMessage_ThrowMoodAnalyserException_EmptyMessage()
        {
            try
            {
                MoodAnalyzerProblem mood = new MoodAnalyzerProblem(string.Empty);
                string result = mood.AnalseMood();

            }
            catch (MoodAnalyzerException moodAnlzerException)
            {
                Assert.AreEqual("Message should Not be Empty", moodAnlzerException.Message);
            }
        }

        [Test]
        public void GivenMoodAnalyzerClassName_shouldReturn_MoodAnalyzerObject()
        {
            string message = "";
            object expected = new MoodAnalyzerProblem(message);

            object obj = MoodAnalyzerReflection.CreateMoodAnalyzer("MoodAnalyzer.MoodAnalyzerProblem","MoodAnalyzerProblem");
            expected.Equals(obj);
        }


        [Test]
        public void GivenMoodAnalyzerClassName_shouldReturn_ExceptionCLASS_NOT_FOUND()
        {
            try
            {
                string message = "";
                object expectedClass = new MoodAnalyzerProblem(message);

                Object obj = MoodAnalyzerReflection.CreateMoodAnalyzer("MoodAnalyzer.MoodAnalyzerProblem", "MoodAnalyzer");
            }
            catch (MoodAnalyzerException moodAnlzerException)
            {
                Assert.AreEqual("Class Not Found", moodAnlzerException.Message);
            }

        }
        [Test]
        public void GivenMoodAnalyzerClassName_shouldReturn_ExceptionCONSTRUCTOR_NOT_FOUND()
        {
            try
            {
                string message = "";
                object expectedClass = new MoodAnalyzerProblem(message);

                Object obj = MoodAnalyzerReflection.CreateMoodAnalyzer("MoodAnalyzer.MoodAnalyzerProblem", "MoodAnalyzer");
            }
            catch (MoodAnalyzerException moodAnlzerException)
            {
                Assert.AreEqual("Constructor is Not Found", moodAnlzerException.Message);
            }

        }






        [Test]
        public void GivenMoodAnalyzerClassName_shouldReturn_MoodAnalyzerObjec_UsingPar()
        {
            string message = "HAPPY";
            object expected = new MoodAnalyzerProblem(message);

            object obj = MoodAnalyzerReflection.CreateMoodAnalyzerUsingParameterizeConstructor("MoodAnalyzer.MoodAnalyzerProblem", "MoodAnalyzerProblem","HAPPY");
            expected.Equals(obj);
        }

        [Test]
        public void GivenMoodAnalyzerClassName_shouldReturn_Exception_UsingPar_CLASS_NOT_FOUND()
        {
            try
            {
                string message = "";
                object expected = new MoodAnalyzerProblem(message);

                Object obj = MoodAnalyzerReflection.CreateMoodAnalyzerUsingParameterizeConstructor("MoodAnalyzer.MoodAnalyzer", "MoodAnalyzerProblem","HAPPY");
                expected.Equals(obj);
            }
            catch (MoodAnalyzerException moodAnlzerException)
            {
                Assert.AreEqual("Class Not Found", moodAnlzerException.Message);
            }

        }

        [Test]
        public void GivenMoodAnalyzerClassName_shouldReturn_Exception_UsingPar_METHOD_NOT_FOUND()
        {
            try
            {
                string message = "";
                object expected = new MoodAnalyzerProblem(message);

                Object obj = MoodAnalyzerReflection.CreateMoodAnalyzerUsingParameterizeConstructor("MoodAnalyzer.MoodAnalyzerProblem", "MoodAnalyzer", "HAPPY");
                expected.Equals(obj);
            }
            catch (MoodAnalyzerException moodAnlzerException)
            {
                Assert.AreEqual("Constructor is Not Found", moodAnlzerException.Message);
            }

        }



    }
}