namespace BusinessIntel.Core.Models;

public sealed class PhoneRecord
{
    public string Number { get; set; } = string.Empty;

    public bool IsPrimary { get; set; }

    public string Source { get; set; } = string.Empty;
}
