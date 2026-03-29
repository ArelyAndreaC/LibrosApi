namespace LibrosApi.Models
{
    public class Libros
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Categoria { get; set; }
        public string? Subcategoria { get; set; }
        public string? Descripcion { get; set; }
        public string? Enlace { get; set; }
        public bool Activo { get; set; } = true;
    }
}
