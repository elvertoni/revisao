using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/usuario")]

public class UsuarioController : ControllerBase
{
    private readonly AppDataContext _context;
    public UsuarioController(AppDataContext context)
    {
        _context = context;
    }

    // POST: api/usuario/cadastrar
    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Usuario usuario)
    {
        try
        {
            _context.Add(usuario);
            _context.SaveChanges();
            return Created("", usuario);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    //GET: api/usuario/listar
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try
        {
            List<Usuario> usuarios = _context.Usuarios.ToList();
            return Ok(usuarios);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


}
