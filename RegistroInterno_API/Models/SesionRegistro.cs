namespace RegistroInterno_API.Models
{
    public class SesionRegistro
    {
        public int idSesion;
        public int idUsuario;
        public string metodoVerificacion;
        public int sesionValidacionInterna;
        public string estado;
        public DateTime expiracion;
        public int contadorIntentos;
    }
}
