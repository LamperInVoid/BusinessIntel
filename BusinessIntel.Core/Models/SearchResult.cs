namespace BusinessIntel.Core.Models;

public sealed class SearchResult
{
    public bool Success { get; set; }

    public string Message { get; set; } = string.Empty;

    public List<Business> Businesses { get; set; } = [];
}
