using Api_Login.Interfaces;
using Api_Login.Models;
using Api_Login.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Api_Login.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        public readonly IGetUsuarios _getUsuarios;
        public readonly IRegistrarUsuario _registrarUsuario;
        public readonly IValidarLogin _validarLogin;
        public readonly IContacto _contacto;
        public readonly IEditarContacto _editarContacto;
        public readonly IEliminarContacto _eliminarContacto;
        public LoginController(IGetUsuarios getUsuarios, IRegistrarUsuario registrarUsuario, IValidarLogin validarLogin, IContacto contacto, IEditarContacto editarContacto, IEliminarContacto eliminarContacto)
        {
            _getUsuarios = getUsuarios;
            _registrarUsuario = registrarUsuario;
            _validarLogin = validarLogin;
            _contacto = contacto;
            _editarContacto = editarContacto;
            _eliminarContacto = eliminarContacto;
        }



        [HttpPost("Validar")]
        public ValidarLogin confirmarUsuario(UsuarioCredenciales usuario)
        {
            return _validarLogin.validar(usuario);
        }


        [HttpPost("Registrar")]
        public IActionResult addUsuario(Usuario usuario)
        {
            _registrarUsuario.registrarUsuario(usuario);

            return Ok("Registrado correctamente");
        }


        [HttpPost("AddContacto")]
        public IActionResult addContacto(int idUsuario,Contacto contacto)
        {
            return Ok(_contacto.addContacto(idUsuario, contacto));
        }

        [HttpPut("{id}")]
        public IActionResult editarContacto(int id, Contacto contacto)
        {
            _editarContacto.editarContacto(id, contacto);
            return Ok("Contacto editado con exito");
        }

        [HttpDelete("{id}")]
        public IActionResult eliminarContacto(int id, Contacto contacto)
        {
            _eliminarContacto.eliminarContacto(id,contacto);
            return Ok("Contacto eliminado exitosamente");
        }

        [HttpGet("ObtenerUsuarios")]
        public List<Usuario> getUsuarios()
        {
            return _getUsuarios.GetAllUsuarios();
        }

    }
}
