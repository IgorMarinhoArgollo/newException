using Microsoft.AspNetCore.Mvc;
using Tryitter.Domain.Services;
using Tryitter.Domain.DTOs;

namespace Tryitter.Web.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{

  private readonly ILogger<UserController> _logger;
  private readonly IUserService _service;

  public UserController(ILogger<UserController> logger, IUserService service)
  {
    _logger = logger;
    _service = service;
  }

  [HttpGet]
  public async Task<ActionResult> GetAll()
  {
    return Ok(await _service.GetAll());
  }

  [HttpGet("{id}")]
  public async Task<ActionResult> GetById(int id)
  {
    var result = await _service.GetById(id);

    if (result != null)
    {
      return Ok(result);
    }

    return NotFound("User not found");
  }

  [HttpPost]
  public async Task<ActionResult> Create(UserRequest request)
  {
    var result = await _service.Create(request);
    return CreatedAtAction("GetById", new{ id = result.Id}, result );
  }

  [HttpPut("{id}")]
  public async Task<ActionResult> Update(int id, UserRequest request)
  {
    var userFound = await _service.GetById(id);
    if(userFound == null) return NotFound("User not found");
    var result = await _service.Update(id, request);
    return Ok(result);
  }

  [HttpDelete("{id}")]
  public async Task<ActionResult> Delete(int id)
  {
    bool _post = await _service.Delete(id);

    if (_post == true)
    {
      return NoContent();
    }
    return NotFound("User not found");
  }
}