using System.Diagnostics;

namespace Decorator.Decorators.Option2;

// Concrete decorator
public class UsersServiceLoggerDecorator : UsersServiceDecorator
{
    private readonly ILogger _logger;

    public UsersServiceLoggerDecorator(IUsersService innerUserService, ILogger<UsersService> logger) : base(innerUserService)
    {
        _logger = logger;
    }
    
    public override IEnumerable<User> GetAllUsers()
    {
        _logger.LogInformation("Getting all users");
        var timer = new Stopwatch();
        timer.Start();
        var users = base.GetAllUsers();
        timer.Stop();
        _logger.LogInformation($"Users obtained in {timer.Elapsed:m\\:ss\\.ff}");

        return users;
    }
}
