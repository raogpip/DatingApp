using DatingAppAPI.Data;
using DatingAppAPI.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingAppAPI.Controllers
{
    public class BuggyController : BaseAPIController
    {
        private readonly DataContext _context;
        public BuggyController(DataContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret()
        {
            return "secret text";
        }

        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound()
        {
            var nonExistingUser = _context.Users.Find(-1);

            // RETURNING NotFound() IF SOMETHING IS NULL 
            // WHEN IT IS
            if (nonExistingUser == null) return NotFound();

            return nonExistingUser;
        }

        [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {
            var nonExistingUser = _context.Users.Find(-1);

            // USING .ToString() ON SOMETHING THAT IS NULL
            var userToReturn = nonExistingUser.ToString();

            return userToReturn;
        }

        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("not good request");
        }
    }
}