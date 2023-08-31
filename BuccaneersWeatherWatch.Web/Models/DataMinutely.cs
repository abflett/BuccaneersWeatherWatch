namespace BuccaneersWeatherWatch.Web.Models
{
    public class DataMinutely
    {
        public int Time { get; set; }
        public double PrecipIntensity { get; set; }
        public double PrecipProbability { get; set; }
        public double PrecipIntensityError { get; set; }
        public string PrecipType { get; set; } = string.Empty;
    }

}
