using Microsoft.Playwright;

namespace BusinessIntel.Scraper.Maps;

public static class MapsInfiniteScroller
{
    public static async Task<HashSet<string>> CollectBusinessesAsync(
        IPage page)
    {
        var urls = new HashSet<string>();

        var feed =
            page.Locator("[role='feed']");

        await feed.WaitForAsync();

        int stagnantCycles = 0;
        int previousCount = 0;

        while (stagnantCycles < 15)
        {
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
                    {
                        urls.Add(url);
                    }
                }
                catch
                {
                }
            }

            Console.WriteLine(
                $"Collected: {urls.Count}");

            for (int i = 0; i < 15; i++)
            {
                await feed.EvaluateAsync(
                    @"e => e.scrollBy(0, 1200)");

                await page.WaitForTimeoutAsync(
                    750);
            }

            if (urls.Count == previousCount)
            {
                stagnantCycles++;

                Console.WriteLine(
                    $"No growth cycle {stagnantCycles}/15");
            }
            else
            {
                stagnantCycles = 0;
                previousCount = urls.Count;
            }
        }

        return urls;
    }
}
