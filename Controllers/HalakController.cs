using HalakAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HalakAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HalakController : ControllerBase
    {
        [HttpGet("FajMeretTo")]
        public IActionResult GetFajMeretTo()
        {
            try
            {
               using(var cx=new HalakContext())
                {
                    var response = cx.Halaks
                        .Select(x => new
                        {
                            x.Faj,
                            x.MeretCm,
                            x.To.Nev
                        })
                        .ToList();
                    return Ok(response);
                }

                /* VAAGY
                 var response = cx.Halaks.Include(x => x.To).Select(f=>new FajMeretTo{Faj=f.Faj,
                     MeretCm=f.MeretCm,
                     ToNev=f.To.Nev
                 }).ToList();
                    return Ok(response);                     
                 */
            }
            catch (Exception)
            {
                return StatusCode(400);
            }
        }
    }
}
