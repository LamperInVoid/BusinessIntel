namespace BusinessIntel.Data.Entities;

public sealed class BusinessEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Website { get; set; } = string.Empty;

    public double Rating { get; set; }

    public int ReviewCount { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public ICollection<EmailEntity> Emails { get; set; } = [];

    public ICollection<PhoneEntity> Phones { get; set; } = [];

    public ICollection<SocialProfileEntity> SocialProfiles { get; set; } = [];
}
