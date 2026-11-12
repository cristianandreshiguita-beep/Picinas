namespace Lib_CHpicina.entidades
{
    public class persona
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public double precio { get; set; }
        public bool Activo { get; set; }
        public string? Observaciones { get; set; }
    }
}