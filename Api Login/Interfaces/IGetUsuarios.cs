using Api_Login.Models;

namespace Api_Login.Interfaces
{
    public interface IGetUsuarios
    {
        public List<Usuario> GetAllUsuarios();
    }
}
