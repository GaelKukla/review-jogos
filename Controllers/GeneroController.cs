using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using review_jogos_steam.Models;
using review_jogos_steam.Data;

namespace review_jogos_steam.Controllers;

[ApiController]
[Route("[controler]")]

public class GeneroController : ControllerBase
{
    private ReviewDbContext _dbContext;
    
    public GeneroController(ReviewDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost()]
    [Route("Cadastrar")]
    public async Task<ActionResult> Cadastrar(Genero genero)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Genero is null) return NotFound();
        await _dbContext.AddAsync(genero);
        await _dbContext.SaveChangesAsync();
        return Created("",genero);
    }
    
    [HttpGet()]
    [Route("Listar")]
    public async Task<ActionResult<IEnumerable<Genero>>> Listar()
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Genero is null) return NotFound();
        return await _dbContext.Genero.ToListAsync();
    }

    [HttpGet()]
    [Route("Buscar{tipo}")]
    public async Task<ActionResult<Genero>> Buscar(string tipo)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Genero is null) return NotFound();
        var gentemp = await _dbContext.Genero.FindAsync(tipo);
        if(gentemp is null) return NotFound();
        return gentemp;
    }

    [HttpPut()]
    [Route("Alterar")]
    public async Task<ActionResult> Alterar(Genero genero)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Genero is null) return NotFound();
        var gentemp = await _dbContext.Genero.FindAsync(genero.Tipo);
        if(gentemp is null) return NotFound();
        _dbContext.Genero.Update(genero);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete()]
    [Route("Excluir{tipo}")]
    public async Task<ActionResult> Excluir(string tipo)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Genero is null) return NotFound();
        var gentemp = await _dbContext.Genero.FindAsync(tipo);
        if(gentemp is null) return NotFound();
        _dbContext.Genero.Remove(gentemp);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }
}