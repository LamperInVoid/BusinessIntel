namespace BusinessIntel.Core.Models;

public sealed class Business
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Website { get; set; } = string.Empty;

    public double Rating { get; set; }

    public int ReviewCount { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public List<EmailRecord> Emails { get; set; } = [];

    public List<PhoneRecord> Phones { get; set; } = [];

    public List<SocialProfile> SocialProfiles { get; set; } = [];
}
