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
                    var horgaszok = context.Horgaszoks.ToList();
                    return Ok(horgaszok);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
