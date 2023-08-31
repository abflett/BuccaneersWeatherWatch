namespace BuccaneersWeatherWatch.Web.Models
{
    public class Daily
    {
        public string Summary { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public List<DataDaily> Data { get; set; } = new List<DataDaily>();
    }

}
