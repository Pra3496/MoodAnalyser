using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static MoodAnalyzer.MoodAnalyzerException;

namespace MoodAnalyzer
{
    public class MoodAnalyzerReflection
    {
        
        public static object CreateMoodAnalyzer(string className,string constructorName)
        { 
             string pattern = @"."+constructorName+"$";
            Match result = Regex.Match(pattern, className);

            if(true) 
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type MoodAnalyzerProgblemType = executing.GetType(className);
                    return Activator.CreateInstance(MoodAnalyzerProgblemType);  
                }
                catch (ArgumentNullException) 
                {
                    throw new MoodAnalyzerException(MoodAnalyzerExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerException(MoodAnalyzerExceptionType.NO_SUCH_METHOD, "Constructor is Not Found");
            }
        }
      
    }
}
