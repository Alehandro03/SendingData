using Microsoft.AspNetCore.Mvc;

namespace SendingData.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api приписка служит для отличия урлы фронта от бека
    public class MouseController : Controller
    {
        //api/item
        [HttpPost]
        public ActionResult AddCoordinatesЬщгыу(MouseModel mouse)
        {
            if (mouse == null) return BadRequest();

            else return Ok($"{mouse} - was add");
        }
    }
}
