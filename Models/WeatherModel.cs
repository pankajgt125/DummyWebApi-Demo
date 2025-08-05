using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DummyWebApi.Models
{
    public class WeatherModel
    {
        [Key]
        public int WMId { get; set; }
        public DateOnly Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string? Summary { get; set; }
        public int Humidity { get; set; }
        public double WindSpeed { get; set; }
    }

      public class CountryStateWeatherModel
    {
        [Key]
        public int SWMId { get; set; }
        public string Country { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public List<WeatherModel> WeatherDetails { get; set; } = new();
    }

    
}
