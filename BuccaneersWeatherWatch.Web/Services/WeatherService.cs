using BuccaneersWeatherWatch.Web.Models;
using System.Net.Http.Json;

namespace BuccaneersWeatherWatch.Web.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;

        public WeatherService(HttpClient httpClient, AppSettings appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings;
        }

        public async Task<WeatherData> GetWeatherDataAsync(double latitude, double longitude, string? units = "ca")
        {
            string apiUrl = $"{_appSettings.GetWeatherInfo().WeatherApi}{_appSettings.GetWeatherInfo().WeatherApiKey}/{latitude},{longitude}?units={units}";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<WeatherData>() ?? new WeatherData();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}");
            }
        }
    }
}
