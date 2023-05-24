using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppContext = DatingApp.API.Data.AppContext;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        
    }
}
