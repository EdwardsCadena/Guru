using ApiPattern.Core.Entities;
using ApiPattern.Core.Interfaces;
using ApiPattern.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPattern.Infrastructure.Repositories
{

    // PATRÓN: Repositorio - Esta es la implementación del Repositorio, que proporciona una manera de interactuar con la base de datos.
    public class LogEntryRepository : ILogEntryRepository
    {
        private readonly PruebaContext _context;

        public LogEntryRepository(PruebaContext context)
        {
            _context = context;
        }

        public async Task AddLogEntry(LogEntry logEntry)
        {
            _context.LogEntries.Add(logEntry);
            await _context.SaveChangesAsync();
        }
        public async Task CreateAndAddLogEntry(string request, string response, string user)
        {
            var logEntry = new LogEntry
            {
                Request = request,
                RequestDate = DateTime.UtcNow,
                Response = response,
                ResponseDate = DateTime.UtcNow,
                User = user
            };

            await AddLogEntry(logEntry);
        }
    }
}
