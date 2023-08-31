namespace BuccaneersWeatherWatch.Web.Models
{
    public class Minutely
    {
        public string Summary { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public List<DataMinutely> Data { get; set; } = new List<DataMinutely>();
    }

}
