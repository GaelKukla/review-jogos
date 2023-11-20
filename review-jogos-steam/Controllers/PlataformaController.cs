using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using review_jogos_steam.Models;
using review_jogos_steam.Data;

namespace review_jogos_steam.Controllers;

[ApiController]
[Route("[controller]")]
public class PlataformaController : ControllerBase
{
    private ReviewDbContext _dbContext;
    public PlataformaController(ReviewDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    [Route("cadastrar")]
    public async Task<ActionResult> Cadastrar(Plataforma plat)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Plataforma is null) return NotFound();
        await _dbContext.AddAsync(plat);
        await _dbContext.SaveChangesAsync();
        return Created("", plat);
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<Plataforma>>> Listar()
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Plataforma is null) return NotFound();
        return await _dbContext.Plataforma.ToListAsync();
    }

    [HttpGet]
    [Route("buscar/{idPlataforma}")]
    public async Task<ActionResult<Plataforma>> Buscar(int idPlataforma)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Plataforma is null) return NotFound();
        var plataformaTemp = await _dbContext.Plataforma.FindAsync(idPlataforma);
        if (plataformaTemp is null) return NotFound();
        return plataformaTemp;
    }


    [HttpPut()]
    [Route("alterar")] 
    public async Task<ActionResult> Alterar(Plataforma plat)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Plataforma is null) return NotFound();
        _dbContext.Plataforma.Update(plat);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }


    [HttpDelete()]
    [Route("excluir/{idPlataforma}")]
    public async Task<ActionResult> Excluir(int idPlataforma)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Plataforma is null) return NotFound();
        var plataformaTemp = await _dbContext.Plataforma.FindAsync(idPlataforma);
        if (plataformaTemp is null) return NotFound();
        _dbContext.Remove(plataformaTemp);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }



}
