namespace WebApi8_ProjetoYT.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Titulo{ get; set; }
        public AutorModel Autor {  get; set; } //Um livro terá somente um autor.
    }
}
