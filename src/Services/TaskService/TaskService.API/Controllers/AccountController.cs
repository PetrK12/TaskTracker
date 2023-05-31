using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskService.Infrastructure.Model;

namespace TaskService.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly UserManager<ApplicationUser> _userManager;
		//private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly ILogger<AccountController> _logger;
		private readonly IMapper _mapper;
		
		public AccountController(UserManager<ApplicationUser> userManager, ILogger<AccountController> logger, IMapper mapper)
		{
			_userManager = userManager;
			_logger = logger;
			_mapper = mapper;
		}

		[HttpPost]
		[Route("register")]
		public async Task<IActionResult> Register([FromBody] UserDto userDto)
		{
			_logger.LogInformation($"Registration attempt came from {userDto.Email}");
			if(!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			try
			{
                var user = _mapper.Map<ApplicationUser>(userDto);
				user.UserName = user.Email;
				var result = await _userManager.CreateAsync(user, userDto.Password);

				if (!result.Succeeded)
				{
					foreach(var error in result.Errors)
					{
						ModelState.AddModelError(error.Code, error.Description);
					}

                    return BadRequest(ModelState);
                }
				return Ok(result);
            }
			catch (Exception ex)
			{
				_logger.LogError($"Exception: {ex.Message}");
				return Problem(ex.Message, statusCode: 500);
            }
		}

		/*
        [HttpPost]
		[Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDto userDto)
        {
            _logger.LogInformation($"Login attempt came from {userDto.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
				var result = await _signInManager.PasswordSignInAsync(userDto.Email, userDto.Password, false, false);
                if (!result.Succeeded)
                    return BadRequest("Login failed");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception: {ex.Message}");
                return Problem(ex.Message, statusCode: 500);
            }
        }
		*/

    }
}

