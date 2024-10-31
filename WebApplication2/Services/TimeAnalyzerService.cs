namespace WebApplication2.Services
{
    public class TimeAnalyzerService : ITimeAnalyzerService
    {
        public string AnalyzeCurrentTime()
        {
            var currentTime = DateTime.Now.TimeOfDay;

            if (currentTime.Hours >= 12 && currentTime.Hours < 18)
            {
                return "Зараз день";
            }
            else if (currentTime.Hours >= 18 && currentTime.Hours < 24)
            {
                return "Зараз вечір";
            }
            else if (currentTime.Hours >= 0 && currentTime.Hours < 6)
            {
                return "Зараз ніч";
            }
            else
            {
                return "Зараз ранок";
            }
        }
    }
}