using WebApi8_ProjetoYT.Dto.Vinculo;
using WebApi8_ProjetoYT.Models;

namespace WebApi8_ProjetoYT.Dto.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
