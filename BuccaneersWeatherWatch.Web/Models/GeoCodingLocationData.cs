namespace BuccaneersWeatherWatch.Web.Models
{

    public class GeoCodingLocationData
    {
        public string Place_id { get; set; } = string.Empty;
        public string Licence { get; set; } = string.Empty;
        public string Osm_type { get; set; } = string.Empty;
        public string Osm_id { get; set; } = string.Empty;
        public List<string> Boundingbox { get; set; } = new List<string>();
        public string Lat { get; set; } = string.Empty;
        public string Lon { get; set; } = string.Empty;
        public string Display_name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public float Importance { get; set; }
        public string Icon { get; set; } = string.Empty;
    }

}
