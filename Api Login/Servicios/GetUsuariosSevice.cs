using Api_Login.Interfaces;
using Api_Login.Models;

namespace Api_Login.Servicios
{
    public class GetUsuariosSevice : IGetUsuarios
    {
        public List<Usuario> GetAllUsuarios()
        {
            DBUser leerRegistros = new DBUser();

            List<Usuario> getReg = leerRegistros.leerRegistros();
            return getReg;
        }
    }
}
