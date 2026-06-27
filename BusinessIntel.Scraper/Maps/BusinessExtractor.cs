using Microsoft.Playwright;

namespace BusinessIntel.Scraper.Maps;

public static class BusinessExtractor
{
    public static async Task<HashSet<string>>
        CollectBusinessUrlsAsync(IPage page)
    {
        var urls = new HashSet<string>();

        var links =
            await page.Locator("a.hfpxzc")
                .AllAsync();

        foreach (var link in links)
        {
            try
            {
                var url =
                    await link.GetAttributeAsync(
                        "href");

                if (!string.IsNullOrWhiteSpace(url))
                    urls.Add(url);
            }
            catch
            {
            }
        }

        return urls;
    }
}
