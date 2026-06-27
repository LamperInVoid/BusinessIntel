namespace BusinessIntel.Data.Entities;

public sealed class EmailEntity
{
    public Guid Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public bool IsPrimary { get; set; }

    public string Source { get; set; } = string.Empty;

    public Guid BusinessEntityId { get; set; }

    public BusinessEntity? Business { get; set; }
}
