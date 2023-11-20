// PARTE FEITA PELO GPT

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using review_jogos_steam.Models;
using review_jogos_steam.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace review_jogos_steam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagController : ControllerBase
    {
        private ReviewDbContext _dbContext;

        public TagController(ReviewDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<ActionResult> Cadastrar(Tag tag)
        {
            if (_dbContext is null) return NotFound();
            if (_dbContext.Tag is null) return NotFound();
            
            await _dbContext.AddAsync(tag);
            await _dbContext.SaveChangesAsync();
            
            return Created("", tag);
        }

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<Tag>>> Listar()
        {
            if (_dbContext is null) return NotFound();
            if (_dbContext.Tag is null) return NotFound();
            
            return await _dbContext.Tag.ToListAsync();
        }

        [HttpGet]
        [Route("buscar/{idTag}")]
        public async Task<ActionResult<Tag>> Buscar(int idTag)
        {
            if (_dbContext is null) return NotFound();
            if (_dbContext.Tag is null) return NotFound();
            
            var tagTemp = await _dbContext.Tag.FindAsync(idTag);
            if (tagTemp is null) return NotFound();
            
            return tagTemp;
        }

        [HttpPut()]
        [Route("alterar")]
        public async Task<ActionResult> Alterar(Tag tag)
        {
            if (_dbContext is null) return NotFound();
            if (_dbContext.Tag is null) return NotFound();
            
            _dbContext.Tag.Update(tag);
            await _dbContext.SaveChangesAsync();
            
            return Ok();
        }

        [HttpDelete()]
        [Route("excluir/{idTag}")]
        public async Task<ActionResult> Excluir(int idTag)
        {
            if (_dbContext is null) return NotFound();
            if (_dbContext.Tag is null) return NotFound();
            
            var tagTemp = await _dbContext.Tag.FindAsync(idTag);
            if (tagTemp is null) return NotFound();
            
            _dbContext.Remove(tagTemp);
            await _dbContext.SaveChangesAsync();
            
            return Ok();
        }
    }
}