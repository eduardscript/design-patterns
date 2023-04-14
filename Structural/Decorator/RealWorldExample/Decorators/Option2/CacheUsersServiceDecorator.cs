using Microsoft.Extensions.Caching.Memory;

namespace Decorator.Decorators.Option2;

// Concrete decorator
public class UsersServiceCacheDecorator : UsersServiceDecorator
{
    private readonly IMemoryCache _cache;

    public UsersServiceCacheDecorator(IUsersService innerUserService, IMemoryCache cache) : base(innerUserService)
    {
        _cache = cache;
    }
    
    public override IEnumerable<User> GetAllUsers()
    {
        var entry = _cache.TryGetValue(
            "Users",
            out IEnumerable<User>? cachedUsers);

        if (entry)
        {
            return cachedUsers!;
        }

        var users = base.GetAllUsers().ToList();
        _cache.Set(
            "Users",
            users,
            TimeSpan.FromMinutes(1));
        
        return users;
    }
}