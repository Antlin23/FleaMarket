using FleaMarket.Services;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

public class DailyResetService : BackgroundService
{
    private readonly UserService _userService;

    public DailyResetService(UserService userService)
    {
        _userService = userService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var now = DateTime.Now;
            var tomorrow = now.AddDays(1);
            var nextRunTime = new DateTime(tomorrow.Year, tomorrow.Month, now.Day, 20, 37, 0);
            var delay = nextRunTime - now;
            if (delay > TimeSpan.Zero)
            {
                await Task.Delay(delay, stoppingToken);
            }

            // Logic to reset the boolean property
            await _userService.ResetActiveSellerPropertyAsync();

            // Wait for a day
            await Task.Delay(TimeSpan.FromDays(1), stoppingToken);
        }
    }
}