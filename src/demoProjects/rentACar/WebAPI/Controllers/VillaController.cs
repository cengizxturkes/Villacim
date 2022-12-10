using Application.Features.Customers.Commands.CreateCustomer;
using Application.Features.Villa.Commands.CreateVilla;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : BaseController
    {
        [HttpPost("add")]
        public async Task<IActionResult> AddAsync([FromBody] CreatedVillaCommand createdVillaCommand)
        {
            var result = await Mediator.Send(createdVillaCommand);
            return Ok(result);

        }
    }
}
