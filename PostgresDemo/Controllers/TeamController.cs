using Microsoft.AspNetCore.Mvc;
using PostgresDemo.Repositories;

namespace PostgresDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TeamController : ControllerBase
{
    private readonly ITeamRepository _teamRepository;
    public TeamController(ITeamRepository teamRepository)
    {
        _teamRepository = teamRepository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_teamRepository.GetAllTeams());
    }
    
}
