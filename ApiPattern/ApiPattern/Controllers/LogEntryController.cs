using ApiPattern.Core.Entities;
using ApiPattern.Core.Interfaces;
using ApiPattern.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogEntryController : ControllerBase
    {
        private readonly ILogEntryRepository _logEntryRepository;
        private readonly ILogExercise _primeService;

        public LogEntryController(ILogEntryRepository logEntryRepository, ILogExercise primeService)
        {
            _logEntryRepository = logEntryRepository;
            _primeService = primeService;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<int>>> Post([FromBody] InputModel input)
        {
            var primes = _primeService.FindPrimes(input.I, input.N);

            var request = $"i={input.I}, n={input.N}, user={input.User}";
            var response = string.Join(", ", primes);

            await _logEntryRepository.CreateAndAddLogEntry(request, response, input.User);

            return Ok(response);
        }
    }
}
