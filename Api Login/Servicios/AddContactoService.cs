using Api_Login.Interfaces;
using Api_Login.Models;
using System.Text.Json;

namespace Api_Login.Servicios
{
    public class AddContactoService : IContacto
    {
        public string addContacto(int idUsuario, Contacto contacto)
        {
            if (!contacto.contacto.Equals(""))
            {
                DBUser.leerDB();

                for (int i = 0; i < DBUser.allRegistro.Count(); i++)
                {
                    if (DBUser.allRegistro[i].Id == idUsuario)
                    {
                        contacto.Id = DBUser.allRegistro[i].contactos.Count() + 1;
                        DBUser.allRegistro[i].contactos.Add(contacto);
                    }
                }

                if (File.Exists("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api\\Api Login\\Registros.json"))
                {
                    string jsonRegistro = JsonSerializer.Serialize(DBUser.allRegistro);
                    File.WriteAllText("C:\\Users\\Ronny\\source\\repos\\Api Login\\Api\\Api Login\\Registros.json", jsonRegistro);
                }

                return "Contacto agregado correctamente";
            }else
            {
                return "El tipo de contacto esta vacio";
            }
            
        }
    }
}
