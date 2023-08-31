namespace BuccaneersWeatherWatch.Web.Models
{
    public class WeatherData
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Timezone { get; set; } = string.Empty;
        public double Offset { get; set; }
        public double Elevation { get; set; }
        public Currently Currently { get; set; } = new Currently();
        public Minutely Minutely { get; set; } = new Minutely();
        public Hourly Hourly { get; set; } = new Hourly();
        public Daily Daily { get; set; } = new Daily();
        public Flags Flags { get; set; } = new Flags();
    }
}
