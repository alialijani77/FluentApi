using Fluent.Data.Repositories;
using Fluent.Domain.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fluent.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserProfileRepository _userProfileRepository;

        public UserController(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }
        [HttpPost("AddUSerProfile")]
		public async Task<IActionResult> AddUSerProfile(UserProfileDto userProfileDto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			await _userProfileRepository.AddUserProfile(userProfileDto);
			return Ok();
		}
	}
}
