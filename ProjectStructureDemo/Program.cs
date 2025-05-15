using Serilog;
using ProjectStructureDemo.Models;
using ProjectStructureDemo.Services;
using ProjectStructureDemo.Utils;

var logger = LoggerHelper.CreateLogger();



try
{
    logger.Information("Starting application");

    var userService = new UserService();

    userService.AddUser(new User { Id = 1, Name = "John Doe" });

    if (userService.GetUser(1) is { } user)
    {
        Console.WriteLine($"Found: {user}");
        logger.Information("Found user: {User}", user);
    }
}
catch (Exception ex)
{
    logger.Error(ex, "Application error occurred");
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Log.CloseAndFlush();
}
