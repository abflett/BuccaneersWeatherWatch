using BuccaneersWeatherWatch.Web.Configurations;
using BuccaneersWeatherWatch.Web.Models;
using System.Net.Http.Json;

namespace BuccaneersWeatherWatch.Web.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly WeatherInfo _weatherInfo;

        public WeatherService(HttpClient httpClient, AppSettings appSettings)
        {
            _httpClient = httpClient;
            _weatherInfo = appSettings.GetWeatherInfo();
        }

        public async Task<WeatherData> GetWeatherDataAsync(string latitude, string longitude, string? units = "ca")
        {
            // Todo: Add the following, Time, Extend, Exclude, Lang, Units for complete features - http://pirateweather.net/en/latest/API/#request-parameters
            string apiUrl = $"{_weatherInfo.WeatherApi}{_weatherInfo.WeatherApiKey}/{latitude},{longitude}?exclude=minutely,hourly,alerts&units={units}";
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
