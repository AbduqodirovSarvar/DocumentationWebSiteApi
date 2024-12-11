using DocumentationWebSiteApi.Database.Entities;
using DocumentationWebSiteApi.Requests.Auth;
using DocumentationWebSiteApi.Services.Abstractions.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DocumentationWebSiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IHashService _hashService;
        private readonly IAppDbContext _context;
        public AccountController(ITokenService tokenService, 
                                 IHashService hashService, 
                                 IAppDbContext context)
        {
            _tokenService = tokenService;
            _hashService = hashService;
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginRequest request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.Login 
                                                             || x.Username == request.Login);
           
            if (user == null)
            {
                throw new Exception("User Not Found");
            }
            else if (!_hashService.VerifyHash(request.Password,user.PasswordHash))
            {
                throw new Exception("Email is wrong");
            }

            return Ok(_tokenService.GetToken(user));
        }

        //[Authorize("Admin")]
        [HttpPost("create")]
        public async Task<ActionResult> CreateUser(CreateUserRequest request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.Email 
                                                             && x.Username == request.Username);

            if (user != null)
            {
                throw new Exception("Allredy exsist");
            }

            var hasPassword = _hashService.GetHash(request.Password);
           
            var newUser = new User
            {
                Role = request.Role,
                Email = request.Email,
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                PasswordHash = hasPassword,
                Username = request.Username
            };
            
            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();

            return Ok(newUser);
        }
    }
}
