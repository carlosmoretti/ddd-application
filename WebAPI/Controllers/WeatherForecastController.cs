using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.IoC;
using Service.IoC;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private ITodoService _todoService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ITodoService todoService)
        {
            _logger = logger;
            _todoService = todoService;
        }

        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return _todoService.GetAll();
        }

        [HttpPost]
        public void Post()
        {
            _todoService.Adicionar(new Domain.Todo()
            {
                Date = System.DateTime.Now,
                Description = "Testando...",
                Title = "Testando título!"
            });
        }
    }
}
