using UnedControlAviones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace UnedControlAviones.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AvionesController : ControllerBase
    {
        

        private readonly ILogger<AvionesController> _logger;
        private readonly AppDbContext _context;

        public AvionesController(ILogger<AvionesController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet(Name = "GetAviones")]
        public IEnumerable<Avion> Get()
        {
            List<Avion> aviones = null;
          
               aviones = _context.Avion.ToList();
            return aviones;
        }

        [HttpPost(Name = "PostAviones")]
        public IActionResult Post([FromBody] Avion avion)
        {
            if (avion != null)
            {
                avion.Estado = true;
                _context.Add(avion);
                 _context.SaveChanges();

                return Ok(avion.Id);
            }
            else
            {
                return StatusCode(500, "Avion es null");
            }
        }

        [HttpPut(Name = "PutAviones")]
        public IActionResult Put([FromBody] Retiro retiro)
        {
            if (retiro != null)
            {
                Avion avion = _context.Avion.Find(retiro.IdAvion);
                avion.Estado = false;
                _context.Add(retiro);
                _context.Update(avion);
                _context.SaveChanges();

                return Ok(retiro.Id);
            }
            else
            {
                return StatusCode(500, "Retiro es null");
            }
        }

    }
}