using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using review_jogos_steam.Models;
using review_jogos_steam.Data;

namespace review_jogos_steam.Controllers;

[ApiController]
[Route("[controller]")]
public class AvaliacaoController : ControllerBase
{
    private ReviewDbContext _dbContext;
    public AvaliacaoController(ReviewDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    [Route("cadastrar")]
    public async Task<ActionResult> Cadastrar(Avaliacao ava)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Avaliacao is null) return NotFound();
        await _dbContext.AddAsync(ava);
        await _dbContext.SaveChangesAsync();
        return Created("", ava);
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<Avaliacao>>> Listar()
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Avaliacao is null) return NotFound();
        return await _dbContext.Avaliacao.ToListAsync();
    }

    [HttpGet]
    [Route("buscar/{idAvaliacao}")]
    public async Task<ActionResult<Avaliacao>> Buscar(int idAvaliacao)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Avaliacao is null) return NotFound();
        var AvaliacaoTemp = await _dbContext.Avaliacao.FindAsync(idAvaliacao);
        if (AvaliacaoTemp is null) return NotFound();
        return AvaliacaoTemp;
    }


    [HttpPut()]
    [Route("alterar")] 
    public async Task<ActionResult> Alterar(Avaliacao ava)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Avaliacao is null) return NotFound();
        _dbContext.Avaliacao.Update(ava);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }


    [HttpDelete()]
    [Route("excluir/{idAvaliacao}")]
    public async Task<ActionResult> Excluir(int idAvaliacao)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Avaliacao is null) return NotFound();
        var AvaliacaoTemp = await _dbContext.Avaliacao.FindAsync(idAvaliacao);
        if (AvaliacaoTemp is null) return NotFound();
        _dbContext.Remove(AvaliacaoTemp);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }



}
