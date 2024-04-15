using Microsoft.AspNetCore.Mvc;
using RSingletonPattern.API.Arguments;
using RSingletonPattern.API.Interfaces.Services;

namespace RSingletonPattern.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class RController(IRService rService) : ControllerBase
{
    [HttpPost("sum-numbers")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public int SumTwoNumbers([FromBody] SumTwoNumbers sum) =>
        rService.SumTwoNumbers(sum);
}
