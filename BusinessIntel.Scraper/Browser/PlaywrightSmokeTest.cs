using Microsoft.Playwright;

namespace BusinessIntel.Scraper.Browser;

public static class PlaywrightSmokeTest
{
    public static async Task RunAsync()
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
            "https://www.google.com");

        await page.ScreenshotAsync(
            new()
            {
                Path = "google-test.png"
            });

        Console.WriteLine(
            "Screenshot saved.");
    }
}
