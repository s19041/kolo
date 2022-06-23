using Kolokwium.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamDbRepository _teamDbRepository;
        public TeamsController(ITeamDbRepository teamDbRepository)
        {
            _actionDbRepository = actionDbRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetTeam([FromBody] int id)
        {
            var res = await _teamDbRepository.GetTeamAsync(id);
            if (res == null)
                return NotFound();
            return Ok(res);
        }
        public async Task<IActionResult> AddMemberToTeam([FromBody] int id,int actionId)
        {
            var res = await _teamDbRepository.AddMemberToTeamAsync(id, actionId);
            if (res)
                return NoContent();
            return BadRequest();
        }
    }
}
