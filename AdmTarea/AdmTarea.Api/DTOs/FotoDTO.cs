namespace AdmTarea.Api.DTOs
{
    public class FotoDTO
    {
        public long Id { get; set; }
        public byte[] Imagen { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string FechaCreacion { get; set; }
        public string Descripcion { get; set; }
        public string Etiquetas { get; set; }
        public bool Eliminada { get; set; }
    }
}
