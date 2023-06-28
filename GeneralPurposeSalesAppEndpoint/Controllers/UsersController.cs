using GeneralPurposeSalesAppEndpoint.Models;
using GeneralPurposeSalesAppEndpoint.Types;
using Microsoft.AspNetCore.Mvc;

namespace GeneralPurposeSalesAppEndpoint.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDBContext db;
        public UsersController(AppDBContext context)
        {
            db = context;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> Login(LoginCredentials credentials)
        {
            return Ok();
        }
    }
}
