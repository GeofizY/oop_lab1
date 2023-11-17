using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mUsic.Controllers

{
   [Route("api/[controller]")]
   [ApiController]
   public class SongsController : ControllerBase
   {
      [HttpGet]
      public object Get()
      {
         return 0;
      }
   }
}