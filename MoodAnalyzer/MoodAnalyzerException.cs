using System;


namespace MoodAnalyzer
{
    public class MoodAnalyzerException : Exception
    {
        public enum MoodAnalyzerExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
        }
        public MoodAnalyzerExceptionType Type;
        public MoodAnalyzerException(MoodAnalyzerExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
