using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using review_jogos_steam.Models;
using review_jogos_steam.Data;

namespace review_jogos_steam.Controllers;

[ApiController]
[Route("[controller]")]
public class ComentarioController : ControllerBase
{
    private ReviewDbContext _dbContext;
    public ComentarioController(ReviewDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    [Route("cadastrar")]
    public async Task<ActionResult> Cadastrar(Comentario comentario)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Comentario is null) return NotFound();
        await _dbContext.AddAsync(comentario);
        await _dbContext.SaveChangesAsync();
        return Created("", comentario);
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<Comentario>>> Listar()
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Comentario is null) return NotFound();
        return await _dbContext.Comentario.ToListAsync();
    }

    [HttpGet]
    [Route("buscar/{idComentario}")]
    public async Task<ActionResult<Comentario>> Buscar(int idComentario)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Comentario is null) return NotFound();
        var ComentarioTemp = await _dbContext.Comentario.FindAsync(idComentario);
        if (ComentarioTemp is null) return NotFound();
        return ComentarioTemp;
    }


    [HttpPut()]
    [Route("alterar")] 
    public async Task<ActionResult> Alterar(Comentario comentario)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Comentario is null) return NotFound();
        _dbContext.Comentario.Update(comentario);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }


    [HttpDelete()]
    [Route("excluir/{idComentario}")]
    public async Task<ActionResult> Excluir(int idComentario)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Comentario is null) return NotFound();
        var ComentarioTemp = await _dbContext.Comentario.FindAsync(idComentario);
        if (ComentarioTemp is null) return NotFound();
        _dbContext.Remove(ComentarioTemp);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }



}
