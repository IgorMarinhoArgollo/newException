using Microsoft.AspNetCore.Mvc;
using Tryitter.Domain.Services;
using Tryitter.Domain.DTOs;

namespace Tryitter.Web.Controllers;

[ApiController]
[Route("post")]
public class PostController : ControllerBase
{

  private readonly ILogger<PostController> _logger;
  private readonly IPostService _service;

  public PostController(ILogger<PostController> logger, IPostService service)
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

    return NotFound("Post not found");
  }

  [HttpPost]
  public async Task<ActionResult> Create([FromBody] PostRequest request)
  {
    var result = await _service.Create(request);
    return CreatedAtAction("GetById", new{ id = result.Id}, result );
  }
  [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, [FromBody] PostRequest request)
  {
    var postFound = await _service.GetById(id);
    if(postFound == null) return NotFound("Post not found");
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
    return NotFound("Post not found");
  }
}
