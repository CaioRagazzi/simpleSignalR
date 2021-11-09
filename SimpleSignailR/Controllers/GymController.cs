using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleSignailR.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleSignailR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GymController : ControllerBase
    {
        private readonly IGymService _gymService;

        public GymController(IGymService gymService)
        {
            _gymService = gymService;
        }

        [HttpPost("adduser")]
        public async Task<IActionResult> AddUser()
        {
            _gymService.AddUser();
            return Ok();
        }

        [HttpPost("removeuser")]
        public async Task<IActionResult> RemoveUser()
        {
            _gymService.RemoveUser();
            return Ok();
        }

        [HttpGet("getusers")]
        public async Task<IActionResult> GetUsers()
        {
            var result = _gymService.GetTotalUsersInGym();
            return Ok(result);
        }
    }
}
