using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PFM.Application.UseCases.Queries.GetMessage; 


namespace PFM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TransactionsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("message")]
        public IActionResult GetMessage()
        {
            var message = _mediator.Send(new GetMessageQuery());
            return Ok(message);
        }
    }
}
