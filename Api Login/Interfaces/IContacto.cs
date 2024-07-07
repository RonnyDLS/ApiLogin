using Api_Login.Models;

namespace Api_Login.Interfaces
{
    public interface IContacto
    {
        public string addContacto(int idUsuario, Contacto contacto);
    }
}
