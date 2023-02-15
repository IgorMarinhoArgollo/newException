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
  public ActionResult GetAll()
  {
    throw NotImplementedException();
  }

  [HttpGet("{id}")]
  public ActionResult GetById(int id)
  {
    throw NotImplementedException();

  }

  [HttpPost]
  public ActionResult Create(UserRequest request)
  {
    throw NotImplementedException();
  }

  [HttpPut("{id}")]
  public ActionResult Update(int id, UserRequest request)
  {
    throw NotImplementedException();
  }

  [HttpDelete("{id}")]
  public ActionResult Delete(int id)
  {
    throw NotImplementedException();
  }
}