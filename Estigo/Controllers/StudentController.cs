using Microsoft.AspNetCore.Mvc;
using Estigo.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.PowerBI.Api.Models;
using Estigo.DTO;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Generators;


namespace Estigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly EstigoDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly IJwtService _jwtService;

        public StudentController(
            EstigoDbContext context,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            IMapper mapper,
            IJwtService jwtService)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _jwtService = jwtService;
        }


    }   
}
