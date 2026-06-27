using BusinessIntel.Core.Models;

namespace BusinessIntel.Tests;

public static class RepositorySmokeTest
{
    public static Business CreateTestBusiness()
    {
        return new Business
        {
            Name = "Test Company",
            Category = "Restaurant",
            Address = "123 Test Street",
            Phone = "+1 555 123456",
            Website = "https://testcompany.com",
            Rating = 4.8,
            ReviewCount = 150,
            Latitude = 13.0827,
            Longitude = 80.2707
        };
    }
}
