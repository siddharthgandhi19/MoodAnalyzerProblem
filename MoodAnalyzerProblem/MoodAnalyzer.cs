using MoodAnalyzerProblem;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                    throw new MoodAnalyzerException(MoodAnalyzerException.MoodAnalyzerExceptionType.EMPTY_MOOD, "Mood is empty");
                else if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            } catch (Exception )
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.MoodAnalyzerExceptionType.NULL_MOOD, "Mood is null");
            }
        }
    }
}
