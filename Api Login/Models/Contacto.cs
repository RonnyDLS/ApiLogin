namespace Api_Login.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        public string contacto { get; set; }
        public string descripcion { get; set; }

        public Contacto(string contacto, string descripcion, int Id)
        {
            this.contacto = contacto;
            this.descripcion = descripcion;
            this.Id = Id;
        }
    }
}
