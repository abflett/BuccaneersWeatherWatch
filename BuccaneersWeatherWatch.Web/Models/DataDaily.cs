namespace BuccaneersWeatherWatch.Web.Models
{
    public class DataDaily
    {
        public int Time { get; set; }
        public string Icon { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public int SunriseTime { get; set; }
        public int SunsetTime { get; set; }
        public double MoonPhase { get; set; }
        public double PrecipIntensity { get; set; }
        public double PrecipIntensityMax { get; set; }
        public int PrecipIntensityMaxTime { get; set; }
        public double PrecipProbability { get; set; }
        public double PrecipAccumulation { get; set; }
        public string PrecipType { get; set; } = string.Empty;
        public double TemperatureHigh { get; set; }
        public int TemperatureHighTime { get; set; }
        public double TemperatureLow { get; set; }
        public int TemperatureLowTime { get; set; }
        public double ApparentTemperatureHigh { get; set; }
        public int ApparentTemperatureHighTime { get; set; }
        public double ApparentTemperatureLow { get; set; }
        public int ApparentTemperatureLowTime { get; set; }
        public double DewPoint { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public int WindGustTime { get; set; }
        public double WindBearing { get; set; }
        public double CloudCover { get; set; }
        public double UvIndex { get; set; }
        public int UvIndexTime { get; set; }
        public double Visibility { get; set; }
        public double TemperatureMin { get; set; }
        public int TemperatureMintime { get; set; }
        public double TemperatureMax { get; set; }
        public int TemperatureMaxTime { get; set; }
        public double ApparentTemperatureMin { get; set; }
        public int ApparentTemperatureMintime { get; set; }
        public double ApparentTemperatureMax { get; set; }
        public int ApparentTemperatureMaxTime { get; set; }
    }

}
