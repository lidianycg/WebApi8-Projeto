using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi8_ProjetoYT.Models;
using WebApi8_ProjetoYT.Services.Autor;

namespace WebApi8_ProjetoYT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {

        private readonly IAutorInterface _autorInterface;
        public AutorController(IAutorInterface autorinterface) 
        { 
            _autorInterface = autorinterface;
        }

        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()
        {
            var autores = await _autorInterface.ListarAutores();
            return Ok(autores);
        }


    }
}
