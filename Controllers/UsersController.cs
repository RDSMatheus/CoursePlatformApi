using CoursePlatform.Context;
using CoursePlatform.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoursePlatform.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext? _context;
        public UsersController(AppDbContext? context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var users = _context.Users.ToList();
            if (users is null)
            {
                return NotFound("Usuários não encontrados.");
            }
            return users;
        }
    }
}
