﻿namespace BuccaneersWeatherWatch.Web.Models
{
    public class DataHourly
    {
        public int Time { get; set; }
        public string Icon { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public double PrecipIntensity { get; set; }
        public double PrecipProbability { get; set; }
        public double PrecipIntensityError { get; set; }
        public double PrecipAccumulation { get; set; }
        public string PrecipType { get; set; } = string.Empty;
        public double Temperature { get; set; }
        public double ApparentTemperature { get; set; }
        public double DewPoint { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public double WindBearing { get; set; }
        public double CloudCover { get; set; }
        public double UvIndex { get; set; }
        public double Visibility { get; set; }
        public double Ozone { get; set; }
    }

}
