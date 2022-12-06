using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerException : Exception
    {
        public enum MoodAnalyzerExceptionType
        {
            NULL_MOOD, EMPTY_MOOD
        }
        public MoodAnalyzerExceptionType type;
        public MoodAnalyzerException(MoodAnalyzerExceptionType type, string message)
            : base(message)
        {
            this.type = type;
        }
    }
}
