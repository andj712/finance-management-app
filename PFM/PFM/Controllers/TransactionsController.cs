using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PFM.Services;

namespace PFM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly TransactionService _transactionService;
        public TransactionsController(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        [HttpGet("message")]
        public IActionResult GetMessage()
        {
            var message = _transactionService.Message();
            return Ok(message);
        }
    }
}
