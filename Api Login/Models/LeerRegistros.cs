using System.Text.Json;

namespace Api_Login.Models
{
    public class LeerRegistros
    {
        public List<Registro> leerRegistros()
        {
            if (File.Exists("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api Login\\Registros.json"))
            {
                string getJson = File.ReadAllText("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api Login\\Registros.json");
                List<Registro> allRegistro = JsonSerializer.Deserialize<List<Registro>>(getJson);
                return allRegistro;
            }
            else
            {
                return null;
            }

        }
    }
}
