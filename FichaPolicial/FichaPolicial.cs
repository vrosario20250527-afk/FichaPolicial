namespace ApiFichasPublicas
{
    public enum NivelPeligrosidad
    {
        Baja,
        Media,
        Alta
    }

    public class FichaPolicial
    {
        public int Id { get; set; }
        public string NumeroExpediente { get; set; } = string.Empty;
        public string NombreCompleto { get; set; } = string.Empty;
        public string DocumentoIdentidad { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string DelitoImputado { get; set; } = string.Empty;
        public NivelPeligrosidad Peligrosidad { get; set; } = NivelPeligrosidad.Media;
        public string Estado { get; set; } = "Detenido";
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}