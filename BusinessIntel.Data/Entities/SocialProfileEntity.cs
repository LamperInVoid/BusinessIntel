namespace BusinessIntel.Data.Entities;

public sealed class SocialProfileEntity
{
    public Guid Id { get; set; }

    public string Platform { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;

    public string Username { get; set; } = string.Empty;

    public Guid BusinessEntityId { get; set; }

    public BusinessEntity? Business { get; set; }
}
