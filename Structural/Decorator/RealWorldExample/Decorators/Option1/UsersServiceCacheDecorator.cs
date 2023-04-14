using Microsoft.Extensions.Caching.Memory;

namespace Decorator.Decorators.Option1;

// Concrete decorator
public class UsersServiceCacheDecorator : IUsersService
{
    private readonly IUsersService _innerUserService;
    private readonly IMemoryCache _cache;
    
    public UsersServiceCacheDecorator(IUsersService innerUserService, IMemoryCache cache)
    {
        _innerUserService = innerUserService;
        _cache = cache;
    }
    
    public IEnumerable<User> GetAllUsers()
    {
        var entry = _cache.TryGetValue(
            "Users",
            out IEnumerable<User>? cachedUsers);

        if (entry)
        {
            return cachedUsers!;
        }

        var users = _innerUserService.GetAllUsers().ToList();
        _cache.Set(
            "Users",
            users,
            TimeSpan.FromMinutes(1));
        
        return users;
    }
}