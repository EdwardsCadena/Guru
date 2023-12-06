using ApiPattern.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPattern.Core.Interfaces
{
    // PATRÓN: Repositorio - Esta es la interfaz del Repositorio, que declara las operaciones que se pueden realizar en las entidade.
    public interface ILogEntryRepository
    {
        Task AddLogEntry(LogEntry logEntry);
        Task CreateAndAddLogEntry(string request, string response, string user);
    }
}
