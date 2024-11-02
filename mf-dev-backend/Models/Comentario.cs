namespace mf_dev_backend.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string Autor { get; set; }
        public DateTime DataCriacao { get; set; }

        public int UsuarioId { get; set; }
    }
}
