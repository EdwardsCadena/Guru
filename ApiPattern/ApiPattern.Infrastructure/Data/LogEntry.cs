using System;
using System.Collections.Generic;

namespace ApiPattern.Infrastructure.Data;

public partial class LogEntry
{
    public int Id { get; set; }

    public string Request { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public string Response { get; set; } = null!;

    public DateTime ResponseDate { get; set; }

    public string User { get; set; } = null!;
}
