using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using review_jogos_steam.Models;
using review_jogos_steam.Data;

namespace review_jogos_steam.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{

    private ReviewDbContext _dbContext;
    public UsuarioController(ReviewDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    [Route("cadastrar")]
    public async Task<ActionResult> Cadastrar(Usuario user)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Usuario is null) return NotFound();
        await _dbContext.AddAsync(user);
        await _dbContext.SaveChangesAsync();
        return Created("", user);
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<Usuario>>> Listar()
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Usuario is null) return NotFound();
        return await _dbContext.Usuario.ToListAsync();
    }

    [HttpGet]
    [Route("buscar/{idUsuario}")]
    public async Task<ActionResult<Usuario>> Buscar(int idUsuario)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Usuario is null) return NotFound();
        var UsuarioTemp = await _dbContext.Usuario.FindAsync(idUsuario);
        if (UsuarioTemp is null) return NotFound();
        return UsuarioTemp;
    }


    [HttpPut()]
    [Route("alterar")] 
    public async Task<ActionResult> Alterar(Usuario user)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Usuario is null) return NotFound();
        _dbContext.Usuario.Update(user);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }


    [HttpDelete()]
    [Route("excluir/{idUsuario}")]
    public async Task<ActionResult> Excluir(int idUsuario)
    {
        if (_dbContext is null) return NotFound();
        if (_dbContext.Usuario is null) return NotFound();
        var UsuarioTemp = await _dbContext.Usuario.FindAsync(idUsuario);
        if (UsuarioTemp is null) return NotFound();
        _dbContext.Remove(UsuarioTemp);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

}