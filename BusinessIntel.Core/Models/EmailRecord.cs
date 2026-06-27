namespace BusinessIntel.Core.Models;

public sealed class EmailRecord
{
    public string Email { get; set; } = string.Empty;

    public bool IsPrimary { get; set; }

    public string Source { get; set; } = string.Empty;
}
