using BusinessIntel.Scraper.Maps;

Console.Write("Business Type: ");
var businessType = Console.ReadLine() ?? "";

var allUrls = new HashSet<string>();

var searches =
    AreaExpansionEngine.Expand(
        businessType);

foreach (var search in searches)
{
    Console.WriteLine();
    Console.WriteLine(
        $"Searching: {search}");

    var urls =
        await MapsSearchEngine
            .SearchAndCaptureAsync(
                search);

    foreach (var url in urls)
        allUrls.Add(url);

    Console.WriteLine(
        $"Total unique so far: {allUrls.Count}");
}

File.WriteAllLines(
    "business_urls.txt",
    allUrls);

Console.WriteLine();
Console.WriteLine(
    $"TOTAL UNIQUE BUSINESSES: {allUrls.Count}");

Console.WriteLine(
    "Saved business_urls.txt");
