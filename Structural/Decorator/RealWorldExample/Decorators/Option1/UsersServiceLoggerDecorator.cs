using System.Diagnostics;

namespace Decorator.Decorators.Option1;

// Concrete decorator
public class UsersServiceLoggerDecorator : IUsersService
{
    private readonly IUsersService _innerUsersService;
    private readonly ILogger _logger;

    public UsersServiceLoggerDecorator(IUsersService innerUsersService, ILogger logger)
    {
        _innerUsersService = innerUsersService;
        _logger = logger;
    }
    
    public IEnumerable<User> GetAllUsers()
    {
        _logger.LogInformation("Getting all users");
        var timer = new Stopwatch();
        timer.Start();
        var users = _innerUsersService.GetAllUsers();
        timer.Stop();
        _logger.LogInformation($"Users obtained in {timer.Elapsed:m\\:ss\\.ff}");

        return users;
    }
}
