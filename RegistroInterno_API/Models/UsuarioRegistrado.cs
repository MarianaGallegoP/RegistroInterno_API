namespace RegistroInterno_API.Models
{
    public class UsuarioRegistrado
    {
        public int id;
        public string tipoDocumento;
        public string documento;
        public DateTime expedicion;
        public string nombre1;
        public string nombre2;
        public string apellido1;
        public string apellido2;
        public string nombre;
        public string email;
        public string celular;
        public string clave;
        public int intentosFallidos;
        public DateTime ultimoAcceso;
        public int estado;
        public DateTime creacion;
        public DateTime actualizacion;
    }
}
