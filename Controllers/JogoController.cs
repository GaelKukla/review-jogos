using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using review_jogos_steam.Models;
using review_jogos_steam.Data;

namespace review_jogos_steam.Controllers;

[ApiController]
[Route("[controller]")]
public class JogoController : ControllerBase
{
    private ReviewDbContext _dbContext;
    public JogoController(ReviewDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    [Route("cadastrar")]
    public async Task<ActionResult> Cadastrar(Jogo jog)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Jogo is null) return NotFound();
        await _dbContext.AddAsync(jog);
        await _dbContext.SaveChangesAsync();
        return Created("", jog);
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<Jogo>>> Listar()
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Jogo is null) return NotFound();
        return await _dbContext.Jogo.ToListAsync();
    }

    [HttpGet]
    [Route("buscar/{id}")]
    public async Task<ActionResult<Jogo>> Buscar(int id)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Jogo is null) return NotFound();
        var JogoTemp = await _dbContext.Jogo.FindAsync(id);
        if (JogoTemp is null) return NotFound();
        return JogoTemp;
    }


    [HttpPut()]
    [Route("alterar")] 
    public async Task<ActionResult> Alterar(Jogo ava)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Jogo is null) return NotFound();
        _dbContext.Jogo.Update(ava);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }


    [HttpDelete()]
    [Route("excluir/{id}")]
    public async Task<ActionResult> Excluir(int id)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Jogo is null) return NotFound();
        var JogoTemp = await _dbContext.Jogo.FindAsync(id);
        if (JogoTemp is null) return NotFound();
        _dbContext.Remove(JogoTemp);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }



}
