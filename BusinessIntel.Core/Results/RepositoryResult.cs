namespace BusinessIntel.Core.Results;

public sealed class RepositoryResult
{
    public bool Success { get; set; }

    public string Message { get; set; } = string.Empty;

    public static RepositoryResult Ok(string message = "")
        => new()
        {
            Success = true,
            Message = message
        };

    public static RepositoryResult Fail(string message)
        => new()
        {
            Success = false,
            Message = message
        };
}
