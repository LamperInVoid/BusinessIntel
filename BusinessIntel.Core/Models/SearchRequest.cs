namespace BusinessIntel.Core.Models;

public sealed class SearchRequest
{
    public string Keyword { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public int MaxResults { get; set; } = 100;
}
