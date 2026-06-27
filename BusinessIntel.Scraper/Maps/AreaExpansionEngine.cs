namespace BusinessIntel.Scraper.Maps;

public static class AreaExpansionEngine
{
    public static List<string> Expand(string keyword)
    {
        return new()
        {
            $"{keyword} anna nagar",
            $"{keyword} adyar",
            $"{keyword} velachery",
            $"{keyword} tambaram",
            $"{keyword} porur",
            $"{keyword} guindy",
            $"{keyword} chromepet",
            $"{keyword} medavakkam",
            $"{keyword} nungambakkam",
            $"{keyword} t nagar",
            $"{keyword} kodambakkam",
            $"{keyword} perungudi",
            $"{keyword} sholinganallur",
            $"{keyword} pallikaranai",
            $"{keyword} omr",
            $"{keyword} ecr",
            $"{keyword} avadi",
            $"{keyword} ambattur",
            $"{keyword} madhavaram",
            $"{keyword} mogappair"
        };
    }
}
