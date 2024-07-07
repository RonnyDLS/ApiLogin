using Api_Login.Interfaces;
using Api_Login.Models;
using System.Text.Json;

namespace Api_Login.Servicios
{
    public class EliminarContactoServices : IEliminarContacto
    {
        public void eliminarContacto(int id, Contacto contacto)
        {
            DBUser.leerDB();

            for (int i = 0; i < DBUser.allRegistro.Count; i++)
            {
                if (DBUser.allRegistro[i].Id == id)
                {
                    for (int j = 0; j < DBUser.allRegistro[i].contactos.Count; j++)
                    {
                        if (DBUser.allRegistro[i].contactos[j].Id == contacto.Id)
                        {
                            DBUser.allRegistro[i].contactos.RemoveAt(j);
                        }
                    }
                }
            }

            if (File.Exists("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api\\Api Login\\Registros.json"))
            {
                string jsonRegistro = JsonSerializer.Serialize(DBUser.allRegistro);
                File.WriteAllText("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api\\Api Login\\Registros.json", jsonRegistro);
            }
        }
    }
}
