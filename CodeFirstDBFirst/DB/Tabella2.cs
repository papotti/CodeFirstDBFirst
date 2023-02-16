using System;
using System.Collections.Generic;

namespace CodeFirstDBFirst.DB;

public partial class Tabella2
{
    public string Pk { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string? DescrizioneAggiuntiva { get; set; }
}
