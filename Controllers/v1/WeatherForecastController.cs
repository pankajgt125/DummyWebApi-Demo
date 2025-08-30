using Asp.Versioning;
using DummyWebApi.Models;
using DummyWebApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace DummyWebApi.Controllers.v1;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherRepository _iWeatherRepositories;
    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherRepository iWeatherRepositories)
    {
        _logger = logger;
        _iWeatherRepositories = iWeatherRepositories;
    }

    [HttpGet]
    public IEnumerable<WeatherModel> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherModel
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
