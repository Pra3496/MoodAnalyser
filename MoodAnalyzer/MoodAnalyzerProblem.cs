using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messageAnalyzer
{
    public class MoodAnalyzerProblem
    {
        string message;

        public MoodAnalyzerProblem(string message)
        {
            this.message = message;
        }
        public string Analsemessage()
        {
            try
            {
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
                return "HAPPY";
            }
            
            
        }
    }
}
