using DummyWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DummyWebApi.DBContext
{
    public class WeatherDBContext : DbContext
    {
        public WeatherDBContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<WeatherModel> weather { get; set; }
        public DbSet<CountryStateWeatherModel> countryStateWeather { get; set; }

    }
}
