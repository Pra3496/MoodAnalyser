using System;


namespace MoodAnalyzer
{
    public class MoodAnalyzerException : Exception
    {
        public enum MoodAnalyzerExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD
        }
        public MoodAnalyzerExceptionType Type;
        public MoodAnalyzerException(MoodAnalyzerExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
