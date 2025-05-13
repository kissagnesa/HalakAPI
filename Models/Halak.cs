using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HalakAPI.Models;

public partial class Halak
{
    public int Id { get; set; }

    public string? Nev { get; set; }

    public string? Faj { get; set; }

    public decimal? MeretCm { get; set; }

    public int? ToId { get; set; }

    public byte[]? Kep { get; set; }

    [JsonIgnore]

    public virtual ICollection<Fogasok> ? Fogasoks { get; set; } = new List<Fogasok>();

    public virtual Tavak? To { get; set; }
}
