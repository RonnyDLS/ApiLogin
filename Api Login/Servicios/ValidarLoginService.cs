using Api_Login.Interfaces;
using Api_Login.Models;
namespace Api_Login.Servicios
{
    public class ValidarLoginService : IValidarLogin
    {
        public ValidarLogin validar(UsuarioCredenciales usuarioCredenciales)
        {
            ValidarLogin validar = new ValidarLogin();
            validar.Id = -1;
            validar.confimacion = false;
            
            DBUser.leerDB();
            
            for (int i = 0; i < DBUser.allRegistro.Count(); i++)
            {
                if (DBUser.allRegistro[i].email.Equals(usuarioCredenciales.email) && DBUser.allRegistro[i].pass.Equals(usuarioCredenciales.pass))
                {
                    validar.Id = DBUser.allRegistro[i].Id;
                    validar.confimacion = true;
                    return validar;
                }
            }

            return validar;
        }
    }
}
