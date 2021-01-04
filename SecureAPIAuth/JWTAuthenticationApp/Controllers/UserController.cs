using JWTAuthenticationApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTAuthenticationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        List<UserModel> users = new List<UserModel>() {
            new UserModel() { UserId = 1, Name = "Arya", EmailAddress = "arya@gmail.com", Password = "Admin123" },
            new UserModel() { UserId = 2, Name = "Chinmay", EmailAddress = "chinmay@gmail.com", Password = "Admin123" } };

        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserCredentialModel model)
        {
            var user = users.
                Where(x => x.EmailAddress.Equals(model.EmailAddress) && x.Password.Equals(model.Password))
                .FirstOrDefault();

            //check user exist
            if (user==null)
                return NotFound();

            //generate token
            var tokenHandler = new JwtSecurityTokenHandler();
            var secretkey = _configuration.GetValue<string>("JWTSettings:SecretKey");
            var key = Encoding.ASCII.GetBytes(secretkey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, user.EmailAddress)
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            //prepare the response
            var tokenResponse = new TokenModel();
            tokenResponse.access_token = tokenHandler.WriteToken(token);
            

            return Ok(tokenResponse);
        }
     
    }

    
}
