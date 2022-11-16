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
        List<Skins> lista = BD.GetSkins();
        return Ok(lista);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        if(id < 1)
        {
            return BadRequest();
        }
        Skins x = BD.GetSkinById(id);
        if(x == null)
        {
            return NotFound();
        }
        return Ok(x);
   }

   [HttpPost]
    public IActionResult Post(Skins x)
    {
        if(x.NombreSkin == null || x.NombreSkin == "")
        {
            return BadRequest();
        }
        BD.InsertSkin(x);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if(id < 1)
        {
            return BadRequest();
        }
        Skins x = BD.GetSkinById(id);
        if(x == null)
        {
            return NotFound();
        }
        BD.DeleteSkinById(id);
        return Ok();
   }

   [HttpPut("{id}")]
   public IActionResult Update(int id, Materia cate)
   {
        if(id < 1)
        {
            return BadRequest();
        }
        cate = BD.GetCateById(id);
        if(cate is null)
        {
            return NotFound();
        }
        BD.Update(cate);
        return Ok();
   }
}