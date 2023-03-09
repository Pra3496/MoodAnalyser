
using System;
using static MoodAnalyzer.MoodAnalyzerException;

namespace MoodAnalyzer
{
    public class MoodAnalyzerProblem
    {
        string message;

        public MoodAnalyzerProblem()
        {
            //message
        }


        public MoodAnalyzerProblem(string message)
        {
            this.message = message;
        }
        public string AnalseMood()
        {
            try
            {
                if(this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerExceptionType.EMPTY_MOOD, "Message should Not be Empty");
                }

                if (this.message.Contains("sad"))
                {
                    return "SAD";

                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(NullReferenceException)
            {
              
                throw new MoodAnalyzerException(MoodAnalyzerExceptionType.NULL_MOOD, "Message Should Not be Null");
            }
            
            
        }
    }
}
