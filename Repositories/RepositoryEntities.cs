using DummyWebApi.Models;

namespace DummyWebApi.Repositories
{
    public interface IRepositories<T> where T : class
    {
        Task<T?> GetWeatherById();
        Task<List<T>> GetAllWeather();
        Task<bool> UpdateWeather(T? weather);
        Task<bool> AddWeather(T? weather);
        Task<bool?> DeleteWeather(T? weather);
    }
    public class Repositories<T> : IRepositories<T> where T : class
    {
        public Task<T?> GetWeatherById()
        {
            // Implementation for getting weather by ID
            return Task.FromResult<T?>(null);
        }

        public Task<List<T>> GetAllWeather()
        {
            // Implementation for getting all weather
            return Task.FromResult(new List<T>());
        }

        public Task<bool> UpdateWeather(T? weather)
        {
            // Implementation for updating weather
            return Task.FromResult(true);
        }

        public Task<bool> AddWeather(T? weather)
        {
            // Implementation for adding weather
            return Task.FromResult(true);
        }

        public Task<bool?> DeleteWeather(T? weather)
        {
            // Implementation for deleting weather
            return Task.FromResult<bool?>(true);
        }
    }

    public interface IWeatherRepository : IRepositories<WeatherModel>
    {
        // Additional methods specific to WeatherModel can be defined here

        Task<WeatherModel?> GetWeatherByDate(DateOnly date);
        Task<List<WeatherModel>> GetWeatherByDateRange(DateTime startDt, DateTime endDt);
    }

    public class WeatherRepository : Repositories<WeatherModel>, IWeatherRepository
    {

        public Task<WeatherModel?> GetWeatherByDate(DateOnly date)
        {
            // Implementation for getting weather by date
            return Task.FromResult<WeatherModel?>(null);
        }

        public Task<List<WeatherModel>> GetWeatherByDateRange(DateTime startDt, DateTime endDt)
        {
            // Implementation for getting weather by date range
            return Task.FromResult(new List<WeatherModel>());

        }
    }
}
