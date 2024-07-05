namespace Api_Login.Models
{
    public class Registro
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string pass {  get; set; }

        public Registro(string nombre, string apellido, string email, string pass)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.pass = pass;
        }
    }
}
