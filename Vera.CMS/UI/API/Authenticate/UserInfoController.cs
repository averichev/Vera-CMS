using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vera.CMS.Infrastructure.Database.Entity;
using Vera.CMS.UI.API.Authenticate.Models;

namespace Vera.CMS.UI.API.Authenticate
{
    public class UserInfoController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;

        public UserInfoController(IHttpContextAccessor httpContextAccessor, UserManager<User> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        [Route("api/user")]
        public async Task<IActionResult> UserInfo()
        {
            if (_httpContextAccessor.HttpContext == null)
            {
                return NotFound("HttpContext is null");
            }

            var context = _httpContextAccessor.HttpContext;
            var identity = context.User.Identity;
            if (identity == null)
            {
                return NotFound("Identity is null");
            }
            if (identity.IsAuthenticated == false)
            {
                return Unauthorized();
            }

            if (identity.Name == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByNameAsync(identity.Name);
            
            return Ok(new UserInfo(user.Id, user.UserName));
        }
    }
}