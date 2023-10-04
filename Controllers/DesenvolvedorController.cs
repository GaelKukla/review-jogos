using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using review_jogos_steam.Models;
using review_jogos_steam.Data;

namespace review_jogos_steam.Controllers;

[ApiController]
[Route("[controller]")]
public class DesenvolvedorController : ControllerBase
{
private ReviewDbContext _dbContext;
    public DesenvolvedorController(ReviewDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    [Route("cadastrar")]
    public async Task<ActionResult> Cadastrar(Desenvolvedor dev)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Desenvolvedor is null) return NotFound();
        await _dbContext.AddAsync(dev);
        await _dbContext.SaveChangesAsync();
        return Created("", dev);
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<Desenvolvedor>>> Listar()
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Desenvolvedor is null) return NotFound();
        return await _dbContext.Desenvolvedor.ToListAsync();
    }

    [HttpGet]
    [Route("buscar/{idDesenvolvedor}")]
    public async Task<ActionResult<Desenvolvedor>> Buscar(int idDesenvolvedor)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Desenvolvedor is null) return NotFound();
        var DesenvolvedorTemp = await _dbContext.Desenvolvedor.FindAsync(idDesenvolvedor);
        if (DesenvolvedorTemp is null) return NotFound();
        return DesenvolvedorTemp;
    }


    [HttpPut()]
    [Route("alterar")] 
    public async Task<ActionResult> Alterar(Desenvolvedor dev)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Desenvolvedor is null) return NotFound();
        _dbContext.Desenvolvedor.Update(dev);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }


    [HttpDelete()]
    [Route("excluir/{idDesenvolvedor}")]
    public async Task<ActionResult> Excluir(int idDesenvolvedor)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Desenvolvedor is null) return NotFound();
        var DesenvolvedorTemp = await _dbContext.Desenvolvedor.FindAsync(idDesenvolvedor);
        if (DesenvolvedorTemp is null) return NotFound();
        _dbContext.Remove(DesenvolvedorTemp);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

}