using Microsoft.Win32;
using System.Text.Json;

namespace Api_Login.Models
{
    public class DBUser 
    {
        public static List<Usuario> allRegistro;
        public List<Usuario> leerRegistros()
        {
            if (File.Exists("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api\\Api Login\\Registros.json"))
            {
                string getJson = File.ReadAllText("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api\\Api Login\\Registros.json");
                allRegistro = JsonSerializer.Deserialize<List<Usuario>>(getJson);
                return allRegistro;
            }
            else
            {
                return null;
            }

        }
        public static void leerDB()
        {
            if (File.Exists("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api\\Api Login\\Registros.json"))
            {
                string getJson = File.ReadAllText("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api\\Api Login\\Registros.json");
                allRegistro = JsonSerializer.Deserialize<List<Usuario>>(getJson);
            }
        }
    }
}
