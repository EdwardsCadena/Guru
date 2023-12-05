using Api.Data;
using Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class algorithmController : ControllerBase
    {

        private readonly PruebaContext _context;

        public algorithmController(PruebaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<int>>> Get(int i, int n, string user)
        {
            var requestDate = DateTime.UtcNow;

            var primes = FindPrimes(i, n);

            var responseDate = DateTime.UtcNow;

            var logEntry = new LogEntry
            {
                Request = $"i={i}, n={n}, user={user}",
                RequestDate = requestDate,
                Response = string.Join(", ", primes),
                ResponseDate = responseDate,
                User = user
            };

            _context.LogEntries.Add(logEntry);
            await _context.SaveChangesAsync();

            return Ok(primes);
        }

        private static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        private static List<int> FindPrimes(int i, int n)
        {
            List<int> primes = new List<int>();
            while (primes.Count < n)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
                i++;
            }
            return primes;


        }
    }
}
