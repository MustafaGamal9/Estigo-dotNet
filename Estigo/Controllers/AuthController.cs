using Estigo.DTO;
using Estigo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.PowerBI.Api.Models;

namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("register/student")]
        public async Task<IActionResult> RegisterStudent(RegisterDTO model)
        {
            var student = new Student
            {
                Name = model.Name,
                Phone = model.Phone,
                Email = model.Email,
                Gender = model.Gender,
                Track = model.Track,
                Level = model.Level,
                ParentPhone = model.ParentPhone,
                BirthDate = model.BirthDate
            };

            var appUser = new AppUser
            {
                EmailAddress = student.Email,
                DisplayName = student.Name
            };

            var result = await _userManager.CreateAsync(appUser, model.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(appUser, "Student");
                return Ok(new { Message = "Student registered successfully" });
            }

            return BadRequest(result.Errors);
        }
    }
}
