using BuccaneersWeatherWatch.Web.Configurations;
using BuccaneersWeatherWatch.Web.Models;
using System.Net.Http.Json;

namespace BuccaneersWeatherWatch.Web.Services
{
    public class GeoCodingService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;

        public GeoCodingService(HttpClient httpClient, AppSettings appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings;
        }

        public async Task<List<GeoCodingLocationData>> GetGeoCodingDataAsync(string searchString)
        {
            string apiUrl = $"{_appSettings.GetGeoCodingInfo().GeoLocationApi}search?key={_appSettings.GetGeoCodingInfo().GeoLocationApiKey}&q={searchString}&format=json";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<GeoCodingLocationData>>() ?? new List<GeoCodingLocationData>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}");
            }
        }
    }
}
