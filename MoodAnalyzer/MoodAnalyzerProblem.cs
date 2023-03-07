using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyzer.MoodAnalyzerException;

namespace messageAnalyzer
{
    public class MoodAnalyzerProblem
    {
        string message;

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
