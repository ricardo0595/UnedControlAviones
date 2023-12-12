using UnedControlAviones.Models;
using Microsoft.AspNetCore.Mvc;

namespace UnedControlAviones.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngresosController : ControllerBase
    {
        

        private readonly AppDbContext _context;

        public IngresosController(AppDbContext context)
        {
            _context = context;
        }


        //[HttpGet(Name = "GetAviones")]
        //public IEnumerable<Avion> Get()
        //{
        //    List<Avion> aviones = null;
          
        //       aviones = _context.Avion.ToList();
        //    return aviones;
        //}

        [HttpPost(Name = "PostIngresos")]
        public IActionResult Post([FromBody] Ingreso ingreso)
        {
            if (ingreso != null)
            {
                _context.Add(ingreso);
                 _context.SaveChanges();

                return Ok(ingreso.Id);
            }
            else
            {
                return StatusCode(500, "ingreso es null");
            }
        }

    }
}