using Api_Login.Models;

namespace Api_Login.Interfaces
{
    public interface IValidarLogin
    {
        public ValidarLogin validar(UsuarioCredenciales usuarioCredenciales);
    }
}
