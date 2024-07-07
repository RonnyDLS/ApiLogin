namespace Api_Login.Models
{
    public class UsuarioCredenciales
    {
        public string email { get; set; }
        public string pass { get; set; }

        public UsuarioCredenciales(string email, string pass)
        {
            this.email = email;
            this.pass = pass;
        }
    }
}
