using BuccaneersWeatherWatch.Web.Configurations;

namespace BuccaneersWeatherWatch.Web.Services
{
    public class AppSettings
    {
        private readonly IConfiguration _configuration;

        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public WeatherInfo GetWeatherInfo()
        {
            return new WeatherInfo
            {
                WeatherApi = _configuration["WeatherInfo:WeatherApi"] ?? string.Empty,
                WeatherApiKey = _configuration["WeatherInfo:WeatherApiKey"] ?? string.Empty
            };
        }

        public GeoCodingInfo GetGeoCodingInfo()
        {
            return new GeoCodingInfo
            {
                GeoLocationApi = _configuration["GeoCodingInfo:GeoLocationApi"] ?? string.Empty,
                GeoLocationApiKey = _configuration["GeoCodingInfo:GeoLocationApiKey"] ?? string.Empty,
            };
        }
    }
}
