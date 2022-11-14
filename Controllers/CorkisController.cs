using Microsoft.AspNetCore.Mvc;
using API_CHARE_SCHARNO.Models;
namespace API_CHARE_SCHARNO.Controllers;

[ApiController]
[Route("[controller]")]
public class CorkisController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<Docente> lista = BD.GetDocentes();
        return Ok(lista);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        if(id < 1)
        {
            return BadRequest();
        }
        Docente x = BD.GetDocenteById(id);
        if(x == null)
        {
            return NotFound();
        }
        return Ok(x);
   }

   [HttpPost]
    public IActionResult Post(Docente x)
    {
        if(x.NombreDocente == null || x.NombreDocente == "")
        {
            return BadRequest();
        }
        BD.InsertDocente(x);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id){
        if(id < 1)
        {
            return BadRequest();
        }
    Docente x = BD.GetDocenteById(id);
        if(x == null)
        {
            return NotFound();
        }
    BD.DeleteDocenteById(id);
    return Ok();
   }
}