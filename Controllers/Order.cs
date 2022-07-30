using Microsoft.AspNetCore.Mvc;
using FoodApi.Models.DB;

namespace FoodApi.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<OrderController> _logger;

    public WeatherForecastController(ILogger<OrderController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "{id}")]
    public IEnumerable<OrderController> Get()
    {

        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
