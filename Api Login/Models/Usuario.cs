namespace Api_Login.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string pass {  get; set; }
        public string direccion {  get; set; }
        public List<Contacto> contactos { get; set; }

        public Usuario(string nombre, string apellido, string email, string pass, string direccion, List<Contacto> contactos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.pass = pass;
            this.direccion = direccion;
            this.contactos = contactos;
        }
    }
}
