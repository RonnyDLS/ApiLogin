using System.IO;
using System.Text.Json;
namespace Api_Login.Models
{
    public class GuardarRegistro
    {
        List<Registro> listaRegistros = new List<Registro>();
        public void guardarRegistro(Registro registro)
        {
            if (!File.Exists("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api Login\\Registros.json"))
            {
                listaRegistros.Add(registro);
                string jsonRegistro = JsonSerializer.Serialize(listaRegistros);
                File.WriteAllText("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api Login\\Registros.json", jsonRegistro);
            }else
            {
                string getJson = File.ReadAllText("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api Login\\Registros.json");
                List<Registro> lista = JsonSerializer.Deserialize<List<Registro>>(getJson);
                lista.Add(registro );
                string jsonRegistro = JsonSerializer.Serialize(lista);
                File.WriteAllText("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api Login\\Registros.json", jsonRegistro);
            }
        }
    }
}
