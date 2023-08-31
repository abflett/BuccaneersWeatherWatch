namespace BuccaneersWeatherWatch.Web.Models
{
    public class Flags
    {
        public List<string> Sources { get; set; } = new List<string>();
        public Sourcetimes SourceTimes { get; set; } = new Sourcetimes();
        public double Neareststation { get; set; }
        public string Units { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
    }

}
