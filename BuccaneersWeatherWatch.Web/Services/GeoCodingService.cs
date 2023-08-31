using BuccaneersWeatherWatch.Web.Configurations;
using BuccaneersWeatherWatch.Web.Models;
using System.Net.Http.Json;

namespace BuccaneersWeatherWatch.Web.Services
{
    public class GeoCodingService
    {
        private readonly HttpClient _httpClient;
        private readonly GeoCodingInfo _geoCodingInfo;

        public GeoCodingService(HttpClient httpClient, AppSettings appSettings)
        {
            _httpClient = httpClient;
            _geoCodingInfo = appSettings.GetGeoCodingInfo();
        }

        public async Task<List<GeoCodingLocationData>> GetGeoCodingDataAsync(string searchString)
        {
            string apiUrl = $"{_geoCodingInfo.GeoLocationApi}search?key={_geoCodingInfo.GeoLocationApiKey}&q={searchString}&format=json";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<GeoCodingLocationData>>() ?? new List<GeoCodingLocationData>();
            }
            else
            {
                return new List<GeoCodingLocationData>();
            }
        }
    }
}
