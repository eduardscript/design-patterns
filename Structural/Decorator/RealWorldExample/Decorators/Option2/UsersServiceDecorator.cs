namespace Decorator.Decorators.Option2;

// Base decorator
public class UsersServiceDecorator : IUsersService
{
    private readonly IUsersService _innerUserService;

    protected UsersServiceDecorator(IUsersService innerUserService)
    {
        _innerUserService = innerUserService;
    }
    
    public virtual IEnumerable<User> GetAllUsers()
    {
        return _innerUserService.GetAllUsers();
    }
}