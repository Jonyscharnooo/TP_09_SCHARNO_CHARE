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
   public IActionResult Update(int id, Skins skn)
   {
        if(id < 1)
        {
            return BadRequest();
        }
        Skins sknss= BD.GetSkinById(id);
        if(sknss == null)
        {
            return NotFound();
        }
        BD.UpdateSkin(id, skn);
        return Ok();
   }

   [HttpPatch("(id)")]
    public IActionResult Patch(int id, Skins nueva)
    {
        if(id < 1)
        {
            return BadRequest();
        }
        Skins vieja = BD.GetSkinById(id);
        if(nueva.NombreSkin != null && nueva.NombreSkin != vieja.NombreSkin)
        {
            vieja.NombreSkin = nueva.NombreSkin;
        }
        if(nueva.FotoSkin != null && nueva.FotoSkin != vieja.FotoSkin)
        {
            vieja.FotoSkin = nueva.FotoSkin;
        }
        if(nueva.IdMateria != null && nueva.IdMateria != vieja.IdMateria)
        {
            vieja.IdMateria = nueva.IdMateria;
        }
        if(nueva.AntiguedadSkin != null && nueva.AntiguedadSkin != vieja.AntiguedadSkin)
        {
            vieja.AntiguedadSkin = nueva.AntiguedadSkin;
        }
        BD.UpdateSkin(id, vieja);
        return Ok();
    }
}