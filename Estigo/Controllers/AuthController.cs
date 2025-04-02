using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly EstigoDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            EstigoDbContext context,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("register/admin")]
        public async Task<IActionResult> RegisterAdmin(AdminRegisterDTO model)
        {
            var user = new Admin
            {
                UserName = model.Email,
                Name = model.Name,
                Email = model.Email,
                Gender = model.Gender,
                Role = Roles.Admin
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, Roles.Admin);
                return Ok(new { message = "Admin registered successfully", role = user.Role });
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("register/student")]
        public async Task<IActionResult> RegisterStudent(StudentRegisterDTO model)
        {
            var user = new Student
            {
                UserName = model.Email,
                Name = model.Name,
                Email = model.Email,
                Role = Roles.Student,
                Gender = model.Gender,
                Track = model.Track,
                Level = model.Level,
                ParentPhone = model.ParentPhone,
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, Roles.Student);
                return Ok(new { message = "Student registered successfully", role = user.Role });
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("register/teacher")]
        public async Task<IActionResult> RegisterTeacher([FromForm] TeacherRegisterDTO model)
        {
            var user = new Teacher
            {
                Name = model.Name,
                Gender = model.Gender,
                UserName = model.Email,
                Email = model.Email,
                Role = Roles.Teacher,
                Subject = model.Subject,
                Notes = model.Notes
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, Roles.Teacher);
                return Ok(new { message = "Teacher registered successfully", role = user.Role });
            }

            return BadRequest(result.Errors);
        }



        [HttpPost("register/parent")]
        public async Task<IActionResult> RegisterParent(ParentRegisterDTO model)
        {
            var user = new Parent
            {
                Name = model.Name,
                Gender = model.Gender,
                UserName = model.Email,
                Email = model.Email,
                Role = Roles.Parent
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, Roles.Parent);
                return Ok(new { message = "Parent registered successfully", role = user.Role });
            }

            return BadRequest(result.Errors);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return Unauthorized(new { message = "Invalid email or password" });

            var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
            if (!result.Succeeded)
                return Unauthorized(new { message = "Invalid email or password" });

            // ✅ توليد التوكن
            var token = await GenerateJwtToken(user);

            // ✅ جلب بيانات المستخدم وإرجاع التوكن
            var userData = new
            {
                user.Id,
                user.Email,
                user.Name,
                user.Role,  // تأكد أن `Role` متاحة في `ApplicationUser`
                Token = token // إرجاع التوكن مع البيانات
            };

            return Ok(userData);
        }

        private async Task<string> GenerateJwtToken(ApplicationUser user)
        {
            var claims = new List<Claim>
    {
        new Claim(JwtRegisteredClaimNames.Sub, user.Id),
        new Claim(JwtRegisteredClaimNames.Email, user.Email),
        new Claim(ClaimTypes.Name, user.UserName)
    };

            var roles = await _userManager.GetRolesAsync(user);
            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Secret"] ?? "default_secret"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(2),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
