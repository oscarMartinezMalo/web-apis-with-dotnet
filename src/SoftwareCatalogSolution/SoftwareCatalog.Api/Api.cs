using Microsoft.AspNetCore.Mvc;

namespace SoftwareCatalog.Api;

public class Api : ControllerBase
{

    [HttpPost("/techs")]
    public async Task<ActionResult> AddATechAsync(
        [FromBody] CreateTechRequest request,
        CancellationToken token)
    {
        return Ok();
    }
}

public record CreateTechRequest
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
}