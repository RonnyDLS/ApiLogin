using Api_Login.Models;

namespace Api_Login.Interfaces
{
    public interface IEditarContacto
    {
        public void editarContacto(int id, Contacto contacto);
    }
}
