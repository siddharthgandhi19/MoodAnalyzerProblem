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
            if (string.IsNullOrEmpty(message))
                return "Happy";
            if (message.Contains("Sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}
          
