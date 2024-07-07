using Api_Login.Interfaces;
using Api_Login.Models;
using Microsoft.Win32;
using System.Text.Json;

namespace Api_Login.Servicios
{
    public class RegistrarUsuarioService : IRegistrarUsuario
    {
        public void registrarUsuario(Usuario usuario)
        {
            DBUser.leerDB();
            usuario.Id = DBUser.allRegistro.Count() + 1;

            if (!File.Exists("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api\\Api Login\\Registros.json"))
            {
                DBUser.allRegistro.Add(usuario);
                string jsonRegistro = JsonSerializer.Serialize(DBUser.allRegistro);
                File.WriteAllText("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api\\Api Login\\Registros.json", jsonRegistro);
            }
            else
            {
                string getJson = File.ReadAllText("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api\\Api Login\\Registros.json");
                List<Usuario> lista = JsonSerializer.Deserialize<List<Usuario>>(getJson);
                lista.Add(usuario);
                string jsonRegistro = JsonSerializer.Serialize(lista);
                File.WriteAllText("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api\\Api Login\\Registros.json", jsonRegistro);
            }
        }
    }
}
