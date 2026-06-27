using Microsoft.Playwright;

namespace BusinessIntel.Scraper.Maps;

public static class MapsSearchEngine
{
    public static async Task<HashSet<string>>
        SearchAndCaptureAsync(string query)
    {
        using var playwright =
            await Playwright.CreateAsync();

        await using var browser =
            await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = false
                });

        var page =
            await browser.NewPageAsync();

        await page.GotoAsync(
            $"https://www.google.com/maps/search/{Uri.EscapeDataString(query)}",
            new()
            {
                WaitUntil = WaitUntilState.DOMContentLoaded,
                Timeout = 60000
            });

        await page.WaitForTimeoutAsync(8000);

        var urls =
            await MapsInfiniteScroller
                .CollectBusinessesAsync(page);

        return urls;
    }
}
