// Feito plo GPT

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using review_jogos_steam.Models;
using review_jogos_steam.Data;

namespace review_jogos_steam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagemController : ControllerBase
    {
        private readonly ReviewDbContext _dbContext;

        public ImagemController(ReviewDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<ActionResult> Cadastrar(Imagem imagem)
        {
            if (_dbContext is null)
                return NotFound();

            await _dbContext.Imagem.AddAsync(imagem);
            await _dbContext.SaveChangesAsync();
            return Created("", imagem);
        }

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<Imagem>>> Listar()
        {
            if (_dbContext is null)
                return NotFound();

            return await _dbContext.Imagem.ToListAsync();
        }

        [HttpGet]
        [Route("buscar/{idImagem}")]
        public async Task<ActionResult<Imagem>> Buscar(int idImagem)
        {
            if (_dbContext is null)
                return NotFound();

            var imagem = await _dbContext.Imagem.FindAsync(idImagem);

            if (imagem is null)
                return NotFound();

            return imagem;
        }

        [HttpPut()]
        [Route("alterar")]
        public async Task<ActionResult> Alterar(Imagem imagem)
        {
            if (_dbContext is null)
                return NotFound();

            _dbContext.Imagem.Update(imagem);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete()]
        [Route("excluir/{idImagem}")]
        public async Task<ActionResult> Excluir(int idImagem)
        {
            if (_dbContext is null)
                return NotFound();

            var imagem = await _dbContext.Imagem.FindAsync(idImagem);

            if (imagem is null)
                return NotFound();

            _dbContext.Remove(imagem);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
