using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WalkingSkeletonApi.DTOs;
using WalkingSkeletonApi.Services;

namespace WalkingSkeletonApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

       
        [HttpGet("get-users")]
        public IActionResult GetUsers()
        {
            // map data from db to dto to reshape it and remove null fields
            var listOfUsersToReturn = new List<UserToReturnDto>();
            var users = _userService.Users;
            if(users != null)
            {
                foreach(var user in users)
                {
                    listOfUsersToReturn.Add(new UserToReturnDto {
                        Id = user.Id,
                        LastName = user.LastName,
                        FirstName = user.FirstName,
                        Email = user.Email
                    });
                }
                return Ok(listOfUsersToReturn);
            }
            else
            {
                return NotFound("No results found!");
            }

        }
    }
}
