using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Vera.CMS.Infrastructure.Database.Entity;
using Vera.CMS.UI.API.Authenticate.Models;

namespace Vera.CMS.UI.API.Authenticate
{
    public class LoginController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;  
        
        public LoginController(UserManager<User> userManager, IConfiguration configuration)  
        {  
            _userManager = userManager;  
            _configuration = configuration;  
        }  
        
        [HttpPost]
        [Route("api/login")]
        [Produces("application/json")]
        public async Task<IActionResult> Login([FromBody] Login model)
        {
            if (model == null || ModelState.IsValid == false)
            {
                return BadRequest("Model is not valid. Check data keys (username, password)");
            }
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null || !await _userManager.CheckPasswordAsync(user, model.Password))
            {
                return NotFound("User not found");
            }

            var authClaims = new List<Claim>
            {
                new(ClaimTypes.Name, user.UserName),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                expiration = token.ValidTo
            });

        }
    }
}