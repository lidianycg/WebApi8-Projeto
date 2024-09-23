using System.Text.Json.Serialization;

namespace WebApi8_ProjetoYT.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [JsonIgnore] //Não preciso preencher todos os livros do autor, quando adiciono o autor.
        public ICollection<LivroModel> Livros { get; set; } //Um autor poderá ter uma coleção de livros.
    }
}
