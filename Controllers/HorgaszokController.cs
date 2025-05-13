using HalakAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HalakAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HorgaszokController : ControllerBase
    {
        [HttpGet("All")]

        public IActionResult GetAll()
        {
            try
            {
                using (var context = new HalakContext())
                {
                    var response = context.Horgaszoks.ToList();
                    return Ok(response);
                }
            }
            catch (Exception)
            {
                return StatusCode(400);
            }
        }

        [HttpGet("ById/{id}")]

        public IActionResult GetById(int id)
        {
            try
            {
                using (var context = new HalakContext())
                {
                    var response = context.Horgaszoks.FirstOrDefault(x => x.Id == id);
                    if (response == null)
                    {
                        return NotFound("Nincs ilyen azonosítójú horgász!");
                    }
                    else
                    {
                        return Ok(response);
                    }                    
                }
            }
            catch (Exception)
            {
                return StatusCode(400);
            }
        }
    }
}
