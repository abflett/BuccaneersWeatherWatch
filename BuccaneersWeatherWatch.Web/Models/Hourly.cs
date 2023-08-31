namespace BuccaneersWeatherWatch.Web.Models
{
    public class Hourly
    {
        public string Summary { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public List<DataHourly> Data { get; set; } = new List<DataHourly>();
    }

}
