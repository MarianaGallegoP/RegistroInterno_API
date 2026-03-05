namespace RegistroInterno_API.Models
{
    public class LogAuditorias
    {
        public int idLog;
        public string tipoOperacion;
        public string tipoDocumento;
        public string numeroDocumento;
        public DateTime fecha;
        public string resultado;
        public int codigoError;
        public int idSesionValidacion;
    }
}
