using Api_Login.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_Login.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        [HttpPost("Registrar")]
        public IActionResult addRegistro(Registro registro)
        {
            GuardarRegistro gRegistro = new GuardarRegistro();
            gRegistro.guardarRegistro(registro);
            Console.WriteLine(registro.nombre);

            return Ok("Registrado correctamente");
        }
        
        [HttpGet("ObtenerRegistros")]
        public List<Registro> getRegistros()
        {
            LeerRegistros leerRegistros = new LeerRegistros();

            List<Registro> getReg = leerRegistros.leerRegistros();
            return getReg;
        }

    }
}
