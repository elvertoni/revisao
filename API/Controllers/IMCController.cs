using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/imc")]

public class IMCController : ControllerBase
{
    private readonly AppDataContext _context;
    public IMCController(AppDataContext context)
    {
        _context = context;
    }

    // POST: api/imc/cadastrar
    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] IMC imc)
    {
        try
        {
            _context.Add(imc);
            _context.SaveChanges();
            return Created("", imc);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    //GET: api/imc/listar
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try
        {
            List<IMC> imcs = _context.IMCs.ToList();
            return Ok(imcs);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


}
